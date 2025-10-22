using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BusInsuranceSQL.OfflineSQL
{
    public class SQLChoice
    {

        //public static string connectionString = @"Data Source=.;Initial Catalog=BusInsurance;Integrated Security=True";

        private static string connectionString = @"Server=.\SQLEXPRESS;AttachDbFilename=D:\BusInsuranceDB\BusInsurance.mdf;Database=BusInsurance;Trusted_Connection=true;";

        public static DataTable Select(string Query)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter(Query, cnn);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            return dt;
        }
        public static void Insert(string Query)
        {
            
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();


            command = new SqlCommand(Query, cnn);

            adapter.InsertCommand = new SqlCommand(Query, cnn);
            try
            {
                adapter.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "شماره پلاک وارد شده قبلا در سیستم ثبت شده است", "شماره پلاک تکراری",
                    MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign
                    );
            }

            command.Dispose();
            cnn.Close();
        }
        public static void Update(string Query)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            cnn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.UpdateCommand = new SqlCommand(Query, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();

            cnn.Close();
        }
        public static void Delete(string Query)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            cnn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.DeleteCommand = new SqlCommand(Query, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();

            cnn.Close();
        }
    }
}
