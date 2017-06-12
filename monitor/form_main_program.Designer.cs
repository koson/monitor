namespace monitor
{
    partial class form_main_program
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.led1 = new NationalInstruments.UI.WindowsForms.Led();
            this.label_time_unit = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.led2 = new NationalInstruments.UI.WindowsForms.Led();
            this.thermometer = new NationalInstruments.UI.WindowsForms.Thermometer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MotogroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.moto_power_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.moto_speed_label = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.moto_current_label = new System.Windows.Forms.Label();
            this.speed_label = new System.Windows.Forms.Label();
            this.power_label = new System.Windows.Forms.Label();
            this.current_label = new System.Windows.Forms.Label();
            this.moto_press_meter = new NationalInstruments.UI.WindowsForms.Meter();
            this.moto_current_meter = new NationalInstruments.UI.WindowsForms.Meter();
            this.ZedGraph = new ZedGraph.ZedGraphControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tempertature_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flow_gauge = new NationalInstruments.UI.WindowsForms.Gauge();
            this.press_gauge = new NationalInstruments.UI.WindowsForms.Gauge();
            this.label_float_unit = new System.Windows.Forms.Label();
            this.label_float_data = new System.Windows.Forms.Label();
            this.label_float = new System.Windows.Forms.Label();
            this.label_press_unit = new System.Windows.Forms.Label();
            this.label_press_data = new System.Windows.Forms.Label();
            this.label_press = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ParaSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.zoomStateStackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alarm_groupBox = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.led6 = new NationalInstruments.UI.WindowsForms.Led();
            this.led5 = new NationalInstruments.UI.WindowsForms.Led();
            this.led4 = new NationalInstruments.UI.WindowsForms.Led();
            this.led3 = new NationalInstruments.UI.WindowsForms.Led();
            this.moto_serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startruningbutton = new System.Windows.Forms.Button();
            this.require_groupBox = new System.Windows.Forms.GroupBox();
            this.label_require_max_data_contain = new System.Windows.Forms.Label();
            this.label_require_max_data_float = new System.Windows.Forms.Label();
            this.label_require_max_data_press = new System.Windows.Forms.Label();
            this.label_require_max_data_speed = new System.Windows.Forms.Label();
            this.label_require_min_data_contain = new System.Windows.Forms.Label();
            this.label_require_min_data_float = new System.Windows.Forms.Label();
            this.label_require_min_data_press = new System.Windows.Forms.Label();
            this.label_require_min_data_speed = new System.Windows.Forms.Label();
            this.label_require_data_contain = new System.Windows.Forms.Label();
            this.label_require_data_float = new System.Windows.Forms.Label();
            this.label_require_data_press = new System.Windows.Forms.Label();
            this.label_require_data_speed = new System.Windows.Forms.Label();
            this.label_require_contain_unit = new System.Windows.Forms.Label();
            this.label_require_float_unit = new System.Windows.Forms.Label();
            this.label_require_press_unit = new System.Windows.Forms.Label();
            this.label_require_speed_unit = new System.Windows.Forms.Label();
            this.label_require = new System.Windows.Forms.Label();
            this.result_groupBox = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label_result_presspower_data = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_result_power_data = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_result_currentrate_data = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_result_keepvola_data = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_result_maidongpress_data = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_result_contain_unit = new System.Windows.Forms.Label();
            this.label_result_contain_data = new System.Windows.Forms.Label();
            this.label_result_contain = new System.Windows.Forms.Label();
            this.label_result_float_unit = new System.Windows.Forms.Label();
            this.label_result_float_data = new System.Windows.Forms.Label();
            this.label_result_float = new System.Windows.Forms.Label();
            this.label_result_press_unit = new System.Windows.Forms.Label();
            this.label_result_press_data = new System.Windows.Forms.Label();
            this.label_result_press = new System.Windows.Forms.Label();
            this.label_result_speed_unit = new System.Windows.Forms.Label();
            this.label_result_speed_data = new System.Windows.Forms.Label();
            this.label_result_speed = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.moto_speedlabel = new System.Windows.Forms.Label();
            this.motoStopbutton = new System.Windows.Forms.Button();
            this.motoStartbutton = new System.Windows.Forms.Button();
            this.formmainprogramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.led1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thermometer)).BeginInit();
            this.panel3.SuspendLayout();
            this.MotogroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moto_press_meter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moto_current_meter)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flow_gauge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.press_gauge)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomStateStackBindingSource)).BeginInit();
            this.alarm_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.led6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.require_groupBox.SuspendLayout();
            this.result_groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formmainprogramBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(142, 151);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(54, 32);
            this.button_reset.TabIndex = 30;
            this.button_reset.Text = "重置";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(18, 151);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(71, 32);
            this.button_start.TabIndex = 28;
            this.button_start.Text = "开始采样";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // led1
            // 
            this.led1.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.led1.Location = new System.Drawing.Point(107, 24);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(50, 50);
            this.led1.TabIndex = 85;
            // 
            // label_time_unit
            // 
            this.label_time_unit.AutoSize = true;
            this.label_time_unit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_time_unit.Location = new System.Drawing.Point(153, 120);
            this.label_time_unit.Name = "label_time_unit";
            this.label_time_unit.Size = new System.Drawing.Size(26, 16);
            this.label_time_unit.TabIndex = 84;
            this.label_time_unit.Text = "ms";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_time.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_time.Location = new System.Drawing.Point(70, 120);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(18, 18);
            this.label_time.TabIndex = 84;
            this.label_time.Text = "0";
            // 
            // led2
            // 
            this.led2.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.led2.Location = new System.Drawing.Point(83, 20);
            this.led2.Name = "led2";
            this.led2.OnColor = System.Drawing.Color.Red;
            this.led2.Size = new System.Drawing.Size(64, 64);
            this.led2.TabIndex = 86;
            // 
            // thermometer
            // 
            this.thermometer.Location = new System.Drawing.Point(347, 15);
            this.thermometer.Name = "thermometer";
            this.thermometer.Size = new System.Drawing.Size(72, 176);
            this.thermometer.TabIndex = 81;
            this.thermometer.ThermometerStyle = NationalInstruments.UI.ThermometerStyle.Flat;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.MotogroupBox);
            this.panel3.Location = new System.Drawing.Point(-2, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(756, 391);
            this.panel3.TabIndex = 63;
            // 
            // MotogroupBox
            // 
            this.MotogroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MotogroupBox.Controls.Add(this.label5);
            this.MotogroupBox.Controls.Add(this.moto_power_label);
            this.MotogroupBox.Controls.Add(this.label3);
            this.MotogroupBox.Controls.Add(this.moto_speed_label);
            this.MotogroupBox.Controls.Add(this.label24);
            this.MotogroupBox.Controls.Add(this.moto_current_label);
            this.MotogroupBox.Controls.Add(this.speed_label);
            this.MotogroupBox.Controls.Add(this.power_label);
            this.MotogroupBox.Controls.Add(this.current_label);
            this.MotogroupBox.Controls.Add(this.moto_press_meter);
            this.MotogroupBox.Controls.Add(this.moto_current_meter);
            this.MotogroupBox.Controls.Add(this.ZedGraph);
            this.MotogroupBox.Location = new System.Drawing.Point(1, -1);
            this.MotogroupBox.Name = "MotogroupBox";
            this.MotogroupBox.Size = new System.Drawing.Size(756, 391);
            this.MotogroupBox.TabIndex = 58;
            this.MotogroupBox.TabStop = false;
            this.MotogroupBox.Text = "电机";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(657, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 88;
            this.label5.Text = "Kw";
            // 
            // moto_power_label
            // 
            this.moto_power_label.AutoSize = true;
            this.moto_power_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.moto_power_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.moto_power_label.CausesValidation = false;
            this.moto_power_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.moto_power_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.moto_power_label.Location = new System.Drawing.Point(616, 340);
            this.moto_power_label.Name = "moto_power_label";
            this.moto_power_label.Size = new System.Drawing.Size(18, 18);
            this.moto_power_label.TabIndex = 87;
            this.moto_power_label.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(288, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 86;
            this.label3.Text = "r/min";
            // 
            // moto_speed_label
            // 
            this.moto_speed_label.AutoSize = true;
            this.moto_speed_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.moto_speed_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.moto_speed_label.CausesValidation = false;
            this.moto_speed_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.moto_speed_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.moto_speed_label.Location = new System.Drawing.Point(247, 340);
            this.moto_speed_label.Name = "moto_speed_label";
            this.moto_speed_label.Size = new System.Drawing.Size(18, 18);
            this.moto_speed_label.TabIndex = 85;
            this.moto_speed_label.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(657, 165);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(17, 16);
            this.label24.TabIndex = 84;
            this.label24.Text = "A";
            // 
            // moto_current_label
            // 
            this.moto_current_label.AutoSize = true;
            this.moto_current_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.moto_current_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.moto_current_label.CausesValidation = false;
            this.moto_current_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.moto_current_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.moto_current_label.Location = new System.Drawing.Point(616, 163);
            this.moto_current_label.Name = "moto_current_label";
            this.moto_current_label.Size = new System.Drawing.Size(18, 18);
            this.moto_current_label.TabIndex = 83;
            this.moto_current_label.Text = "0";
            // 
            // speed_label
            // 
            this.speed_label.AutoSize = true;
            this.speed_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.speed_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.speed_label.Location = new System.Drawing.Point(174, 340);
            this.speed_label.Name = "speed_label";
            this.speed_label.Size = new System.Drawing.Size(44, 18);
            this.speed_label.TabIndex = 70;
            this.speed_label.Text = "转速";
            // 
            // power_label
            // 
            this.power_label.AutoSize = true;
            this.power_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.power_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.power_label.Location = new System.Drawing.Point(511, 340);
            this.power_label.Name = "power_label";
            this.power_label.Size = new System.Drawing.Size(80, 18);
            this.power_label.TabIndex = 69;
            this.power_label.Text = "功率(Kw)";
            // 
            // current_label
            // 
            this.current_label.AutoSize = true;
            this.current_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.current_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.current_label.Location = new System.Drawing.Point(520, 163);
            this.current_label.Name = "current_label";
            this.current_label.Size = new System.Drawing.Size(71, 18);
            this.current_label.TabIndex = 68;
            this.current_label.Text = "电流(A)";
            // 
            // moto_press_meter
            // 
            this.moto_press_meter.Location = new System.Drawing.Point(489, 186);
            this.moto_press_meter.Name = "moto_press_meter";
            this.moto_press_meter.Size = new System.Drawing.Size(246, 129);
            this.moto_press_meter.TabIndex = 60;
            // 
            // moto_current_meter
            // 
            this.moto_current_meter.Location = new System.Drawing.Point(489, 13);
            this.moto_current_meter.Name = "moto_current_meter";
            this.moto_current_meter.PointerColor = System.Drawing.Color.Black;
            this.moto_current_meter.Size = new System.Drawing.Size(246, 129);
            this.moto_current_meter.TabIndex = 59;
            // 
            // ZedGraph
            // 
            this.ZedGraph.BackColor = System.Drawing.Color.RoyalBlue;
            this.ZedGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ZedGraph.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ZedGraph.Location = new System.Drawing.Point(5, 21);
            this.ZedGraph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ZedGraph.Name = "ZedGraph";
            this.ZedGraph.ScrollGrace = 0D;
            this.ZedGraph.ScrollMaxX = 0D;
            this.ZedGraph.ScrollMaxY = 0D;
            this.ZedGraph.ScrollMaxY2 = 0D;
            this.ZedGraph.ScrollMinX = 0D;
            this.ZedGraph.ScrollMinY = 0D;
            this.ZedGraph.ScrollMinY2 = 0D;
            this.ZedGraph.Size = new System.Drawing.Size(478, 288);
            this.ZedGraph.TabIndex = 58;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.tempertature_label);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.flow_gauge);
            this.panel4.Controls.Add(this.press_gauge);
            this.panel4.Controls.Add(this.label_float_unit);
            this.panel4.Controls.Add(this.thermometer);
            this.panel4.Controls.Add(this.label_float_data);
            this.panel4.Controls.Add(this.label_float);
            this.panel4.Controls.Add(this.label_press_unit);
            this.panel4.Controls.Add(this.label_press_data);
            this.panel4.Controls.Add(this.label_press);
            this.panel4.Location = new System.Drawing.Point(-2, 419);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(483, 227);
            this.panel4.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(451, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 84;
            this.label2.Text = "℃";
            // 
            // tempertature_label
            // 
            this.tempertature_label.AutoSize = true;
            this.tempertature_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tempertature_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tempertature_label.CausesValidation = false;
            this.tempertature_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tempertature_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tempertature_label.Location = new System.Drawing.Point(410, 175);
            this.tempertature_label.Name = "tempertature_label";
            this.tempertature_label.Size = new System.Drawing.Size(18, 18);
            this.tempertature_label.TabIndex = 83;
            this.tempertature_label.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(410, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 82;
            this.label1.Text = "温度";
            // 
            // flow_gauge
            // 
            this.flow_gauge.Location = new System.Drawing.Point(181, 3);
            this.flow_gauge.Name = "flow_gauge";
            this.flow_gauge.Size = new System.Drawing.Size(160, 152);
            this.flow_gauge.TabIndex = 81;
            // 
            // press_gauge
            // 
            this.press_gauge.Location = new System.Drawing.Point(3, 3);
            this.press_gauge.Name = "press_gauge";
            this.press_gauge.Range = new NationalInstruments.UI.Range(0D, 25D);
            this.press_gauge.Size = new System.Drawing.Size(160, 152);
            this.press_gauge.TabIndex = 80;
            // 
            // label_float_unit
            // 
            this.label_float_unit.AutoSize = true;
            this.label_float_unit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_float_unit.Location = new System.Drawing.Point(280, 187);
            this.label_float_unit.Name = "label_float_unit";
            this.label_float_unit.Size = new System.Drawing.Size(35, 16);
            this.label_float_unit.TabIndex = 75;
            this.label_float_unit.Text = "L/m";
            // 
            // label_float_data
            // 
            this.label_float_data.AutoSize = true;
            this.label_float_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_float_data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_float_data.CausesValidation = false;
            this.label_float_data.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_float_data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_float_data.Location = new System.Drawing.Point(239, 187);
            this.label_float_data.Name = "label_float_data";
            this.label_float_data.Size = new System.Drawing.Size(18, 18);
            this.label_float_data.TabIndex = 74;
            this.label_float_data.Text = "0";
            // 
            // label_float
            // 
            this.label_float.AutoSize = true;
            this.label_float.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_float.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_float.Location = new System.Drawing.Point(176, 162);
            this.label_float.Name = "label_float";
            this.label_float.Size = new System.Drawing.Size(44, 18);
            this.label_float.TabIndex = 73;
            this.label_float.Text = "流量";
            // 
            // label_press_unit
            // 
            this.label_press_unit.AutoSize = true;
            this.label_press_unit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_press_unit.Location = new System.Drawing.Point(99, 189);
            this.label_press_unit.Name = "label_press_unit";
            this.label_press_unit.Size = new System.Drawing.Size(35, 16);
            this.label_press_unit.TabIndex = 72;
            this.label_press_unit.Text = "MPa";
            // 
            // label_press_data
            // 
            this.label_press_data.AutoSize = true;
            this.label_press_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_press_data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_press_data.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_press_data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_press_data.Location = new System.Drawing.Point(63, 189);
            this.label_press_data.Name = "label_press_data";
            this.label_press_data.Size = new System.Drawing.Size(18, 18);
            this.label_press_data.TabIndex = 70;
            this.label_press_data.Text = "0";
            // 
            // label_press
            // 
            this.label_press.AutoSize = true;
            this.label_press.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_press.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_press.Location = new System.Drawing.Point(3, 162);
            this.label_press.Name = "label_press";
            this.label_press.Size = new System.Drawing.Size(44, 18);
            this.label_press.TabIndex = 68;
            this.label_press.Text = "压力";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ParaSetToolStripMenuItem,
            this.functionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1273, 25);
            this.menuStrip1.TabIndex = 65;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ParaSetToolStripMenuItem
            // 
            this.ParaSetToolStripMenuItem.Name = "ParaSetToolStripMenuItem";
            this.ParaSetToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.ParaSetToolStripMenuItem.Text = "实验设定";
            this.ParaSetToolStripMenuItem.Click += new System.EventHandler(this.ParaSetToolStripMenuItem_Click);
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpeedToolStripMenuItem,
            this.TestToolStripMenuItem});
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.functionToolStripMenuItem.Text = "功能选择";
            // 
            // SpeedToolStripMenuItem
            // 
            this.SpeedToolStripMenuItem.Name = "SpeedToolStripMenuItem";
            this.SpeedToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.SpeedToolStripMenuItem.Text = "恒速模式";
            this.SpeedToolStripMenuItem.Click += new System.EventHandler(this.SpeedToolStripMenuItem_Click);
            // 
            // TestToolStripMenuItem
            // 
            this.TestToolStripMenuItem.Name = "TestToolStripMenuItem";
            this.TestToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.TestToolStripMenuItem.Text = "出厂试验";
            this.TestToolStripMenuItem.Click += new System.EventHandler(this.TestToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // zoomStateStackBindingSource
            // 
            this.zoomStateStackBindingSource.DataSource = typeof(ZedGraph.ZoomStateStack);
            // 
            // alarm_groupBox
            // 
            this.alarm_groupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.alarm_groupBox.Controls.Add(this.label19);
            this.alarm_groupBox.Controls.Add(this.label18);
            this.alarm_groupBox.Controls.Add(this.label14);
            this.alarm_groupBox.Controls.Add(this.label11);
            this.alarm_groupBox.Controls.Add(this.label8);
            this.alarm_groupBox.Controls.Add(this.led6);
            this.alarm_groupBox.Controls.Add(this.led5);
            this.alarm_groupBox.Controls.Add(this.led4);
            this.alarm_groupBox.Controls.Add(this.led3);
            this.alarm_groupBox.Controls.Add(this.led2);
            this.alarm_groupBox.Location = new System.Drawing.Point(1028, 33);
            this.alarm_groupBox.Name = "alarm_groupBox";
            this.alarm_groupBox.Size = new System.Drawing.Size(241, 386);
            this.alarm_groupBox.TabIndex = 89;
            this.alarm_groupBox.TabStop = false;
            this.alarm_groupBox.Text = "报警指示灯";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(22, 344);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 18);
            this.label19.TabIndex = 96;
            this.label19.Text = "流量";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(22, 269);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 18);
            this.label18.TabIndex = 95;
            this.label18.Text = "温度";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(22, 193);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 18);
            this.label14.TabIndex = 94;
            this.label14.Text = "压力";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(22, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 18);
            this.label11.TabIndex = 93;
            this.label11.Text = "电流";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(22, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 92;
            this.label8.Text = "转速";
            // 
            // led6
            // 
            this.led6.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.led6.Location = new System.Drawing.Point(83, 322);
            this.led6.Name = "led6";
            this.led6.OnColor = System.Drawing.Color.Red;
            this.led6.Size = new System.Drawing.Size(64, 64);
            this.led6.TabIndex = 90;
            // 
            // led5
            // 
            this.led5.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.led5.Location = new System.Drawing.Point(83, 246);
            this.led5.Name = "led5";
            this.led5.OnColor = System.Drawing.Color.Red;
            this.led5.Size = new System.Drawing.Size(64, 64);
            this.led5.TabIndex = 89;
            // 
            // led4
            // 
            this.led4.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.led4.Location = new System.Drawing.Point(83, 176);
            this.led4.Name = "led4";
            this.led4.OnColor = System.Drawing.Color.Red;
            this.led4.Size = new System.Drawing.Size(64, 64);
            this.led4.TabIndex = 88;
            // 
            // led3
            // 
            this.led3.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.led3.Location = new System.Drawing.Point(83, 99);
            this.led3.Name = "led3";
            this.led3.OnColor = System.Drawing.Color.Red;
            this.led3.Size = new System.Drawing.Size(64, 64);
            this.led3.TabIndex = 87;
            // 
            // moto_serialPort
            // 
            this.moto_serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.moto_serialPort_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Controls.Add(this.startruningbutton);
            this.groupBox1.Controls.Add(this.button_start);
            this.groupBox1.Controls.Add(this.label_time_unit);
            this.groupBox1.Controls.Add(this.led1);
            this.groupBox1.Controls.Add(this.label_time);
            this.groupBox1.Controls.Add(this.button_reset);
            this.groupBox1.Location = new System.Drawing.Point(1041, 436);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 200);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // startruningbutton
            // 
            this.startruningbutton.Location = new System.Drawing.Point(18, 35);
            this.startruningbutton.Name = "startruningbutton";
            this.startruningbutton.Size = new System.Drawing.Size(71, 32);
            this.startruningbutton.TabIndex = 90;
            this.startruningbutton.Text = "开始";
            this.startruningbutton.UseVisualStyleBackColor = true;
            this.startruningbutton.Click += new System.EventHandler(this.startruningbutton_Click);
            // 
            // require_groupBox
            // 
            this.require_groupBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.require_groupBox.Controls.Add(this.label_require_max_data_contain);
            this.require_groupBox.Controls.Add(this.label_require_max_data_float);
            this.require_groupBox.Controls.Add(this.label_require_max_data_press);
            this.require_groupBox.Controls.Add(this.label_require_max_data_speed);
            this.require_groupBox.Controls.Add(this.label_require_min_data_contain);
            this.require_groupBox.Controls.Add(this.label_require_min_data_float);
            this.require_groupBox.Controls.Add(this.label_require_min_data_press);
            this.require_groupBox.Controls.Add(this.label_require_min_data_speed);
            this.require_groupBox.Controls.Add(this.label_require_data_contain);
            this.require_groupBox.Controls.Add(this.label_require_data_float);
            this.require_groupBox.Controls.Add(this.label_require_data_press);
            this.require_groupBox.Controls.Add(this.label_require_data_speed);
            this.require_groupBox.Controls.Add(this.label_require_contain_unit);
            this.require_groupBox.Controls.Add(this.label_require_float_unit);
            this.require_groupBox.Controls.Add(this.label_require_press_unit);
            this.require_groupBox.Controls.Add(this.label_require_speed_unit);
            this.require_groupBox.Controls.Add(this.label_require);
            this.require_groupBox.Location = new System.Drawing.Point(487, 424);
            this.require_groupBox.Name = "require_groupBox";
            this.require_groupBox.Size = new System.Drawing.Size(270, 222);
            this.require_groupBox.TabIndex = 91;
            this.require_groupBox.TabStop = false;
            this.require_groupBox.Text = "测试要求";
            // 
            // label_require_max_data_contain
            // 
            this.label_require_max_data_contain.AutoSize = true;
            this.label_require_max_data_contain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_require_max_data_contain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_require_max_data_contain.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_require_max_data_contain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_require_max_data_contain.Location = new System.Drawing.Point(154, 169);
            this.label_require_max_data_contain.Name = "label_require_max_data_contain";
            this.label_require_max_data_contain.Size = new System.Drawing.Size(18, 18);
            this.label_require_max_data_contain.TabIndex = 125;
            this.label_require_max_data_contain.Text = "0";
            // 
            // label_require_max_data_float
            // 
            this.label_require_max_data_float.AutoSize = true;
            this.label_require_max_data_float.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_require_max_data_float.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_require_max_data_float.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_require_max_data_float.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_require_max_data_float.Location = new System.Drawing.Point(154, 137);
            this.label_require_max_data_float.Name = "label_require_max_data_float";
            this.label_require_max_data_float.Size = new System.Drawing.Size(18, 18);
            this.label_require_max_data_float.TabIndex = 124;
            this.label_require_max_data_float.Text = "0";
            // 
            // label_require_max_data_press
            // 
            this.label_require_max_data_press.AutoSize = true;
            this.label_require_max_data_press.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_require_max_data_press.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_require_max_data_press.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_require_max_data_press.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_require_max_data_press.Location = new System.Drawing.Point(154, 104);
            this.label_require_max_data_press.Name = "label_require_max_data_press";
            this.label_require_max_data_press.Size = new System.Drawing.Size(18, 18);
            this.label_require_max_data_press.TabIndex = 123;
            this.label_require_max_data_press.Text = "0";
            // 
            // label_require_max_data_speed
            // 
            this.label_require_max_data_speed.AutoSize = true;
            this.label_require_max_data_speed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_require_max_data_speed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_require_max_data_speed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_require_max_data_speed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_require_max_data_speed.Location = new System.Drawing.Point(154, 71);
            this.label_require_max_data_speed.Name = "label_require_max_data_speed";
            this.label_require_max_data_speed.Size = new System.Drawing.Size(18, 18);
            this.label_require_max_data_speed.TabIndex = 122;
            this.label_require_max_data_speed.Text = "0";
            // 
            // label_require_min_data_contain
            // 
            this.label_require_min_data_contain.AutoSize = true;
            this.label_require_min_data_contain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_require_min_data_contain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_require_min_data_contain.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_require_min_data_contain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_require_min_data_contain.Location = new System.Drawing.Point(34, 169);
            this.label_require_min_data_contain.Name = "label_require_min_data_contain";
            this.label_require_min_data_contain.Size = new System.Drawing.Size(18, 18);
            this.label_require_min_data_contain.TabIndex = 121;
            this.label_require_min_data_contain.Text = "0";
            // 
            // label_require_min_data_float
            // 
            this.label_require_min_data_float.AutoSize = true;
            this.label_require_min_data_float.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_require_min_data_float.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_require_min_data_float.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_require_min_data_float.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_require_min_data_float.Location = new System.Drawing.Point(34, 137);
            this.label_require_min_data_float.Name = "label_require_min_data_float";
            this.label_require_min_data_float.Size = new System.Drawing.Size(18, 18);
            this.label_require_min_data_float.TabIndex = 120;
            this.label_require_min_data_float.Text = "0";
            // 
            // label_require_min_data_press
            // 
            this.label_require_min_data_press.AutoSize = true;
            this.label_require_min_data_press.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_require_min_data_press.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_require_min_data_press.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_require_min_data_press.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_require_min_data_press.Location = new System.Drawing.Point(34, 104);
            this.label_require_min_data_press.Name = "label_require_min_data_press";
            this.label_require_min_data_press.Size = new System.Drawing.Size(18, 18);
            this.label_require_min_data_press.TabIndex = 119;
            this.label_require_min_data_press.Text = "0";
            // 
            // label_require_min_data_speed
            // 
            this.label_require_min_data_speed.AutoSize = true;
            this.label_require_min_data_speed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_require_min_data_speed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_require_min_data_speed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_require_min_data_speed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_require_min_data_speed.Location = new System.Drawing.Point(34, 71);
            this.label_require_min_data_speed.Name = "label_require_min_data_speed";
            this.label_require_min_data_speed.Size = new System.Drawing.Size(18, 18);
            this.label_require_min_data_speed.TabIndex = 118;
            this.label_require_min_data_speed.Text = "0";
            // 
            // label_require_data_contain
            // 
            this.label_require_data_contain.AutoSize = true;
            this.label_require_data_contain.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_require_data_contain.Location = new System.Drawing.Point(72, 169);
            this.label_require_data_contain.Name = "label_require_data_contain";
            this.label_require_data_contain.Size = new System.Drawing.Size(76, 16);
            this.label_require_data_contain.TabIndex = 117;
            this.label_require_data_contain.Text = "≤容效≤";
            // 
            // label_require_data_float
            // 
            this.label_require_data_float.AutoSize = true;
            this.label_require_data_float.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_require_data_float.Location = new System.Drawing.Point(72, 137);
            this.label_require_data_float.Name = "label_require_data_float";
            this.label_require_data_float.Size = new System.Drawing.Size(76, 16);
            this.label_require_data_float.TabIndex = 116;
            this.label_require_data_float.Text = "≤流量≤";
            // 
            // label_require_data_press
            // 
            this.label_require_data_press.AutoSize = true;
            this.label_require_data_press.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_require_data_press.Location = new System.Drawing.Point(72, 104);
            this.label_require_data_press.Name = "label_require_data_press";
            this.label_require_data_press.Size = new System.Drawing.Size(76, 16);
            this.label_require_data_press.TabIndex = 115;
            this.label_require_data_press.Text = "≤压力≤";
            // 
            // label_require_data_speed
            // 
            this.label_require_data_speed.AutoSize = true;
            this.label_require_data_speed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_require_data_speed.Location = new System.Drawing.Point(72, 71);
            this.label_require_data_speed.Name = "label_require_data_speed";
            this.label_require_data_speed.Size = new System.Drawing.Size(76, 16);
            this.label_require_data_speed.TabIndex = 114;
            this.label_require_data_speed.Text = "≤转速≤";
            // 
            // label_require_contain_unit
            // 
            this.label_require_contain_unit.AutoSize = true;
            this.label_require_contain_unit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_require_contain_unit.Location = new System.Drawing.Point(202, 169);
            this.label_require_contain_unit.Name = "label_require_contain_unit";
            this.label_require_contain_unit.Size = new System.Drawing.Size(17, 16);
            this.label_require_contain_unit.TabIndex = 113;
            this.label_require_contain_unit.Text = "%";
            // 
            // label_require_float_unit
            // 
            this.label_require_float_unit.AutoSize = true;
            this.label_require_float_unit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_require_float_unit.Location = new System.Drawing.Point(202, 137);
            this.label_require_float_unit.Name = "label_require_float_unit";
            this.label_require_float_unit.Size = new System.Drawing.Size(35, 16);
            this.label_require_float_unit.TabIndex = 112;
            this.label_require_float_unit.Text = "L/m";
            // 
            // label_require_press_unit
            // 
            this.label_require_press_unit.AutoSize = true;
            this.label_require_press_unit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_require_press_unit.Location = new System.Drawing.Point(202, 104);
            this.label_require_press_unit.Name = "label_require_press_unit";
            this.label_require_press_unit.Size = new System.Drawing.Size(35, 16);
            this.label_require_press_unit.TabIndex = 111;
            this.label_require_press_unit.Text = "MPa";
            // 
            // label_require_speed_unit
            // 
            this.label_require_speed_unit.AutoSize = true;
            this.label_require_speed_unit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_require_speed_unit.Location = new System.Drawing.Point(202, 71);
            this.label_require_speed_unit.Name = "label_require_speed_unit";
            this.label_require_speed_unit.Size = new System.Drawing.Size(35, 16);
            this.label_require_speed_unit.TabIndex = 110;
            this.label_require_speed_unit.Text = "r/m";
            // 
            // label_require
            // 
            this.label_require.AutoSize = true;
            this.label_require.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_require.ForeColor = System.Drawing.Color.Red;
            this.label_require.Location = new System.Drawing.Point(84, 36);
            this.label_require.Name = "label_require";
            this.label_require.Size = new System.Drawing.Size(89, 19);
            this.label_require.TabIndex = 109;
            this.label_require.Text = "实验要求";
            // 
            // result_groupBox
            // 
            this.result_groupBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.result_groupBox.Controls.Add(this.label16);
            this.result_groupBox.Controls.Add(this.label17);
            this.result_groupBox.Controls.Add(this.label_result_presspower_data);
            this.result_groupBox.Controls.Add(this.label13);
            this.result_groupBox.Controls.Add(this.label_result_power_data);
            this.result_groupBox.Controls.Add(this.label15);
            this.result_groupBox.Controls.Add(this.label10);
            this.result_groupBox.Controls.Add(this.label_result_currentrate_data);
            this.result_groupBox.Controls.Add(this.label12);
            this.result_groupBox.Controls.Add(this.label7);
            this.result_groupBox.Controls.Add(this.label_result_keepvola_data);
            this.result_groupBox.Controls.Add(this.label9);
            this.result_groupBox.Controls.Add(this.label4);
            this.result_groupBox.Controls.Add(this.label_result_maidongpress_data);
            this.result_groupBox.Controls.Add(this.label6);
            this.result_groupBox.Controls.Add(this.label_result_contain_unit);
            this.result_groupBox.Controls.Add(this.label_result_contain_data);
            this.result_groupBox.Controls.Add(this.label_result_contain);
            this.result_groupBox.Controls.Add(this.label_result_float_unit);
            this.result_groupBox.Controls.Add(this.label_result_float_data);
            this.result_groupBox.Controls.Add(this.label_result_float);
            this.result_groupBox.Controls.Add(this.label_result_press_unit);
            this.result_groupBox.Controls.Add(this.label_result_press_data);
            this.result_groupBox.Controls.Add(this.label_result_press);
            this.result_groupBox.Controls.Add(this.label_result_speed_unit);
            this.result_groupBox.Controls.Add(this.label_result_speed_data);
            this.result_groupBox.Controls.Add(this.label_result_speed);
            this.result_groupBox.Location = new System.Drawing.Point(763, 27);
            this.result_groupBox.Name = "result_groupBox";
            this.result_groupBox.Size = new System.Drawing.Size(251, 391);
            this.result_groupBox.TabIndex = 92;
            this.result_groupBox.TabStop = false;
            this.result_groupBox.Text = "测试结果";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(188, 297);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 16);
            this.label16.TabIndex = 125;
            this.label16.Text = "%";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(128, 295);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 18);
            this.label17.TabIndex = 124;
            this.label17.Text = "0";
            // 
            // label_result_presspower_data
            // 
            this.label_result_presspower_data.AutoSize = true;
            this.label_result_presspower_data.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_result_presspower_data.Location = new System.Drawing.Point(28, 297);
            this.label_result_presspower_data.Name = "label_result_presspower_data";
            this.label_result_presspower_data.Size = new System.Drawing.Size(76, 16);
            this.label_result_presspower_data.TabIndex = 123;
            this.label_result_presspower_data.Text = "压力功率";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(188, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 16);
            this.label13.TabIndex = 122;
            this.label13.Text = "%";
            // 
            // label_result_power_data
            // 
            this.label_result_power_data.AutoSize = true;
            this.label_result_power_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_result_power_data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_result_power_data.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_result_power_data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_result_power_data.Location = new System.Drawing.Point(128, 264);
            this.label_result_power_data.Name = "label_result_power_data";
            this.label_result_power_data.Size = new System.Drawing.Size(18, 18);
            this.label_result_power_data.TabIndex = 121;
            this.label_result_power_data.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(28, 266);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 16);
            this.label15.TabIndex = 120;
            this.label15.Text = "功率";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(188, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 16);
            this.label10.TabIndex = 119;
            this.label10.Text = "%";
            // 
            // label_result_currentrate_data
            // 
            this.label_result_currentrate_data.AutoSize = true;
            this.label_result_currentrate_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_result_currentrate_data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_result_currentrate_data.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_result_currentrate_data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_result_currentrate_data.Location = new System.Drawing.Point(128, 230);
            this.label_result_currentrate_data.Name = "label_result_currentrate_data";
            this.label_result_currentrate_data.Size = new System.Drawing.Size(18, 18);
            this.label_result_currentrate_data.TabIndex = 118;
            this.label_result_currentrate_data.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(28, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 16);
            this.label12.TabIndex = 117;
            this.label12.Text = "电流比";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(188, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 16);
            this.label7.TabIndex = 116;
            this.label7.Text = "%";
            // 
            // label_result_keepvola_data
            // 
            this.label_result_keepvola_data.AutoSize = true;
            this.label_result_keepvola_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_result_keepvola_data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_result_keepvola_data.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_result_keepvola_data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_result_keepvola_data.Location = new System.Drawing.Point(128, 197);
            this.label_result_keepvola_data.Name = "label_result_keepvola_data";
            this.label_result_keepvola_data.Size = new System.Drawing.Size(18, 18);
            this.label_result_keepvola_data.TabIndex = 115;
            this.label_result_keepvola_data.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(28, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 114;
            this.label9.Text = "保压电流";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(188, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 113;
            this.label4.Text = "%";
            // 
            // label_result_maidongpress_data
            // 
            this.label_result_maidongpress_data.AutoSize = true;
            this.label_result_maidongpress_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_result_maidongpress_data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_result_maidongpress_data.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_result_maidongpress_data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_result_maidongpress_data.Location = new System.Drawing.Point(128, 166);
            this.label_result_maidongpress_data.Name = "label_result_maidongpress_data";
            this.label_result_maidongpress_data.Size = new System.Drawing.Size(18, 18);
            this.label_result_maidongpress_data.TabIndex = 112;
            this.label_result_maidongpress_data.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(28, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 111;
            this.label6.Text = "压力脉动";
            // 
            // label_result_contain_unit
            // 
            this.label_result_contain_unit.AutoSize = true;
            this.label_result_contain_unit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_result_contain_unit.Location = new System.Drawing.Point(188, 137);
            this.label_result_contain_unit.Name = "label_result_contain_unit";
            this.label_result_contain_unit.Size = new System.Drawing.Size(17, 16);
            this.label_result_contain_unit.TabIndex = 110;
            this.label_result_contain_unit.Text = "%";
            // 
            // label_result_contain_data
            // 
            this.label_result_contain_data.AutoSize = true;
            this.label_result_contain_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_result_contain_data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_result_contain_data.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_result_contain_data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_result_contain_data.Location = new System.Drawing.Point(128, 135);
            this.label_result_contain_data.Name = "label_result_contain_data";
            this.label_result_contain_data.Size = new System.Drawing.Size(18, 18);
            this.label_result_contain_data.TabIndex = 109;
            this.label_result_contain_data.Text = "0";
            // 
            // label_result_contain
            // 
            this.label_result_contain.AutoSize = true;
            this.label_result_contain.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_result_contain.Location = new System.Drawing.Point(28, 137);
            this.label_result_contain.Name = "label_result_contain";
            this.label_result_contain.Size = new System.Drawing.Size(42, 16);
            this.label_result_contain.TabIndex = 108;
            this.label_result_contain.Text = "容效";
            // 
            // label_result_float_unit
            // 
            this.label_result_float_unit.AutoSize = true;
            this.label_result_float_unit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_result_float_unit.Location = new System.Drawing.Point(188, 105);
            this.label_result_float_unit.Name = "label_result_float_unit";
            this.label_result_float_unit.Size = new System.Drawing.Size(35, 16);
            this.label_result_float_unit.TabIndex = 107;
            this.label_result_float_unit.Text = "L/m";
            // 
            // label_result_float_data
            // 
            this.label_result_float_data.AutoSize = true;
            this.label_result_float_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_result_float_data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_result_float_data.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_result_float_data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_result_float_data.Location = new System.Drawing.Point(128, 103);
            this.label_result_float_data.Name = "label_result_float_data";
            this.label_result_float_data.Size = new System.Drawing.Size(18, 18);
            this.label_result_float_data.TabIndex = 106;
            this.label_result_float_data.Text = "0";
            // 
            // label_result_float
            // 
            this.label_result_float.AutoSize = true;
            this.label_result_float.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_result_float.Location = new System.Drawing.Point(28, 105);
            this.label_result_float.Name = "label_result_float";
            this.label_result_float.Size = new System.Drawing.Size(42, 16);
            this.label_result_float.TabIndex = 105;
            this.label_result_float.Text = "流量";
            // 
            // label_result_press_unit
            // 
            this.label_result_press_unit.AutoSize = true;
            this.label_result_press_unit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_result_press_unit.Location = new System.Drawing.Point(188, 72);
            this.label_result_press_unit.Name = "label_result_press_unit";
            this.label_result_press_unit.Size = new System.Drawing.Size(35, 16);
            this.label_result_press_unit.TabIndex = 104;
            this.label_result_press_unit.Text = "MPa";
            // 
            // label_result_press_data
            // 
            this.label_result_press_data.AutoSize = true;
            this.label_result_press_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_result_press_data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_result_press_data.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_result_press_data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_result_press_data.Location = new System.Drawing.Point(128, 70);
            this.label_result_press_data.Name = "label_result_press_data";
            this.label_result_press_data.Size = new System.Drawing.Size(18, 18);
            this.label_result_press_data.TabIndex = 103;
            this.label_result_press_data.Text = "0";
            // 
            // label_result_press
            // 
            this.label_result_press.AutoSize = true;
            this.label_result_press.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_result_press.Location = new System.Drawing.Point(28, 72);
            this.label_result_press.Name = "label_result_press";
            this.label_result_press.Size = new System.Drawing.Size(42, 16);
            this.label_result_press.TabIndex = 102;
            this.label_result_press.Text = "压力";
            // 
            // label_result_speed_unit
            // 
            this.label_result_speed_unit.AutoSize = true;
            this.label_result_speed_unit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_result_speed_unit.Location = new System.Drawing.Point(188, 39);
            this.label_result_speed_unit.Name = "label_result_speed_unit";
            this.label_result_speed_unit.Size = new System.Drawing.Size(35, 16);
            this.label_result_speed_unit.TabIndex = 101;
            this.label_result_speed_unit.Text = "r/m";
            // 
            // label_result_speed_data
            // 
            this.label_result_speed_data.AutoSize = true;
            this.label_result_speed_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_result_speed_data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_result_speed_data.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_result_speed_data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_result_speed_data.Location = new System.Drawing.Point(128, 37);
            this.label_result_speed_data.Name = "label_result_speed_data";
            this.label_result_speed_data.Size = new System.Drawing.Size(18, 18);
            this.label_result_speed_data.TabIndex = 100;
            this.label_result_speed_data.Text = "0";
            // 
            // label_result_speed
            // 
            this.label_result_speed.AutoSize = true;
            this.label_result_speed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_result_speed.Location = new System.Drawing.Point(28, 39);
            this.label_result_speed.Name = "label_result_speed";
            this.label_result_speed.Size = new System.Drawing.Size(42, 16);
            this.label_result_speed.TabIndex = 99;
            this.label_result_speed.Text = "转速";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Controls.Add(this.moto_speedlabel);
            this.groupBox2.Controls.Add(this.motoStopbutton);
            this.groupBox2.Controls.Add(this.motoStartbutton);
            this.groupBox2.Location = new System.Drawing.Point(763, 436);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 200);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // moto_speedlabel
            // 
            this.moto_speedlabel.AutoSize = true;
            this.moto_speedlabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.moto_speedlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.moto_speedlabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.moto_speedlabel.Location = new System.Drawing.Point(30, 90);
            this.moto_speedlabel.Name = "moto_speedlabel";
            this.moto_speedlabel.Size = new System.Drawing.Size(112, 18);
            this.moto_speedlabel.TabIndex = 89;
            this.moto_speedlabel.Text = "电机转速设定";
            // 
            // motoStopbutton
            // 
            this.motoStopbutton.Location = new System.Drawing.Point(152, 35);
            this.motoStopbutton.Name = "motoStopbutton";
            this.motoStopbutton.Size = new System.Drawing.Size(71, 32);
            this.motoStopbutton.TabIndex = 88;
            this.motoStopbutton.Text = "电机停止";
            this.motoStopbutton.UseVisualStyleBackColor = true;
            this.motoStopbutton.Click += new System.EventHandler(this.motoStopbutton_Click);
            // 
            // motoStartbutton
            // 
            this.motoStartbutton.Location = new System.Drawing.Point(30, 35);
            this.motoStartbutton.Name = "motoStartbutton";
            this.motoStartbutton.Size = new System.Drawing.Size(71, 32);
            this.motoStartbutton.TabIndex = 86;
            this.motoStartbutton.Text = "电机启动";
            this.motoStartbutton.UseVisualStyleBackColor = true;
            this.motoStartbutton.Click += new System.EventHandler(this.motoStartbutton_Click);
            // 
            // formmainprogramBindingSource
            // 
            this.formmainprogramBindingSource.DataSource = typeof(monitor.form_main_program);
            // 
            // form_main_program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1273, 642);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.result_groupBox);
            this.Controls.Add(this.require_groupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.alarm_groupBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_main_program";
            this.Text = "液压监测";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_main_program_FormClosing);
            this.Load += new System.EventHandler(this.form_main_program_Load);
            ((System.ComponentModel.ISupportInitialize)(this.led1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thermometer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.MotogroupBox.ResumeLayout(false);
            this.MotogroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moto_press_meter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moto_current_meter)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flow_gauge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.press_gauge)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomStateStackBindingSource)).EndInit();
            this.alarm_groupBox.ResumeLayout(false);
            this.alarm_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.led6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.require_groupBox.ResumeLayout(false);
            this.require_groupBox.PerformLayout();
            this.result_groupBox.ResumeLayout(false);
            this.result_groupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formmainprogramBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.BindingSource zoomStateStackBindingSource;
        public System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Panel panel3;
        private ZedGraph.ZedGraphControl ZedGraph;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.BindingSource formmainprogramBindingSource;
        private System.Windows.Forms.Label label_press;
        private System.Windows.Forms.Label label_press_unit;
        private System.Windows.Forms.Label label_press_data;
        private System.Windows.Forms.Label label_float_unit;
        private System.Windows.Forms.Label label_float_data;
        private System.Windows.Forms.Label label_float;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label_time_unit;
        private System.Windows.Forms.Label label_time;
        private NationalInstruments.UI.WindowsForms.Led led1;
        private NationalInstruments.UI.WindowsForms.Thermometer thermometer;
        private NationalInstruments.UI.WindowsForms.Gauge press_gauge;
        private NationalInstruments.UI.WindowsForms.Gauge flow_gauge;
        private NationalInstruments.UI.WindowsForms.Led led2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TestToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem ParaSetToolStripMenuItem;
        private System.Windows.Forms.GroupBox alarm_groupBox;
        private System.IO.Ports.SerialPort moto_serialPort;
        private System.Windows.Forms.GroupBox MotogroupBox;
        private System.Windows.Forms.Label speed_label;
        private System.Windows.Forms.Label power_label;
        private System.Windows.Forms.Label current_label;
        private NationalInstruments.UI.WindowsForms.Meter moto_press_meter;
        private NationalInstruments.UI.WindowsForms.Meter moto_current_meter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tempertature_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox require_groupBox;
        private System.Windows.Forms.Label label_require_max_data_contain;
        private System.Windows.Forms.Label label_require_max_data_float;
        private System.Windows.Forms.Label label_require_max_data_press;
        private System.Windows.Forms.Label label_require_max_data_speed;
        private System.Windows.Forms.Label label_require_min_data_contain;
        private System.Windows.Forms.Label label_require_min_data_float;
        private System.Windows.Forms.Label label_require_min_data_press;
        private System.Windows.Forms.Label label_require_min_data_speed;
        private System.Windows.Forms.Label label_require_data_contain;
        private System.Windows.Forms.Label label_require_data_float;
        private System.Windows.Forms.Label label_require_data_press;
        private System.Windows.Forms.Label label_require_data_speed;
        private System.Windows.Forms.Label label_require_contain_unit;
        private System.Windows.Forms.Label label_require_float_unit;
        private System.Windows.Forms.Label label_require_press_unit;
        private System.Windows.Forms.Label label_require_speed_unit;
        private System.Windows.Forms.Label label_require;
        private System.Windows.Forms.GroupBox result_groupBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label_result_presspower_data;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_result_power_data;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_result_currentrate_data;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_result_keepvola_data;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_result_maidongpress_data;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_result_contain_unit;
        private System.Windows.Forms.Label label_result_contain_data;
        private System.Windows.Forms.Label label_result_contain;
        private System.Windows.Forms.Label label_result_float_unit;
        private System.Windows.Forms.Label label_result_float_data;
        private System.Windows.Forms.Label label_result_float;
        private System.Windows.Forms.Label label_result_press_unit;
        private System.Windows.Forms.Label label_result_press_data;
        private System.Windows.Forms.Label label_result_press;
        private System.Windows.Forms.Label label_result_speed_unit;
        private System.Windows.Forms.Label label_result_speed_data;
        private System.Windows.Forms.Label label_result_speed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label moto_speed_label;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label moto_current_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label moto_power_label;
        private System.Windows.Forms.Label label8;
        private NationalInstruments.UI.WindowsForms.Led led6;
        private NationalInstruments.UI.WindowsForms.Led led5;
        private NationalInstruments.UI.WindowsForms.Led led4;
        private NationalInstruments.UI.WindowsForms.Led led3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button motoStopbutton;
        private System.Windows.Forms.Button motoStartbutton;
        private System.Windows.Forms.Label moto_speedlabel;
        private System.Windows.Forms.Button startruningbutton;

    }
}

