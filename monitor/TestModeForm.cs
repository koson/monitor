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
    public partial class TestModeForm : Form
    {
        private int speed;
        private int press;
        private string mode_name = "出厂试验";
             
        public TestModeForm()
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
        public int Press
        {
            get
            {
                return press;
            }
            set
            {
                press = value;
            }
        }
        public string Mode_name
        {
            get
            {
                return mode_name;
            }
        }
        private void button_mode2_start_Click(object sender, EventArgs e)
        {
            try
            {
                speed = Convert.ToInt16(textBox_mode2_speed.Text);
                press = Convert.ToInt16(textBox_mode2_press.Text);
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
