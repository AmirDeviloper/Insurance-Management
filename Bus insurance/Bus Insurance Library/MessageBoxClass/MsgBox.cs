using System.Windows.Forms;

namespace Bus_Insurance_Library.MessageBoxClass
{
    public static class MsgBox
    {
        public enum Msg
        {
            InsertFailed,
            UpdateSuccesfull,
            UpdateFailed,
            DeleteSuccesfull,
            DeleteFailed,
            InvalidRow,
            About,
            Support,
            Explain
        }

        public static void Show(Form form)
        {
            form.ShowDialog();
        }
        public static DialogResult ShowY(MaterialSkin.Controls.MaterialForm form)
        {
            DialogResult result = DialogResult.None;
            
            result = form.ShowDialog();
            return result;
        }

    }
}

