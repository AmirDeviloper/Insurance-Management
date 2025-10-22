using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace BusInsuranceSQL.OnlineSQL
{
    public static class OnlineMySqlQuery
    {
        /*
        private static int Score { get; set; }
        private const string AppVersion = "2.0";
        private static MySqlConnection connection = 
            new MySqlConnection("??");

        public static bool UserChecker()
        {
            connection.Open();
            SelectUser();
            ExpierDate();
            OneUserAccess();
            ApplicationVersion();
            connection.Close();

            if (Score.Equals(4))
            {
                SignInOut(true);
                return true;
            }

            else
            {
                Score = 0;
                return false;
            }
        }
        public static void Message(string message,string caption)
        {
            MessageBox.Show(message,caption,
                MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }
        private static MySqlCommand SelectCreator(string Query)
        {
            MySqlCommand mysqlCommand = connection.CreateCommand();
            mysqlCommand.CommandText = Query;

            return mysqlCommand;
        }
        private static void SelectUser()
        {
            try
            {
                var reader = SelectCreator(string.Format("SELECT COUNT(*) FROM UserTable WHERE (UserName='{0}' AND UserKey='{1}')", "alimahjoob", "abcd!@#$")).ExecuteScalar();
                if (int.Parse(reader.ToString()).Equals(1))
                {
                    Score++;
                }
                else
                {
                    Message("کاربری یافت نشد , میتوانید با پشتیبانی تماس بگیرید", "عدم یافتن کاربر");
                    
                }
            }
            catch (Exception)
            {
                Message("مشکلی در اتصال به سرور بوجود آمده است , دوباره تلاش کنید", "مشکل در برقراری ارتباط");
            }
        }
        private static void ExpierDate()
        {
            try
            {
                var reader = SelectCreator("SELECT COUNT(*) FROM DateTable WHERE (DateId =1 AND`ExpierDate` > NOW())").ExecuteScalar();
                if (int.Parse(reader.ToString()).Equals(1))
                {
                    Score++;
                }
                else
                {
                    Message("اکانت شما منقضی شده است , برای شارژ مجدد با پشتیبانی تماس بگیرید", "منقضی شدن اکانت");

                }
            }
            catch (Exception)
            {

                Message("مشکلی در اتصال به سرور بوجود آمده است , دوباره تلاش کنید", "مشکل در برقراری ارتباط");

            }
        }
        private static void OneUserAccess()
        {
            try
            {
                var reader = SelectCreator("SELECT COUNT(*) FROM DateTable WHERE (DateId = 1 AND Status = 0)").ExecuteScalar();
                if (int.Parse(reader.ToString()).Equals(1))
                {
                    Score++;
                }
                else
                {
                    Message("کاربر دیگری در حال استفاده از برنامه میباشد , لطفا در صورت عدم اشتراک گذاری برنامه با شخص دیگر , با پشتیبانی تماس بگیرید", "استفاده توسط شخص ثالث");
                }
            }
            catch (Exception)
            {
                Message("مشکلی در اتصال به سرور بوجود آمده است , دوباره تلاش کنید", "مشکل در برقراری ارتباط");

            }
        }
        private static void ApplicationVersion()
        {
            try
            {
                var reader = SelectCreator(string.Format("SELECT COUNT(*) FROM ApplicationTable WHERE (AppId =1 AND Version ='{0}')", AppVersion)).ExecuteScalar();
                if (int.Parse(reader.ToString()).Equals(1))
                {
                    Score++;
                }
                else
                {
                    Message("نسخه جدید بروز رسانی برنامه وجود دارد , لطفا از پشتیبانی برنامه را دریافت کنید", "دریافت بروزرسانی");

                }
            }
            catch (Exception)
            {
                Message("مشکلی در اتصال به سرور بوجود آمده است , دوباره تلاش کنید", "مشکل در برقراری ارتباط");
            }
        }
        public static void SignInOut(bool state)
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();

                if (state)
                {
                    cmd.CommandText = "UPDATE DateTable SET Status= '1' WHERE (DateId = 1)";
                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.CommandText = "UPDATE DateTable SET Status ='0' WHERE (DateId = 1)";
                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception)
            {
                Application.Exit();
            }
        }
    }
    */
    }
}
