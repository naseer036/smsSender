using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sms
{
    public partial class CheckSchedule : Form
    {
        public CheckSchedule()
        {
            InitializeComponent();
        }
        private void CheckSchedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Schedule' table. You can move, or remove it, as needed.
            this.scheduleTableAdapter.Fill(this.database1DataSet.Schedule);
            // TODO: This line of code loads data into the 'database1DataSet.Schedule' table. You can move, or remove it, as needed.
            this.scheduleTableAdapter.Fill(this.database1DataSet.Schedule);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
