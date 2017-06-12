using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using NationalInstruments.DAQmx;

namespace monitor
{
    public partial class ParameSetForm : Form
    {
        public const int MaxNUN = 8;
        private int limit_speed_min;
        private int limit_speed_max;
        private int limit_press_min;
        private int limit_press_max;
        private int limit_flow_min;
        private int limit_flow_max;
        private int limit_contain_min;
        private int limit_contain_max;
        private string serial_name;
        private string moto_serial_name;
        private string physicalChannel;

        public int Limit_Speed_Min
        {
            get
            {
                return limit_speed_min;
            }
            set
            {
                limit_speed_min = value;
            }
        }
        public int Limit_Speed_Max
        {
            get
            {
                return limit_speed_max;
            }
            set
            {
                limit_speed_max = value;
            }
        }
        public int Limit_Press_Min
        {
            get
            {
                return limit_press_min;
            }
            set
            {
                limit_press_min = value;
            }
        }
        public int Limit_Press_Max
        {
            get
            {
                return limit_press_max;
            }
            set
            {
                limit_press_max = value;
            }
        }
        public int Limit_Flow_Min
        {
            get
            {
                return limit_flow_min;
            }
            set
            {
                limit_flow_min = value;
            }
        }
        public int Limit_Flow_Max
        {
            get
            {
                return limit_flow_max;
            }
            set
            {
                limit_flow_max = value;
            }
        }
        public int Limit_Contain_Min
        {
            get
            {
                return limit_contain_min;
            }
            set
            {
                limit_contain_min = value;
            }
        }
        public int Limit_Contain_Max
        {
            get
            {
                return limit_contain_max;
            }
            set
            {
                limit_contain_max = value;
            }
        }
        public string Seria_Name
        {
            get
            {
                return serial_name;
            }
            set
            {
                serial_name = value;
            }
        }
        public string Moto_Seria_Name
        {
            get
            {
                return moto_serial_name;
            }
            set
            {
                moto_serial_name = value;
            }
        }
        public string PhysicalChannel
        {
            get
            {
                return physicalChannel;
            }
            set
            {
                physicalChannel = value;
            }
        }

        public ParameSetForm()
        {
            InitializeComponent();
            physicalChannelComboBox.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AI, PhysicalChannelAccess.External));
            SerialPortcomboBox.Items.AddRange(SerialPort.GetPortNames());
            MotoSerialPortcomboBox.Items.AddRange(SerialPort.GetPortNames());
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            try
            {
                limit_speed_min = Convert.ToInt16(speed_min_textBox.Text);
                limit_speed_max = Convert.ToInt16(speed_max_textBox.Text);
                limit_press_min = Convert.ToInt16(press_min_textBox.Text);
                limit_press_max = Convert.ToInt16(press_max_textBox.Text);
                limit_flow_min = Convert.ToInt16(flow_min_textBox.Text);
                limit_flow_max = Convert.ToInt16(flow_max_textBox.Text);
                limit_contain_min = Convert.ToInt16(contain_min_textBox.Text);
                limit_contain_max = Convert.ToInt16(contain_max_textBox.Text);
                serial_name = SerialPortcomboBox.Text;
                moto_serial_name = MotoSerialPortcomboBox.Text;
                physicalChannel = physicalChannelComboBox.Text;

                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error1:" + ex.Message, "Error");
            }
        }
    }
}
