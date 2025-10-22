using Bus_Insurance_Library.MaterialSkinInstance;
using MaterialSkin.Controls;

namespace Bus_Insurance
{
    public partial class MsgBox_YN : MaterialForm
    {
        public MsgBox_YN(string message, string caption)
        {
            InitializeComponent();
            MSManager.SkinManager(this);
            lblMessage.Text = message;
            Text = caption;
        }

    }
}
