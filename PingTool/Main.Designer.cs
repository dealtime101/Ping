
namespace PingTool
{
    partial class MainFrame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.label1 = new System.Windows.Forms.Label();
            this.ms_label = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.ping_result_box = new System.Windows.Forms.TextBox();
            this.settings_btn = new System.Windows.Forms.PictureBox();
            this.user_input_box = new System.Windows.Forms.ComboBox();
            this.btn_x_close = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.settings_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Address";
            // 
            // ms_label
            // 
            this.ms_label.AutoSize = true;
            this.ms_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_label.ForeColor = System.Drawing.Color.White;
            this.ms_label.Location = new System.Drawing.Point(84, 78);
            this.ms_label.Name = "ms_label";
            this.ms_label.Size = new System.Drawing.Size(27, 16);
            this.ms_label.TabIndex = 3;
            this.ms_label.Text = "ms";
            // 
            // start_btn
            // 
            this.start_btn.ForeColor = System.Drawing.Color.Black;
            this.start_btn.Location = new System.Drawing.Point(28, 105);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(53, 23);
            this.start_btn.TabIndex = 4;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.stop_btn.Location = new System.Drawing.Point(28, 104);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(53, 23);
            this.stop_btn.TabIndex = 5;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // ping_result_box
            // 
            this.ping_result_box.BackColor = System.Drawing.Color.Black;
            this.ping_result_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ping_result_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ping_result_box.Location = new System.Drawing.Point(3, 50);
            this.ping_result_box.Multiline = true;
            this.ping_result_box.Name = "ping_result_box";
            this.ping_result_box.Size = new System.Drawing.Size(85, 48);
            this.ping_result_box.TabIndex = 6;
            this.ping_result_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // settings_btn
            // 
            this.settings_btn.Image = ((System.Drawing.Image)(resources.GetObject("settings_btn.Image")));
            this.settings_btn.Location = new System.Drawing.Point(85, 106);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(20, 20);
            this.settings_btn.TabIndex = 7;
            this.settings_btn.TabStop = false;
            this.settings_btn.Click += new System.EventHandler(this.Settings_btn_Click);
            // 
            // user_input_box
            // 
            this.user_input_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.user_input_box.FormattingEnabled = true;
            this.user_input_box.Items.AddRange(new object[] {
            "google.ca",
            "google.com",
            "microsoft.com",
            "8.8.8.8"});
            this.user_input_box.Location = new System.Drawing.Point(3, 24);
            this.user_input_box.Name = "user_input_box";
            this.user_input_box.Size = new System.Drawing.Size(109, 21);
            this.user_input_box.TabIndex = 9;
            // 
            // btn_x_close
            // 
            this.btn_x_close.AutoSize = true;
            this.btn_x_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_x_close.Location = new System.Drawing.Point(110, 0);
            this.btn_x_close.Name = "btn_x_close";
            this.btn_x_close.Size = new System.Drawing.Size(16, 16);
            this.btn_x_close.TabIndex = 10;
            this.btn_x_close.Text = "X";
            this.btn_x_close.Click += new System.EventHandler(this.btn_x_close_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(144, 141);
            this.Controls.Add(this.btn_x_close);
            this.Controls.Add(this.user_input_box);
            this.Controls.Add(this.settings_btn);
            this.Controls.Add(this.ping_result_box);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.ms_label);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(125, 132);
            this.Name = "MainFrame";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.settings_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ms_label;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.TextBox ping_result_box;
        private System.Windows.Forms.PictureBox settings_btn;
        private System.Windows.Forms.ComboBox user_input_box;
        private System.Windows.Forms.Label btn_x_close;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

