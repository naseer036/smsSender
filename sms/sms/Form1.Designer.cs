namespace sms
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deliverNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleSMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deliverNowToolStripMenuItem,
            this.scheduleSMSToolStripMenuItem,
            this.scheduleDetailsToolStripMenuItem,
            this.checkScheduleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deliverNowToolStripMenuItem
            // 
            this.deliverNowToolStripMenuItem.Name = "deliverNowToolStripMenuItem";
            this.deliverNowToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.deliverNowToolStripMenuItem.Text = "Deliver SMS";
            this.deliverNowToolStripMenuItem.Click += new System.EventHandler(this.deliverNowToolStripMenuItem_Click);
            // 
            // scheduleSMSToolStripMenuItem
            // 
            this.scheduleSMSToolStripMenuItem.Name = "scheduleSMSToolStripMenuItem";
            this.scheduleSMSToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.scheduleSMSToolStripMenuItem.Text = "Customer Details";
            this.scheduleSMSToolStripMenuItem.Click += new System.EventHandler(this.scheduleSMSToolStripMenuItem_Click);
            // 
            // scheduleDetailsToolStripMenuItem
            // 
            this.scheduleDetailsToolStripMenuItem.Name = "scheduleDetailsToolStripMenuItem";
            this.scheduleDetailsToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.scheduleDetailsToolStripMenuItem.Text = "Schedule Sms";
            this.scheduleDetailsToolStripMenuItem.Click += new System.EventHandler(this.scheduleDetailsToolStripMenuItem_Click);
            // 
            // checkScheduleToolStripMenuItem
            // 
            this.checkScheduleToolStripMenuItem.Name = "checkScheduleToolStripMenuItem";
            this.checkScheduleToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.checkScheduleToolStripMenuItem.Text = "Check/update Schedule";
            this.checkScheduleToolStripMenuItem.Click += new System.EventHandler(this.checkScheduleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deliverNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleSMSToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem checkScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleDetailsToolStripMenuItem;
    }
}

