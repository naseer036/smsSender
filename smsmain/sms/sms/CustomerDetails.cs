using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sms
{
    public partial class CustomerDetails : Form
    {
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (TextBoxCusNumb.TextLength != 10)
            {
                MessageBox.Show("check mobile customer number");
            }
            else
            {
                SqlConnection con;
                SqlCommand cmd;
                String command = "";
                command = "INSERT INTO customer (CustomerNumber, VehicleNumber, VehicleType, CustomerName) VALUES ('" + TextBoxCusNumb.Text + "','" + TextBoxVehNumb.Text + "','" + TextBoxVehType.Text + "','" + TextBoxCusName.Text + "');";
                con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\sms\data\Database1.mdf;Integrated Security=True;Connect Timeout=30");
                try
                {
                    con.Open();
                    cmd = new SqlCommand(command, con);
                    cmd.ExecuteNonQuery();
                    TextBoxCusName.Text = String.Empty;
                    TextBoxCusNumb.Text = String.Empty;
                    TextBoxVehNumb.Text = String.Empty;
                    TextBoxVehType.Text = String.Empty;
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
        }
    }
}
