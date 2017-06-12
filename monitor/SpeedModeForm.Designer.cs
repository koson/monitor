namespace monitor
{
    partial class SpeedModeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpeedModeForm));
            this.cancel_button = new System.Windows.Forms.Button();
            this.button_mode1_start = new System.Windows.Forms.Button();
            this.textBox_mode1_time = new System.Windows.Forms.TextBox();
            this.label_mode1_time = new System.Windows.Forms.Label();
            this.textBox_mode1_load = new System.Windows.Forms.TextBox();
            this.label_mode1_load = new System.Windows.Forms.Label();
            this.textBox_mode1_frequency = new System.Windows.Forms.TextBox();
            this.label_mode1_frequency = new System.Windows.Forms.Label();
            this.textBox_mode1_speed = new System.Windows.Forms.TextBox();
            this.label_mode1_speed = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.cancel_button, "cancel_button");
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // button_mode1_start
            // 
            resources.ApplyResources(this.button_mode1_start, "button_mode1_start");
            this.button_mode1_start.Name = "button_mode1_start";
            this.button_mode1_start.UseVisualStyleBackColor = true;
            this.button_mode1_start.Click += new System.EventHandler(this.button_mode1_start_Click);
            // 
            // textBox_mode1_time
            // 
            resources.ApplyResources(this.textBox_mode1_time, "textBox_mode1_time");
            this.textBox_mode1_time.Name = "textBox_mode1_time";
            // 
            // label_mode1_time
            // 
            resources.ApplyResources(this.label_mode1_time, "label_mode1_time");
            this.label_mode1_time.Name = "label_mode1_time";
            // 
            // textBox_mode1_load
            // 
            resources.ApplyResources(this.textBox_mode1_load, "textBox_mode1_load");
            this.textBox_mode1_load.Name = "textBox_mode1_load";
            // 
            // label_mode1_load
            // 
            resources.ApplyResources(this.label_mode1_load, "label_mode1_load");
            this.label_mode1_load.Name = "label_mode1_load";
            // 
            // textBox_mode1_frequency
            // 
            resources.ApplyResources(this.textBox_mode1_frequency, "textBox_mode1_frequency");
            this.textBox_mode1_frequency.Name = "textBox_mode1_frequency";
            // 
            // label_mode1_frequency
            // 
            resources.ApplyResources(this.label_mode1_frequency, "label_mode1_frequency");
            this.label_mode1_frequency.Name = "label_mode1_frequency";
            // 
            // textBox_mode1_speed
            // 
            resources.ApplyResources(this.textBox_mode1_speed, "textBox_mode1_speed");
            this.textBox_mode1_speed.Name = "textBox_mode1_speed";
            // 
            // label_mode1_speed
            // 
            resources.ApplyResources(this.label_mode1_speed, "label_mode1_speed");
            this.label_mode1_speed.Name = "label_mode1_speed";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.button_mode1_start);
            this.groupBox.Controls.Add(this.textBox_mode1_time);
            this.groupBox.Controls.Add(this.cancel_button);
            this.groupBox.Controls.Add(this.label_mode1_time);
            this.groupBox.Controls.Add(this.label_mode1_speed);
            this.groupBox.Controls.Add(this.textBox_mode1_frequency);
            this.groupBox.Controls.Add(this.textBox_mode1_load);
            this.groupBox.Controls.Add(this.label_mode1_frequency);
            this.groupBox.Controls.Add(this.label_mode1_load);
            this.groupBox.Controls.Add(this.textBox_mode1_speed);
            resources.ApplyResources(this.groupBox, "groupBox");
            this.groupBox.Name = "groupBox";
            this.groupBox.TabStop = false;
            // 
            // SpeedModeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "SpeedModeForm";
            this.TopMost = true;
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_mode1_start;
        public System.Windows.Forms.TextBox textBox_mode1_time;
        private System.Windows.Forms.Label label_mode1_time;
        public System.Windows.Forms.TextBox textBox_mode1_load;
        private System.Windows.Forms.Label label_mode1_load;
        public System.Windows.Forms.TextBox textBox_mode1_frequency;
        private System.Windows.Forms.Label label_mode1_frequency;
        public System.Windows.Forms.TextBox textBox_mode1_speed;
        private System.Windows.Forms.Label label_mode1_speed;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.GroupBox groupBox;
    }
}