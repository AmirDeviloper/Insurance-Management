using System;
using System.Threading;
using System.Windows.Forms;

namespace Bus_Insurance
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        static Mutex mutex = new Mutex(true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}");
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginForm());
            }
            else
            {
                MessageBox.Show("برنامه در حال اجراست , در صورت بروز مشکل , از بخش مدیریت نرم افزار ها آن را ببندید", "برنامه در حال اجراست",
                MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

            }
        }
    }
}
