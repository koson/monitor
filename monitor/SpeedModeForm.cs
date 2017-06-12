using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monitor
{
    public partial class SpeedModeForm : Form
    {
        private int speed;
        private int mload;
        private int frequency;
        private int settime;
        private string mode_name = "恒速模式";
        public SpeedModeForm()
        {
            InitializeComponent();
            
        }
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        public int MLoad
        {
            get
            {
                return mload;
            }
            set
            {
                mload = value;
            }
        }
        public int Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                frequency = value;
            }
        }
        public int Settime
        {
            get
            {
                return settime;
            }
            set
            {
                settime = value;
            }
        }
        public string Mode_name
        {
            get
            {
                return mode_name;
            }
        }

        private void button_mode1_start_Click(object sender, EventArgs e)
        {
            /* 1、串口是否打开，如果没有打开串口
             * 2、发送下位机指令信息。
             * 3、关闭指令设置窗口。
            */
            try
            {
                speed = Convert.ToInt16(textBox_mode1_speed.Text);
                mload = Convert.ToInt16(textBox_mode1_load.Text);
                frequency = Convert.ToInt16(textBox_mode1_frequency.Text);
                settime = Convert.ToInt16(textBox_mode1_time.Text);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error_mode1:" + ex.Message, "Error");
                return;
            }
        }
    }
}
