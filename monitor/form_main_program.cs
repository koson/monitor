using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using ZedGraph;
using System.Threading;
using MSExcel = Microsoft.Office.Interop.Excel;
using NationalInstruments;
using NationalInstruments.DAQmx;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace monitor
{

    public partial class form_main_program : Form
    {
        private byte[] buff = new byte[6];                        //接受stm32 
        private byte[] set_speed_mode = new byte[2];                          //发送stm32转速
        private int[] limit_parameter = new int[8];

        private DateTime before_date;
        private DateTime after_date;
        /* modbus 功能*/
        int modbus_counter;
        private byte[] moto_buff = new byte[10];
        //写
        private byte[] modbus_start = new byte[] { 0x01, 0x06, 0x20, 0x00, 0x00, 0x01, 200, 1 };   //电机开始
        private byte[] modbus_stop = new byte[] { 0x01, 0x06, 0x20, 0x00, 0x00, 0x05, 0x42, 0x09 };    //电机停转
        //读
        private byte[] moto_rspeed = new byte[8] { 0x01, 0x03, 0x10, 0x0F, 0x00, 0x01, 0xB0, 0xC9 };    //电机转速
        private byte[] moto_rcurrent = new byte[8] { 0x01, 0x03, 0x10, 0x04, 0x00, 0x01, 0xC1, 0x0B };  //电机电流
        private byte[] moto_rpower = new byte[8] { 0x01, 0x03, 0x10, 0x03, 0x00, 0x01, 0x70, 0xCA };    //电机功率
        private byte[] moto_rvoltage = new byte[8] { 0x01, 0x03, 0x30, 0x00, 0x00, 0x01, 0x8B, 0x0A };  //电机电压

        /*下位机读取数据*/
        private long counter;
        //电机modbus
        private int moto_speed;
        private int moto_current;
        private int moto_voltage;
        private int moto_power;
        //stm32
        private int flow;
        private int temperature;
        //NI
        private double pressure;
        private double[] single_pressure = null;

        /*上位机设置参数*/
        private int set_speed;
        private int set_load;
        private int set_frquency;
        private int set_time;
        private string set_mode;
        private string seria_name;
        private string moto_seria_name;

        private ParameSetForm paramesetform;
        private SpeedModeForm speedmodeform;
        private TestModeForm testmodeform;

        //NI采集卡
        private AnalogSingleChannelReader analogInReader;
        private Task myTask;
        private AsyncCallback analogCallback;
        private string physicalChannel;
        /*绘图*/
        private PointPairList list_moto_speed;
        private PointPairList list_flow;
        private GraphPane Panel;
        /*数据保存*/
        StreamWriter sw;
        private string path;
        private int row_count = 0;
        private FileStream TheFile;
        private MSExcel.Application excel_app;
        private MSExcel._Workbook book;
        private MSExcel._Worksheet sheet;
        // 构造方法
        public form_main_program()
        {
            InitializeComponent();

            paramesetform = new ParameSetForm();
            speedmodeform = new SpeedModeForm();
            testmodeform = new TestModeForm();
            list_moto_speed = new PointPairList();
            list_flow = new PointPairList();
            myTask = new Task();
        }
        // 窗口初始化
        private void form_main_program_Load(object sender, EventArgs e)
        {
            initialize();
        }

        private void form_main_program_FormClosing(object sender, FormClosingEventArgs e)
        {
            close_save_excel();
            System.Environment.Exit(System.Environment.ExitCode);
            this.Dispose();
            this.Close();
        }
        private void ParaSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (paramesetform.ShowDialog() == DialogResult.OK)
            {
                seria_name = paramesetform.Seria_Name;
                moto_seria_name = paramesetform.Moto_Seria_Name;
                limit_parameter[0] = paramesetform.Limit_Speed_Min;
                limit_parameter[1] = paramesetform.Limit_Speed_Max;
                limit_parameter[2] = paramesetform.Limit_Press_Min;
                limit_parameter[3] = paramesetform.Limit_Press_Max;
                limit_parameter[4] = paramesetform.Limit_Flow_Min;
                limit_parameter[5] = paramesetform.Limit_Flow_Max;
                limit_parameter[6] = paramesetform.Limit_Contain_Min;
                limit_parameter[7] = paramesetform.Limit_Contain_Max;
                label_require_min_data_speed.Text = limit_parameter[0].ToString();
                label_require_max_data_speed.Text = limit_parameter[1].ToString();
                label_require_min_data_press.Text = limit_parameter[2].ToString();
                label_require_max_data_press.Text = limit_parameter[3].ToString();
                label_require_min_data_float.Text = limit_parameter[4].ToString();
                label_require_max_data_float.Text = limit_parameter[5].ToString();
                label_require_min_data_contain.Text = limit_parameter[6].ToString();
                label_require_max_data_contain.Text = limit_parameter[7].ToString();

                physicalChannel = paramesetform.PhysicalChannel;
            }
        }
        /*设定*/
        private void SpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (speedmodeform.ShowDialog() == DialogResult.OK)
            {
                /*modbus电机串口发送*/
                set_speed = speedmodeform.Speed;
                /*stm32串口发送*/
                set_load = speedmodeform.MLoad;
                set_frquency = speedmodeform.Frequency;
                set_time = speedmodeform.Settime;
                set_mode = speedmodeform.Mode_name;
            }
        }
        private void TestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (testmodeform.ShowDialog() == DialogResult.OK)
            {
                /*modbus电机串口发送*/
                set_speed = testmodeform.Speed;
                /*stm32串口发送*/
                set_load = testmodeform.Press;
                set_mode = testmodeform.Mode_name;
            }
        }

        private void startruningbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (startruningbutton.Text == "开始")
                {
                    startruningbutton.Text = "关闭";
                    serial_init();
                    moto_serial_init();
                    led1.Value = true;
                    mode_init();
                    send_data(set_speed_mode);
                    counter = -1;
                    modbus_counter = -1;
                    if (myTask != null)
                    {
                        myTask.Dispose();
                    }
                    myTask = new Task();
                    try
                    {
                        myTask.AIChannels.CreateVoltageChannel(
                        physicalChannel,
                        "Voltage",
                        AITerminalConfiguration.Rse,
                        0,
                        10,
                        AIVoltageUnits.Volts);

                        myTask.Timing.ConfigureSampleClock(
                        "",              //内部时钟
                        set_frquency,            //采样频率
                        SampleClockActiveEdge.Rising,
                        SampleQuantityMode.ContinuousSamples,
                        300
                        );

                        myTask.Control(TaskAction.Verify);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("参数确认:" + ex.Message, "Error");
                        return;
                    }

                    analogInReader = new AnalogSingleChannelReader(myTask.Stream);
                    analogCallback = new AsyncCallback(AnalogInCallback);
                    myTask.Start();
                    analogInReader.SynchronizeCallbacks = true;

                    // 模式指令发送
                }
                else
                {
                    startruningbutton.Text = "开始";
                    timer.Stop();
                    serial_init();
                    if (myTask != null)
                    {
                        myTask.Dispose();
                    }
                    myTask = new Task();
                    led1.Value = false;
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("开始:" + ex.Message, "Error");
                startruningbutton.Text = "开始";
                timer.Stop();
                serial_init();
                if (myTask != null)
                {
                    myTask.Dispose();
                }
                myTask = new Task();
                led1.Value = false;
                return;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (startruningbutton.Text == "关闭")
            {
                led7.Value = true;
                before_date = System.DateTime.Now;
                timer.Start();
                byte[] a = new byte[] { 64, 65 };
                send_data(a);
            }
        }
        private void button_reset_Click(object sender, EventArgs e)
        {
            try
            {
                led7.Value = false;
                byte[] b = new byte[] { 65, 64 };
                send_data(b);

                serial_init();
                led1.Value = false;
                startruningbutton.Text = "开始";

                timer.Stop();
                reset_gauge();
                list_moto_speed.Clear();
                list_flow.Clear();
                zeggraph_init();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error2:" + ex.Message, "Error");
                return;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            /* 发送指令*/
            modbus_counter++;
            if (modbus_counter == 4)
            {
                modbus_counter = 0;
            }
            switch (modbus_counter)
            {
                case 0:
                    moto_send_data(moto_rspeed);
                    break;
                case 1:
                    moto_send_data(moto_rcurrent);
                    break;
                case 2:
                    moto_send_data(moto_rpower);
                    break;
                case 3:
                    moto_send_data(moto_rvoltage);
                    break;
            } 
            //modbus
            /*   时间   */
            after_date = System.DateTime.Now;
            TimeSpan ts = after_date.Subtract(before_date);
            int second = (int)ts.TotalMilliseconds;
            //画图
            analogInReader.BeginReadMultiSample(-1, analogCallback, myTask);
            label_time.Text = second.ToString();
            show_data();
            if (is_running_ok() == false)
            {
                timer.Stop();
                led2.Value = true;
                MessageBox.Show("设备故障！");
                button_start.Text = "开始";
                if (myTask != null)
                {
                    myTask.Dispose();
                }
                serialPort.Close();
                moto_serialPort.Close();
                sw.Close();
                TheFile.Close();
            }
            else
            {
                if (second >= set_time*1000)
                {
                    timer.Stop();
                    led1.Value = false;
                    MessageBox.Show("试验时间到达");
                    button_start.Text = "开始";
                    if (myTask != null)
                    {
                        myTask.Dispose();
                    }
                    myTask = new Task();
                    serialPort.Close();
                    moto_serialPort.Close();
                    //保存上一次的数据到excel表中
                    save_excel();
                    sw.Close();
                    TheFile.Close();
                }
            }

        }
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialPort.Read(buff, 0, 6);
            data_analysis();
        }
        private void moto_serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            moto_serialPort.Read(moto_buff, 0, 10);
            moto_data_analysis();
        }

        private void motoStartbutton_Click(object sender, EventArgs e)
        {
            moto_send_data(modbus_start);
        }

        private void motoStopbutton_Click(object sender, EventArgs e)
        {
            string str = Encoding.ASCII.GetString(modbus_stop);
            moto_serialPort.Write(str);
        }

        private void slide_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
        {
            double temp = slide.Value*4096;
            set_speed_mode[0] = (byte)(temp / 256);
            set_speed_mode[1] = (byte)(temp % 256);
            send_data(set_speed_mode);
        }
        /***********************功能函数****************************/
        private void initialize()
        {
            form_main_program.CheckForIllegalCrossThreadCalls = false;
            excel_app = new MSExcel.ApplicationClass();        //初始化 
            book = excel_app.Workbooks.Add(Missing.Value);
            excel_app.Visible = false;
            excel_app.DisplayAlerts = false;

            if (!File.Exists("data.txt"))
            {
                TheFile = new FileStream("data.txt", FileMode.Create);
                TheFile.Close();
            }
            //EXCEL COM口
            try
            {
                sheet = (MSExcel._Worksheet)book.Worksheets.get_Item(1);
            }
            catch (System.Exception ex)
            {
                sheet = (MSExcel._Worksheet)book.Worksheets.Add(Missing.Value, book.Worksheets[0], 0, Missing.Value);
            }
            /*zed1曲线设置*/
            zeggraph_init();
        }
        /*stm32串口接受数据*/
        private void data_analysis()
        {
            try
            {

                    if ((buff[0] == 'A') && (buff[5] == 'B'))
                    {
                        flow = buff[1];
                        flow = flow << 8;
                        flow = flow + buff[2];

                        temperature = buff[3];
                        temperature = temperature << 8;
                        temperature = temperature + buff[4];
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error3:" + ex.Message, "Error");
                return;
            }
        }
        /*modbus伺服电机串口接受数据*/
        private void moto_data_analysis()
        {
            try
            {
                modbus_process();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error3:" + ex.Message, "Error");
                return;
            }
        }
        /*modbus控制指令*/
        private void mode_init()
        {
            if (set_mode == "恒速模式")
            {
                set_speed_mode[0] = (byte)(set_speed / 256);
                set_speed_mode[1] = (byte)(set_speed % 256);
            }
            if (set_mode == "出厂试验")
            {
            }
            set_mode = "初始化";
        }
        /* 发送stm32控制指令*/
        private void send_data(byte[] information)
        {
            string str = Encoding.ASCII.GetString(information);
            if (serialPort.IsOpen == false)
            {
                serialPort.Open();
            }
            serialPort.Write(str);//直接发送字符串
        }
        /* 发送电机控制指令*/
        private void moto_send_data(byte[] information)
        {
            if (moto_serialPort.IsOpen == false)
            {
                moto_serialPort.Open();
            }
            moto_serialPort.Write(information, 0, information.Length);
        }
        /* stm32串口初始化*/
        private void serial_init()
        {
            if (serialPort.IsOpen == true)       //如果打开状态，则先关闭一下
            {
                serialPort.Close();
            }
            serialPort.PortName = seria_name;
            // 已选串口设置
            serialPort.BaudRate = 115200;       // 设置波特率
            serialPort.DataBits = 8;            // 设置数据位 
            serialPort.StopBits = StopBits.One; // 设置停止位
            serialPort.Parity = Parity.None;    //设置奇偶校验位
            serialPort.ReceivedBytesThreshold = 100; //1kb触发一次事件
            serialPort.ReadBufferSize = 1000;
        }
        /* 电机串口初始化*/
        private void moto_serial_init()
        {
            if (moto_serialPort.IsOpen == true)       //如果打开状态，则先关闭一下
            {
                moto_serialPort.Close();
            }
            moto_serialPort.PortName = moto_seria_name;
            // 已选串口设置
            moto_serialPort.BaudRate = 9600;       // 设置波特率
            moto_serialPort.DataBits = 8;            // 设置数据位 
            moto_serialPort.StopBits = StopBits.One; // 设置停止位
            moto_serialPort.Parity = Parity.None;    //设置奇偶校验位
            moto_serialPort.ReceivedBytesThreshold = 8; //1kb触发一次事件
            moto_serialPort.ReadBufferSize = 100;
        }
        private void zeggraph_init()
        {
            Panel = ZedGraph.GraphPane;
            counter = 0;
            Panel.Title.Text = "电机实时曲线";
            Panel.Chart.Border.IsVisible = true;
            Panel.Legend.IsVisible = false;
            Panel.CurveList.Clear();

            LineItem curve_moto_speed = Panel.AddCurve("电机", list_moto_speed, Color.Red, SymbolType.None);
            ZedGraph.Invalidate();
            curve_moto_speed.Line.Width = 2F;
            curve_moto_speed.Symbol.Fill = new Fill(Color.White, Color.Blue, Color.White);
            curve_moto_speed.Symbol.Size = 5;

            Panel.XAxis.Title.Text = "个数";
            Panel.XAxis.Scale.FontSpec.Size = 10;
            Panel.XAxis.Scale.Max = 1000;
            Panel.XAxis.Scale.Min = 0;
            Panel.XAxis.Scale.MajorStep = Panel.XAxis.Scale.Max / 10;
            Panel.XAxis.Scale.MinorStep = Panel.XAxis.Scale.MajorStep / 10;
            Panel.XAxis.MajorGrid.IsVisible = true;

            Panel.YAxis.Title.Text = "转速";
            Panel.YAxis.Scale.FontSpec.Size = 10;
            Panel.YAxis.Scale.Max = 1500;
            Panel.YAxis.Scale.Min = -10;
            Panel.YAxis.Scale.MajorStep = 200;
            Panel.YAxis.Scale.MinorStep = 40;
            Panel.YAxis.MajorGrid.IsVisible = true;
            Panel.Chart.Fill = new Fill(Color.White, Color.SlateBlue, 23.0F);

            ZedGraph.AxisChange();
        }
        /* 关闭保存数据*/        
        private void close_save_excel()
        {
            path = Application.StartupPath + "\\" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".xlsx";    //路径
            if (File.Exists(path))          //如果已经存在，删除
            {
                File.Delete(path);
            }
            book.SaveAs(path, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, MSExcel.XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            book.Close(false, Missing.Value, Missing.Value);
            excel_app.Quit();
            sheet = null;
            book = null;
            excel_app = null;
            GC.Collect();
        }
        /*单次实验保存*/
        private void save_excel()
        {
            sheet.Name = "第一页";
            row_count++;
            sheet.Cells[row_count, 1] = flow.ToString();
            sheet.Cells[row_count, 2] = temperature.ToString();
        }
        private bool is_running_ok()
        {
            bool flag = true;
            if (moto_speed < limit_parameter[0] || moto_speed > limit_parameter[1])
            {
                flag = false;
                led2.Value = true;
            }
            return flag;
        }
        private void show_data()
        {
            moto_speed_label.Text = moto_speed.ToString();
            moto_current_label.Text = moto_current.ToString();
            moto_power_label.Text = moto_power.ToString();

            press_gauge.Value = Math.Round(pressure, 2);
            label_press_data.Text = Math.Round(pressure, 2).ToString();

            //stm32 接受数据绘制
            flow_gauge.Value = flow;
            label_float_data.Text = flow.ToString();

            thermometer.Value = temperature;
            tempertature_label.Text = temperature.ToString();

            //画图
            GraphPane MyPane1 = ZedGraph.GraphPane;
            counter++;
            list_moto_speed.Add(counter, pressure);
            moto_current_meter.Value = moto_current;
            moto_press_meter.Value = moto_power;
            if (counter > (MyPane1.XAxis.Scale.Max - MyPane1.XAxis.Scale.Min))
            {
                MyPane1.XAxis.Scale.Min = counter - (MyPane1.XAxis.Scale.Max - MyPane1.XAxis.Scale.Min);
                MyPane1.XAxis.Scale.Max = counter;

            }
            ZedGraph.BeginInvoke(
                new MethodInvoker(
                    delegate
                    {
                        this.ZedGraph.AxisChange();
                        this.ZedGraph.Refresh();
                        this.ZedGraph.IsShowPointValues = false;
                    }
                    )
                );
        }
        private void AnalogInCallback(IAsyncResult ar)
        {
            TheFile = new FileStream("data.txt", FileMode.Append);
            sw = new StreamWriter(TheFile);
            try
            {
                if (myTask != null && myTask == ar.AsyncState)
                {
                    // Read the available data from the channels
                    single_pressure = analogInReader.EndReadMultiSample(ar);
                    // Plot your data here
                    for (int i = 0; i < single_pressure.Length; i++)
                    {
                        sw.WriteLine(single_pressure[i] + " ");
                        pressure = single_pressure[i];
                    }
                    sw.Close();
                    TheFile.Close();
                }
            }
            catch (DaqException exception)
            {
                // Display Errors
                MessageBox.Show(exception.Message);
                myTask = null;
                myTask.Dispose();
            }
        }
        private void modbus_process()
        {
            /*modbus协议*/
            byte[] data_crc = new byte[6];
            uint crc_value;
            for (int i = 0; i < 6; i++)
            {
                data_crc[i] = moto_buff[i];
            }
            crc_value = crc_chk_value(data_crc);
            if (crc_value / (0xff + 1) == moto_buff[6] && crc_value % (0xff + 1) == moto_buff[7])
            {
                int function = moto_buff[2]*(0xff+1)+moto_buff[3];
                switch (moto_buff[1]) 
                {
                    case 0x03:
                        if(function == 0x100f)
                        {
                             moto_speed = moto_buff[4]*(0xff+1)+moto_buff[5];
                        }
                        if(function == 0x1004)
                        {
                             moto_current = moto_buff[4]*(0xff+1)+moto_buff[5];
                        }
                        if(function == 0x1003)
                        {
                            moto_power = moto_buff[4]*(0xff+1)+moto_buff[5];
                        }
                        if(function == 0x3000)
                        {
                            moto_voltage = moto_buff[4] * (0xff + 1) + moto_buff[5];
                        }
                        break;
                    case 0x06:
                        if(function == 0x2000)
                        {

                        }
                        break;
                }
            }
        }
        private uint crc_chk_value(byte[] data_value)
        {
            uint crc_value;
            crc_value = 0xffff;
            int length = data_value.Length;
            int i = 0;
            while ((length--) != 0)
            {
                crc_value ^= data_value[i++];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc_value & 0x0001) == 1)
                    {
                        crc_value = (crc_value >> 1) ^ 0xa001;
                    }
                    else
                    {
                        crc_value = crc_value >>1;
                    }
                }
            }
            return (crc_value);
        }
        //仪表重置
        private void reset_gauge()
        {
            moto_speed_label.Text = "0";

            moto_current_meter.Value = 0;
            moto_current_label.Text = "0";

            moto_press_meter.Value = 0;
            moto_power_label.Text = "0";

            press_gauge.Value = 0;
            label_press_data.Text = "0";

            flow_gauge.Value = 0;
            label_float_data.Text = "0";

            thermometer.Value = 0;
            tempertature_label.Text = "0";

            label_result_speed_data.Text = "0";
            label_result_press_data.Text = "0";
            label_result_float_data.Text = "0";

            label_time.Text = "0";
        }
    }
}
