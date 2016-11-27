using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void scheduleSMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            CustomerDetails ScheduleSmsForm1 = new CustomerDetails();
            ScheduleSmsForm1.MdiParent=this;
            ScheduleSmsForm1.Show();
           
        }

        private void deliverNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            DeliverSms DeliverSmsForm1 = new DeliverSms();
            DeliverSmsForm1.MdiParent = this;
            DeliverSmsForm1.Show();
        }

        private void checkScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            CheckSchedule CheckScheduleForm1 = new CheckSchedule();
            CheckScheduleForm1.MdiParent = this;
            CheckScheduleForm1.Show();
        }

        private void scheduleDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            ScheduleSms ScheduleSmsForm1 = new ScheduleSms();
            ScheduleSmsForm1.MdiParent = this;
            ScheduleSmsForm1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
