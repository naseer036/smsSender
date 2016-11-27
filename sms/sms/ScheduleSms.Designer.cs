namespace sms
{
    partial class ScheduleSms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScheduleButton = new System.Windows.Forms.Button();
            this.ComboBoxVehNum = new System.Windows.Forms.ComboBox();
            this.DateTimePickerService = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Next Service";
            // 
            // ScheduleButton
            // 
            this.ScheduleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScheduleButton.Location = new System.Drawing.Point(189, 60);
            this.ScheduleButton.Name = "ScheduleButton";
            this.ScheduleButton.Size = new System.Drawing.Size(75, 23);
            this.ScheduleButton.TabIndex = 4;
            this.ScheduleButton.Text = "Schedule";
            this.ScheduleButton.UseVisualStyleBackColor = true;
            this.ScheduleButton.Click += new System.EventHandler(this.ScheduleButton_Click);
            // 
            // ComboBoxVehNum
            // 
            this.ComboBoxVehNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxVehNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxVehNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxVehNum.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBoxVehNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxVehNum.FormattingEnabled = true;
            this.ComboBoxVehNum.Location = new System.Drawing.Point(189, 6);
            this.ComboBoxVehNum.Name = "ComboBoxVehNum";
            this.ComboBoxVehNum.Size = new System.Drawing.Size(188, 21);
            this.ComboBoxVehNum.Sorted = true;
            this.ComboBoxVehNum.TabIndex = 5;
            // 
            // DateTimePickerService
            // 
            this.DateTimePickerService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePickerService.Location = new System.Drawing.Point(189, 34);
            this.DateTimePickerService.Name = "DateTimePickerService";
            this.DateTimePickerService.Size = new System.Drawing.Size(188, 20);
            this.DateTimePickerService.TabIndex = 6;
            // 
            // ScheduleSms
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(389, 236);
            this.Controls.Add(this.DateTimePickerService);
            this.Controls.Add(this.ComboBoxVehNum);
            this.Controls.Add(this.ScheduleButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ScheduleSms";
            this.Text = "ScheduleSms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ScheduleSms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ScheduleButton;
        private System.Windows.Forms.ComboBox ComboBoxVehNum;
        private System.Windows.Forms.DateTimePicker DateTimePickerService;
    }
}