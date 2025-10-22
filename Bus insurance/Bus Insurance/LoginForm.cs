using Bus_Insurance_Library;
using Bus_Insurance_Library.MaterialSkinInstance;
using Bus_Insurance_Library.MessageBoxClass;
using BusInsuranceSQL.OnlineSQL;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace Bus_Insurance
{
    public partial class LoginForm : MaterialForm
    {
        
        public LoginForm()
        {
            InitializeComponent();
            MSManager.SkinManager(this);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {

            lbl.Visible = true;

            if (UserChecker.Checker())
            {
                Hide();
                MainForm frm = new MainForm();
                frm.Show();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
