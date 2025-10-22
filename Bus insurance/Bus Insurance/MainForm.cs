using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;
using Bus_Insurance_Library.MaterialSkinInstance;
using Bus_Insurance_Library.Logics;
using BusInsuranceSQL.OnlineSQL;
using Bus_Insurance_Library.ListContent;
using Bus_Insurance_Library.Models;
using BusInsuranceSQL.OfflineSQL;
using Bus_Insurance_Library.MessageBoxClass;

namespace Bus_Insurance
{
    public partial class MainForm : MaterialForm
    {
        FullModel selectedModel = new FullModel();

        public void ShowHints()
        {
            nameSearchValue.Hint = "جستجو بر اساس نام";
            carNumberSearchValue.Hint = "جستجو بر اساس پلاک";
            nameValue.Hint = "نام";
            carNumberValue.Hint = "شماره پلاک";
            fuelEntryValue.Hint = "تاریخ شروع سوخت";
            insuranceEntryValue.Hint = "تاریخ شروع بیمه";
            explainValue.Hint = "توضیحات";
        }
        private void Message(MsgBox.Msg msg)
        {
            MsgBox_OK form = new MsgBox_OK(msg);
            MsgBox.Show(form);
        }

        public MainForm()
        {
            InitializeComponent();
            ShowHints();
            themeCheckBox.Checked = false; 
            TypeValidation.MakePerisan();
            MSManager.SkinManager(this);

            timerChecker.Start();
            SQLSelect.SelectAllModels(ListGW);

        }
        private  bool inputValidation()
        {
            if (InputValidation.DateValidation(fuelEntryValue) &&
                InputValidation.DateValidation(insuranceEntryValue) &&
                InputValidation.InputHasValue(nameValue.Text) &&
                InputValidation.InputHasValue(carNumberValue.Text) &&
                InputValidation.InputHasValue(explainValue.Text) &&
                fuelEntryValue.Text.Length.Equals(10) &&
                insuranceEntryValue.Text.Length.Equals(10)&&
                carNumberValue.Text.Length.Equals(13))
                return true;
            
            else return false;
        }
        private void UpdateConcept(bool state)
        {
            addButton.Visible = carNumberValue.Enabled = !state;
            cancelButton.Visible = updateButton.Visible = deleteButton.Visible =  state;
        }
        private void ClearInput()
        {
            selectedModel.CarNumber= string.Empty;
            carNumberSearchValue.Clear();
            nameSearchValue.Clear();
            nameValue.Clear();
            carNumberValue.Clear();
            fuelEntryValue.Clear();
            insuranceEntryValue.Clear();
            statusValue.Checked = false;
            explainValue.Clear();
            SQLSelect.SelectAllModels(ListGW);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (inputValidation())
            {
                FullModel model = new FullModel()
                {
                    FullName = nameValue.Text , CarNumber = carNumberValue.Text ,
                    EntryFuel = fuelEntryValue.Text , EntryInsurance = insuranceEntryValue.Text,
                    Status = statusValue.Checked , Explain = explainValue.Text
                };

                SQLInsert.InsertCustomer(model);

                ClearInput(); 

            }
            else
            {
                Message(MsgBox.Msg.InsertFailed);
            } 
        }
        private void fuelEntryValue_TextChanged(object sender, EventArgs e)
        {
            TypeValidation.DateTypeValidation(fuelEntryValue);
            TypeValidation.ChangeFocus(insuranceEntryValue, fuelEntryValue.Text.Length, 10);
        }
        
        private void fuelEntryValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            TypeValidation.DotClear(fuelEntryValue, e);
        }

        private void insuranceEntryValue_TextChanged(object sender, EventArgs e)
        {
            TypeValidation.DateTypeValidation(insuranceEntryValue);
            TypeValidation.ChangeFocus(explainValue, insuranceEntryValue.Text.Length, 10);
        }

