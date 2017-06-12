namespace monitor
{
    partial class TestModeForm
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.button_mode2_start = new System.Windows.Forms.Button();
            this.textBox_mode2_press = new System.Windows.Forms.TextBox();
            this.label_mode2_press = new System.Windows.Forms.Label();
            this.textBox_mode2_speed = new System.Windows.Forms.TextBox();
            this.label_mode2_speed = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Font = new System.Drawing.Font("宋体", 9F);
            this.cancel_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancel_button.Location = new System.Drawing.Point(12, 163);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 9;
            this.cancel_button.Text = "取消";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // button_mode2_start
            // 
            this.button_mode2_start.Font = new System.Drawing.Font("宋体", 9F);
            this.button_mode2_start.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_mode2_start.Location = new System.Drawing.Point(137, 163);
            this.button_mode2_start.Name = "button_mode2_start";
            this.button_mode2_start.Size = new System.Drawing.Size(75, 23);
            this.button_mode2_start.TabIndex = 8;
            this.button_mode2_start.Text = "开始";
            this.button_mode2_start.UseVisualStyleBackColor = true;
            this.button_mode2_start.Click += new System.EventHandler(this.button_mode2_start_Click);
            // 
            // textBox_mode2_press
            // 
            this.textBox_mode2_press.Location = new System.Drawing.Point(99, 100);
            this.textBox_mode2_press.Name = "textBox_mode2_press";
            this.textBox_mode2_press.Size = new System.Drawing.Size(77, 21);
            this.textBox_mode2_press.TabIndex = 3;
            this.textBox_mode2_press.Text = "0";
            // 
            // label_mode2_press
            // 
            this.label_mode2_press.AutoSize = true;
            this.label_mode2_press.Font = new System.Drawing.Font("宋体", 9F);
            this.label_mode2_press.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_mode2_press.Location = new System.Drawing.Point(18, 103);
            this.label_mode2_press.Name = "label_mode2_press";
            this.label_mode2_press.Size = new System.Drawing.Size(65, 12);
            this.label_mode2_press.TabIndex = 2;
            this.label_mode2_press.Text = "额定压力：";
            // 
            // textBox_mode2_speed
            // 
            this.textBox_mode2_speed.Location = new System.Drawing.Point(99, 56);
            this.textBox_mode2_speed.Name = "textBox_mode2_speed";
            this.textBox_mode2_speed.Size = new System.Drawing.Size(77, 21);
            this.textBox_mode2_speed.TabIndex = 1;
            this.textBox_mode2_speed.Text = "0";
            // 
            // label_mode2_speed
            // 
            this.label_mode2_speed.AutoSize = true;
            this.label_mode2_speed.Font = new System.Drawing.Font("宋体", 9F);
            this.label_mode2_speed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_mode2_speed.Location = new System.Drawing.Point(18, 59);
            this.label_mode2_speed.Name = "label_mode2_speed";
            this.label_mode2_speed.Size = new System.Drawing.Size(65, 12);
            this.label_mode2_speed.TabIndex = 0;
            this.label_mode2_speed.Text = "额定转速：";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label_mode2_speed);
            this.groupBox.Controls.Add(this.textBox_mode2_speed);
            this.groupBox.Controls.Add(this.textBox_mode2_press);
            this.groupBox.Controls.Add(this.label_mode2_press);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 134);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "出厂试验参数设定";
            // 
            // TestModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 196);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.button_mode2_start);
            this.Controls.Add(this.groupBox);
            this.Name = "TestModeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "参数设置";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_mode2_start;
        public System.Windows.Forms.TextBox textBox_mode2_press;
        private System.Windows.Forms.Label label_mode2_press;
        private System.Windows.Forms.Label label_mode2_speed;
        public System.Windows.Forms.TextBox textBox_mode2_speed;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.GroupBox groupBox;
    }
}