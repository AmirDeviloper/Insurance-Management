
using Bus_Insurance_Library.MaterialSkinInstance;
using Bus_Insurance_Library.MessageBoxClass;
using MaterialSkin.Controls;
using System;

namespace Bus_Insurance
{
    public partial class MsgBox_OK : MaterialForm
    {
        public MsgBox_OK(MsgBox.Msg MessageType)
        {
            InitializeComponent();
            

            MSManager.SkinManager(this);
            Tuple<string, string> tempMessage = MessageSelector.Messages(MessageType);

            lblMessage.Text= tempMessage.Item1;
            Text = tempMessage.Item2;
        }

    }
}
