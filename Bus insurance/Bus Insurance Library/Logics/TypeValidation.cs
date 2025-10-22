using System.Windows.Forms;

namespace Bus_Insurance_Library.Logics
{
    public static class TypeValidation
    {
        public static void MakePerisan()
        {
            InputLanguage.CurrentInputLanguage =
            InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("fa-IR"));
        }
        public static void ChangeFocus(MaterialSkin.Controls.MaterialSingleLineTextField nextField, int currentValue, int size)
        {
            if (currentValue.Equals(size))
                nextField.Focus();
        }
        public static void DateTypeValidation(MaterialSkin.Controls.MaterialSingleLineTextField inputdata)
        {
            if (inputdata.Text.Length == 2 || inputdata.Text.Length == 5)
            {
                inputdata.Text = "/" + inputdata.Text;
                inputdata.SelectionStart = 0;
            }
        }

        public static void DotClear(MaterialSkin.Controls.MaterialSingleLineTextField inputdata, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                inputdata.Clear();
            }
        }
        public static void CarNumberNormalize(MaterialSkin.Controls.MaterialSingleLineTextField inputdata, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.'))
            {
                inputdata.Clear();
            }
            if (inputdata.Text.Length >= 0 && inputdata.Text.Length <= 8 ||
                inputdata.Text.Length >=11)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
            if (inputdata.Text.Length.Equals(6))
            {
                StartAtZero(inputdata);
            }
            if (inputdata.Text.Length == 2)
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        StartAtZero(inputdata);
                        e.Handled = false;
                    }
                    else
                        e.Handled = true;

                }
            }
        public static void CarNumberTextChange(MaterialSkin.Controls.MaterialSingleLineTextField inputdata)
        {
            string IRANHolder;
            if (inputdata.Text.Length == 2)
            {
                StartAtZero(inputdata);

            }
            if (inputdata.Text.Length == 3)
            {
                StartAtZero(inputdata);
            }

            if (inputdata.Text.Length == 6)
            {
                IRANHolder = inputdata.Text;
                inputdata.Clear();
                inputdata.Text = "ایران";
                inputdata.Text += IRANHolder;
            }
            if (inputdata.Text.Length == 11)
            {
                StartAtZero(inputdata);
            }
        }
        private static void StartAtZero(MaterialSkin.Controls.MaterialSingleLineTextField inputdata)
        {
            inputdata.SelectionStart = 0;
            inputdata.SelectionLength = 0;
        }
    }
}
