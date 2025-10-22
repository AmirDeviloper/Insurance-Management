using Bus_Insurance_Library;
using System.Net;
using System.Windows.Forms;

namespace BusInsuranceSQL.OnlineSQL
{
    public static class OnlineUser 
    {
        private static int counter;
        /*

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
        */
        public static bool ProgramInProgress()
        {
            counter++;

            if (counter % 1800 == 0)
            {
                if (UserChecker.Checker())
                return true;
                else
                {
                    Application.Exit();
                    return false;
                }

            }
            else
                return true;
        }
        
    }
}
