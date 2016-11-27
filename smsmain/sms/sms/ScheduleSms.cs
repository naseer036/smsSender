using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;

namespace sms
{
    public partial class ScheduleSms : Form
    {
        public ScheduleSms()
        {
            InitializeComponent();
            fillcombo();
        }

        private void fillcombo()
        {
            SqlConnection con;
            SqlCommand cmd;
            String command = "";
            command = "SELECT VehicleNumber FROM customer";
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\sms\data\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                con.Open();
                cmd = new SqlCommand(command, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    ComboBoxVehNum.Items.Add(dr["VehicleNumber"].ToString());
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                con.Close();
            }
            DateTimePickerService.Value = DateTime.Today.AddMonths(2);
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            String VehicleTemp = "";
            String DateTemp = "";
            VehicleTemp = ComboBoxVehNum.Text;
            DateTemp = DateTimePickerService.Value.ToShortDateString();
            SqlConnection con;
            SqlCommand cmd;
            String command = "INSERT INTO Schedule (VehicleNo, Date) VALUES ('"+VehicleTemp+"','" + DateTemp + "')";
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\sms\data\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                con.Open();
                cmd = new SqlCommand(command, con);
                cmd.ExecuteNonQuery();
                con.Close();
                ComboBoxVehNum.Text = String.Empty;
                DateTimePickerService.Value = DateTime.Today.AddMonths(2);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void ScheduleSms_Load(object sender, EventArgs e)
        {

        }
    }
}
