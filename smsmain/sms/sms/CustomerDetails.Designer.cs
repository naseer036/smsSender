namespace sms
{
    partial class CustomerDetails
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
            this.TextBoxCusNumb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxVehNumb = new System.Windows.Forms.TextBox();
            this.TextBoxVehType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxCusName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxCusNumb
            // 
            this.TextBoxCusNumb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxCusNumb.Location = new System.Drawing.Point(139, 38);
            this.TextBoxCusNumb.Name = "TextBoxCusNumb";
            this.TextBoxCusNumb.Size = new System.Drawing.Size(213, 20);
            this.TextBoxCusNumb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vehicle Number";
            // 
            // TextBoxVehNumb
            // 
            this.TextBoxVehNumb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxVehNumb.Location = new System.Drawing.Point(139, 64);
            this.TextBoxVehNumb.Name = "TextBoxVehNumb";
            this.TextBoxVehNumb.Size = new System.Drawing.Size(213, 20);
            this.TextBoxVehNumb.TabIndex = 3;
            // 
            // TextBoxVehType
            // 
            this.TextBoxVehType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxVehType.Location = new System.Drawing.Point(139, 90);
            this.TextBoxVehType.Name = "TextBoxVehType";
            this.TextBoxVehType.Size = new System.Drawing.Size(213, 20);
            this.TextBoxVehType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vehicle Type";
            // 
            // TextBoxCusName
            // 
            this.TextBoxCusName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxCusName.Location = new System.Drawing.Point(139, 12);
            this.TextBoxCusName.Name = "TextBoxCusName";
            this.TextBoxCusName.Size = new System.Drawing.Size(213, 20);
            this.TextBoxCusName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Customer Name";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(139, 116);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(108, 23);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CustomerDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(364, 173);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TextBoxCusName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxVehType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxVehNumb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxCusNumb);
            this.Name = "CustomerDetails";
            this.Text = "ScheduleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxCusNumb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxVehNumb;
        private System.Windows.Forms.TextBox TextBoxVehType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxCusName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveButton;
    }
}