        private void insuranceEntryValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            TypeValidation.DotClear(insuranceEntryValue, e);
        }

        private void nameValue_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void carNumberValue_TextChanged(object sender, EventArgs e)
        {
            TypeValidation.CarNumberTextChange(carNumberValue);
            TypeValidation.ChangeFocus(fuelEntryValue, carNumberValue.Text.Length, 13);
        }

        private void carNumberValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            TypeValidation.CarNumberNormalize(carNumberValue, e);
        }

        private void nameSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (InputValidation.PreventInjection(nameSearchValue))
            {
                carNumberSearchValue.Clear();
                SQLSelect.SelectModelsWithName(ListGW, nameSearchValue.Text);

            }
        }

        private void carNumberSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (InputValidation.PreventInjection(carNumberSearchValue))
            {
                nameSearchValue.Clear();
                SQLSelect.SelectModelsWithCarNumber(ListGW, carNumberSearchValue.Text); 
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            UpdateConcept(false);
            ClearInput(); 
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (inputValidation())
            {
                if (!selectedModel.CarNumber.Equals(string.Empty))
                {
                    MsgBox_YN form = new MsgBox_YN(
                        "با تایید این پیغام , اطلاعات شما بصورت زیر بروز خواهد شد " +
                        "\n" + selectedModel.FullName + " >> " + nameValue.Text + "\n" +
                        selectedModel.CarNumber + " >>" + carNumberValue.Text + "\n" +
                        fuelEntryValue.Text + " << " + selectedModel.EntryFuel + "\n" +
                        insuranceEntryValue.Text + " << " + selectedModel.EntryInsurance,
                        "تأیید بروزرسانی اطلاعات");

                    if ((MsgBox.ShowY(form) == DialogResult.Yes))
                    {
                        FullModel model = new FullModel()
                        {
                            FullName = nameValue.Text,
                            CarNumber = carNumberValue.Text,
                            EntryFuel = fuelEntryValue.Text,
                            EntryInsurance = insuranceEntryValue.Text,
                            Status = statusValue.Checked,
                            Explain = explainValue.Text
                        };

                        SQLUpdate.UpdateSelectedModel(model);
                        
                        UpdateConcept(true);
                        ClearInput();
                    } 
                }
                else
                    Message(MsgBox.Msg.InvalidRow);
            }
            else
                Message(MsgBox.Msg.UpdateFailed);
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!selectedModel.CarNumber.Equals(string.Empty))
            {
                MsgBox_YN form = new MsgBox_YN(
                    "با تأیید این پیغام , اطلاعات انتخابی زیر حذف میشود" +
                        "\n نام : " + selectedModel.FullName +
                        "\n شماره پلاک : " + selectedModel.CarNumber +
                        "\n تاریخ سوخت : " + selectedModel.EntryFuel +
                        "\n تاریخ بیمه : " + selectedModel.EntryInsurance,
                        "تأیید حذف اطلاعات");
                if ((MsgBox.ShowY(form) == DialogResult.Yes))
                {
                    SQLDelete.DeleteSelectedModel(selectedModel.CarNumber);
                    UpdateConcept(true);
                    ClearInput();
                } 
            }
            else
            {
                Message(MsgBox.Msg.InvalidRow);
            }
        }

        private void aboutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Message(MsgBox.Msg.About);
        }

        private void timerChecker_Tick(object sender, EventArgs e)
        {
            if (!OnlineUser.ProgramInProgress())
            {
                Message(MsgBox.Msg.Support);
                Application.Exit();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void themeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            aboutLinkLabel.LinkColor = helpLink.LinkColor = themeCheckBox.Checked ? Color.Blue : Color.Red;
            ListGW.BackgroundColor = themeCheckBox.Checked ? Color.FromArgb(51, 51, 51) : Color.White;
            ListGW.ColumnHeadersDefaultCellStyle.BackColor = themeCheckBox.Checked ? Color.FromArgb(70, 70, 70) : Color.LightGray;
            themeCheckBox.Text = themeCheckBox.Checked ? "برای فعال سازی حالت روشن کلیک کنید" : "برای فعال سازی حالت تاریک کلیک کنید ";
            MSManager.State = themeCheckBox.Checked;
            MSManager.SkinManager(this);
        }

        private void ListGW_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.Button == MouseButtons.Left)
                {

                    SQLSelect.SelectedModel(ListGW[2, e.RowIndex].Value.ToString());
                    UpdateConcept(true);

                    selectedModel = SelectedFromList.SelectedModel();

                    nameValue.Text = selectedModel.FullName;
                    carNumberValue.Text = selectedModel.CarNumber;
                    fuelEntryValue.Text = selectedModel.EntryFuel;
                    insuranceEntryValue.Text = selectedModel.EntryInsurance;
                    statusValue.Checked = selectedModel.Status;
                    explainValue.Text = selectedModel.Explain;

                }
                else if (e.Button == MouseButtons.Right)
                {
                    SQLSelect.SelectedModel(ListGW[2, e.RowIndex].Value.ToString());
                    UpdateConcept(true);

                    Message(MsgBox.Msg.Explain);
                } 
            }
        }

        private void nameValue_Leave(object sender, EventArgs e)
        {
            InputValidation.PreventInjection(nameValue);

        }

        private void carNumberValue_Leave(object sender, EventArgs e)
        {
            InputValidation.PreventInjection(carNumberValue);

        }

        private void fuelEntryValue_Leave(object sender, EventArgs e)
        {
            InputValidation.PreventInjection(fuelEntryValue);

        }

        private void insuranceEntryValue_Leave(object sender, EventArgs e)
        {
            InputValidation.PreventInjection(insuranceEntryValue);

        }

        private void explainValue_Leave(object sender, EventArgs e)
        {
            InputValidation.PreventInjection(explainValue);

        }

        private void showListButton_Click(object sender, EventArgs e)
        {
            nameSearchValue.Clear();
            carNumberSearchValue.Clear();
            SQLSelect.SelectAllModels(ListGW);
        }

        private void helpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(".در زیر به مواردی که باعث راحت کار کردن با برنامه میشود اشاره میشود "+"\n"+
                                ".جهت حذف سریع هر ورودی , دکمه نقطه '.' را استفاده کنید" + "\n"+
                                ".جهت تغییر در هر فایل , روی فایل مورد نظر دوبار کلیک چپ کنید" + "\n"+
                                ".جهت مشاهده توضیحات هر فایل , روی فایل مورد نظر دوبار کلیک راست کنید" +"\n"+
                                "جهت مرتب سازی لیست بر اساس هر مشخصه , برروی تیتر ستون مورد نظر کلیک کنید" +"\n" + 
                                "از ورودی های معتبر استفاده کنید . شماره پلاک و تاریخ را به همان ترتیبی که بصورت عامیانه میخوانید و مینویسید , وارد کنید" + "\n" +
                                "نمونه فایل: نام : علی محجوب  شماره پلاک : 22ایران111ب21  تاریخ : 1390/11/03", "راهنما",
                                MessageBoxButtons.OK, MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }
    }
}