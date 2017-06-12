namespace monitor
{
    partial class ParameSetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contain_max_textBox = new System.Windows.Forms.TextBox();
            this.contain_min_textBox = new System.Windows.Forms.TextBox();
            this.flow_max_textBox = new System.Windows.Forms.TextBox();
            this.flow_min_textBox = new System.Windows.Forms.TextBox();
            this.press_max_textBox = new System.Windows.Forms.TextBox();
            this.press_min_textBox = new System.Windows.Forms.TextBox();
            this.speed_max_textBox = new System.Windows.Forms.TextBox();
            this.speed_min_textBox = new System.Windows.Forms.TextBox();
            this.contain_label = new System.Windows.Forms.Label();
            this.flow_label = new System.Windows.Forms.Label();
            this.press_label = new System.Windows.Forms.Label();
            this.speed_label = new System.Windows.Forms.Label();
            this.MAX_label = new System.Windows.Forms.Label();
            this.MINlabel = new System.Windows.Forms.Label();
            this.serial_label = new System.Windows.Forms.Label();
            this.SerialPortcomboBox = new System.Windows.Forms.ComboBox();
            this.start_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.moto_serial_label = new System.Windows.Forms.Label();
            this.MotoSerialPortcomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.physicalChannelComboBox = new System.Windows.Forms.ComboBox();
            this.physicalChannelLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contain_max_textBox);
            this.groupBox1.Controls.Add(this.contain_min_textBox);
            this.groupBox1.Controls.Add(this.flow_max_textBox);
            this.groupBox1.Controls.Add(this.flow_min_textBox);
            this.groupBox1.Controls.Add(this.press_max_textBox);
            this.groupBox1.Controls.Add(this.press_min_textBox);
            this.groupBox1.Controls.Add(this.speed_max_textBox);
            this.groupBox1.Controls.Add(this.speed_min_textBox);
            this.groupBox1.Controls.Add(this.contain_label);
            this.groupBox1.Controls.Add(this.flow_label);
            this.groupBox1.Controls.Add(this.press_label);
            this.groupBox1.Controls.Add(this.speed_label);
            this.groupBox1.Controls.Add(this.MAX_label);
            this.groupBox1.Controls.Add(this.MINlabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "实验参数范围设定";
            // 
            // contain_max_textBox
            // 
            this.contain_max_textBox.Location = new System.Drawing.Point(142, 176);
            this.contain_max_textBox.Name = "contain_max_textBox";
            this.contain_max_textBox.Size = new System.Drawing.Size(69, 21);
            this.contain_max_textBox.TabIndex = 13;
            this.contain_max_textBox.Text = "0";
            // 
            // contain_min_textBox
            // 
            this.contain_min_textBox.Location = new System.Drawing.Point(53, 176);
            this.contain_min_textBox.Name = "contain_min_textBox";
            this.contain_min_textBox.Size = new System.Drawing.Size(69, 21);
            this.contain_min_textBox.TabIndex = 12;
            this.contain_min_textBox.Text = "0";
            // 
            // flow_max_textBox
            // 
            this.flow_max_textBox.Location = new System.Drawing.Point(142, 139);
            this.flow_max_textBox.Name = "flow_max_textBox";
            this.flow_max_textBox.Size = new System.Drawing.Size(69, 21);
            this.flow_max_textBox.TabIndex = 11;
            this.flow_max_textBox.Text = "0";
            // 
            // flow_min_textBox
            // 
            this.flow_min_textBox.Location = new System.Drawing.Point(53, 139);
            this.flow_min_textBox.Name = "flow_min_textBox";
            this.flow_min_textBox.Size = new System.Drawing.Size(69, 21);
            this.flow_min_textBox.TabIndex = 10;
            this.flow_min_textBox.Text = "0";
            // 
            // press_max_textBox
            // 
            this.press_max_textBox.Location = new System.Drawing.Point(142, 102);
            this.press_max_textBox.Name = "press_max_textBox";
            this.press_max_textBox.Size = new System.Drawing.Size(69, 21);
            this.press_max_textBox.TabIndex = 9;
            this.press_max_textBox.Text = "0";
            // 
            // press_min_textBox
            // 
            this.press_min_textBox.Location = new System.Drawing.Point(53, 102);
            this.press_min_textBox.Name = "press_min_textBox";
            this.press_min_textBox.Size = new System.Drawing.Size(69, 21);
            this.press_min_textBox.TabIndex = 8;
            this.press_min_textBox.Text = "0";
            // 
            // speed_max_textBox
            // 
            this.speed_max_textBox.Location = new System.Drawing.Point(142, 63);
            this.speed_max_textBox.Name = "speed_max_textBox";
            this.speed_max_textBox.Size = new System.Drawing.Size(69, 21);
            this.speed_max_textBox.TabIndex = 7;
            this.speed_max_textBox.Text = "0";
            // 
            // speed_min_textBox
            // 
            this.speed_min_textBox.Location = new System.Drawing.Point(53, 63);
            this.speed_min_textBox.Name = "speed_min_textBox";
            this.speed_min_textBox.Size = new System.Drawing.Size(69, 21);
            this.speed_min_textBox.TabIndex = 6;
            this.speed_min_textBox.Text = "0";
            // 
            // contain_label
            // 
            this.contain_label.AutoSize = true;
            this.contain_label.Location = new System.Drawing.Point(6, 179);
            this.contain_label.Name = "contain_label";
            this.contain_label.Size = new System.Drawing.Size(41, 12);
            this.contain_label.TabIndex = 5;
            this.contain_label.Text = "容效：";
            // 
            // flow_label
            // 
            this.flow_label.AutoSize = true;
            this.flow_label.Location = new System.Drawing.Point(6, 142);
            this.flow_label.Name = "flow_label";
            this.flow_label.Size = new System.Drawing.Size(41, 12);
            this.flow_label.TabIndex = 4;
            this.flow_label.Text = "流量：";
            // 
            // press_label
            // 
            this.press_label.AutoSize = true;
            this.press_label.Location = new System.Drawing.Point(6, 105);
            this.press_label.Name = "press_label";
            this.press_label.Size = new System.Drawing.Size(41, 12);
            this.press_label.TabIndex = 3;
            this.press_label.Text = "压力：";
            // 
            // speed_label
            // 
            this.speed_label.AutoSize = true;
            this.speed_label.Location = new System.Drawing.Point(6, 66);
            this.speed_label.Name = "speed_label";
            this.speed_label.Size = new System.Drawing.Size(41, 12);
            this.speed_label.TabIndex = 2;
            this.speed_label.Text = "转速：";
            // 
            // MAX_label
            // 
            this.MAX_label.AutoSize = true;
            this.MAX_label.Location = new System.Drawing.Point(160, 36);
            this.MAX_label.Name = "MAX_label";
            this.MAX_label.Size = new System.Drawing.Size(41, 12);
            this.MAX_label.TabIndex = 1;
            this.MAX_label.Text = "最大值";
            // 
            // MINlabel
            // 
            this.MINlabel.AutoSize = true;
            this.MINlabel.Location = new System.Drawing.Point(68, 36);
            this.MINlabel.Name = "MINlabel";
            this.MINlabel.Size = new System.Drawing.Size(41, 12);
            this.MINlabel.TabIndex = 0;
            this.MINlabel.Text = "最小值";
            // 
            // serial_label
            // 
            this.serial_label.AutoSize = true;
            this.serial_label.Location = new System.Drawing.Point(13, 30);
            this.serial_label.Name = "serial_label";
            this.serial_label.Size = new System.Drawing.Size(41, 12);
            this.serial_label.TabIndex = 14;
            this.serial_label.Text = "串口：";
            // 
            // SerialPortcomboBox
            // 
            this.SerialPortcomboBox.FormattingEnabled = true;
            this.SerialPortcomboBox.Location = new System.Drawing.Point(98, 22);
            this.SerialPortcomboBox.Name = "SerialPortcomboBox";
            this.SerialPortcomboBox.Size = new System.Drawing.Size(110, 20);
            this.SerialPortcomboBox.TabIndex = 3;
            this.SerialPortcomboBox.Text = "COM1";
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(15, 350);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "确认";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(138, 350);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "取消";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // moto_serial_label
            // 
            this.moto_serial_label.AutoSize = true;
            this.moto_serial_label.Location = new System.Drawing.Point(13, 58);
            this.moto_serial_label.Name = "moto_serial_label";
            this.moto_serial_label.Size = new System.Drawing.Size(65, 12);
            this.moto_serial_label.TabIndex = 15;
            this.moto_serial_label.Text = "电机串口：";
            // 
            // MotoSerialPortcomboBox
            // 
            this.MotoSerialPortcomboBox.FormattingEnabled = true;
            this.MotoSerialPortcomboBox.Location = new System.Drawing.Point(98, 50);
            this.MotoSerialPortcomboBox.Name = "MotoSerialPortcomboBox";
            this.MotoSerialPortcomboBox.Size = new System.Drawing.Size(110, 20);
            this.MotoSerialPortcomboBox.TabIndex = 16;
            this.MotoSerialPortcomboBox.Text = "COM1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.physicalChannelComboBox);
            this.groupBox2.Controls.Add(this.physicalChannelLabel);
            this.groupBox2.Controls.Add(this.MotoSerialPortcomboBox);
            this.groupBox2.Controls.Add(this.SerialPortcomboBox);
            this.groupBox2.Controls.Add(this.moto_serial_label);
            this.groupBox2.Controls.Add(this.serial_label);
            this.groupBox2.Location = new System.Drawing.Point(12, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 112);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "通信设置";
            // 
            // physicalChannelComboBox
            // 
            this.physicalChannelComboBox.Location = new System.Drawing.Point(98, 83);
            this.physicalChannelComboBox.Name = "physicalChannelComboBox";
            this.physicalChannelComboBox.Size = new System.Drawing.Size(110, 20);
            this.physicalChannelComboBox.TabIndex = 18;
            // 
            // physicalChannelLabel
            // 
            this.physicalChannelLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.physicalChannelLabel.Location = new System.Drawing.Point(13, 86);
            this.physicalChannelLabel.Name = "physicalChannelLabel";
            this.physicalChannelLabel.Size = new System.Drawing.Size(82, 23);
            this.physicalChannelLabel.TabIndex = 17;
            this.physicalChannelLabel.Text = "NI物理通道:";
            // 
            // ParameSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 379);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.groupBox1);
            this.Name = "ParameSetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ParameSetForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label MINlabel;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label contain_label;
        private System.Windows.Forms.Label flow_label;
        private System.Windows.Forms.Label press_label;
        private System.Windows.Forms.Label speed_label;
        private System.Windows.Forms.Label MAX_label;
        private System.Windows.Forms.TextBox contain_max_textBox;
        private System.Windows.Forms.TextBox contain_min_textBox;
        private System.Windows.Forms.TextBox flow_max_textBox;
        private System.Windows.Forms.TextBox flow_min_textBox;
        private System.Windows.Forms.TextBox press_max_textBox;
        private System.Windows.Forms.TextBox press_min_textBox;
        private System.Windows.Forms.TextBox speed_max_textBox;
        private System.Windows.Forms.TextBox speed_min_textBox;
        private System.Windows.Forms.Label serial_label;
        private System.Windows.Forms.ComboBox SerialPortcomboBox;
        private System.Windows.Forms.ComboBox MotoSerialPortcomboBox;
        private System.Windows.Forms.Label moto_serial_label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox physicalChannelComboBox;
        private System.Windows.Forms.Label physicalChannelLabel;
    }
}