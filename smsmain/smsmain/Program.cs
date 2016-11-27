using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Web;
using System.Collections.Specialized;
using System.IO;


namespace smsmain
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con;
            SqlCommand SelectVehiclNoCmd;
            SqlCommand UpdateDateCmd;
            String command = "";
            String path=@"E:\sms\smslog.txt";
            String data = "";
            String date = DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString(); ;
            command = "SELECT VehicleNo, Date FROM Schedule WHERE (Date = '"+date+"')";
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\data\BillingDatabase.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true");
            try
            {
                con.Open();
                String CommandDate = "UPDATE Schedule SET Date = '"+date+"' WHERE (Date < '"+date+"')";
                SqlCommand SelectPrevviousDate = new SqlCommand();
                
                SelectVehiclNoCmd = new SqlCommand(command, con);
                SqlDataReader dr = SelectVehiclNoCmd.ExecuteReader();
                while (dr.Read())
                {
                    String VehicleTemp=dr["VehicleNo"].ToString();
                    try
                    {
                        String command2 = "SELECT CustomerNo, VehicleType, CustomerName, VehicleNo FROM Customer WHERE (VehicleNo = '" + VehicleTemp + "')";
                        SqlCommand SelectCustomerNoCmd2 = new SqlCommand(command2, con);
                        SqlDataReader dr2 = SelectCustomerNoCmd2.ExecuteReader();
                        while(dr2.Read())
                        {
                            try
                            {
                                String message = HttpUtility.UrlEncode("Mr." + dr2["CustomerName"].ToString().Trim() + " this is to remind you that your " + dr2["VehicleType"].ToString() + " with reg no. " + dr2["VehicleNo"].ToString() + " is due for servic. Please call 9880369118,988625448 to schedule a pickup or know more.");
                                using (var wb = new WebClient())
                                {
                                    byte[] response = wb.UploadValues("http://api.textlocal.in/send/", new NameValueCollection()
                                    {
                                        {"username" , "muralikrishna6543@gmail.com"},
                                        {"hash" , "6465095981aa3c0ef027314496be2863646d04d2"},
                                        {"numbers" , dr2["CustomerNo"].ToString()},
                                        {"message" , message},
                                        {"sender" , "TXTLCL"}
                                    });
                                    string result = System.Text.Encoding.UTF8.GetString(response);
                                    data = "sms sent to " + dr2["CustomerNo"].ToString() + " response " + result + " ";
                                    File.AppendAllText(path, data);
                                    File.AppendAllText(path, DateTime.Now.ToString() + " "+Environment.NewLine);

                                }
                            }
                            catch (Exception es)
                            {
                                File.AppendAllText(path, es.Message);
                                File.AppendAllText(path, DateTime.Now.ToString() + Environment.NewLine);
                            }
                        }
                    }
                    catch(Exception es)
                    {
                        File.AppendAllText(path, es.Message);
                        File.AppendAllText(path, DateTime.Now.ToString() + Environment.NewLine);
                    }
                }
            }
            catch (Exception es)
            {
                File.AppendAllText(path, es.Message);
                File.AppendAllText(path, DateTime.Now.ToString() + Environment.NewLine);
            }
            finally
            {
                con.Close();
            }
            try
            {
                command = "UPDATE Schedule SET Date = '" + DateTime.Today.AddMonths(2).ToShortDateString() + "' WHERE (Date = '" + DateTime.Today.ToShortDateString() + "')";
                con.Open();
                UpdateDateCmd = new SqlCommand(command, con);
                UpdateDateCmd.ExecuteNonQuery();
            }
            catch (Exception es)
            {
                File.AppendAllText(path, es.Message);
                File.AppendAllText(path, DateTime.Now.ToString() + Environment.NewLine);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
