using Bus_Insurance_Library.Models;
using System;
using System.Data;

namespace Bus_Insurance_Library.MessageBoxClass
{
    public static class MessageSelector
    {
        private static string carNumber, explain;
        public static Tuple<string, string> Messages(MsgBox.Msg MessageType)
        {
            switch (MessageType)
            {
                case MsgBox.Msg.InsertFailed:
                    return new Tuple<string, string>("ثبت اطلاعات با مشکل مواجه شده است , لطفا ورودی های معتبری وارد کنید", "ثبت ناموفق");
                case MsgBox.Msg.UpdateSuccesfull:
                    return new Tuple<string, string>("بروز رسانی اطلاعات با موفقیت انجام شد", "بروز رسانی موفق");
                case MsgBox.Msg.UpdateFailed:
                    return new Tuple<string, string>("بروز رسانی اطلاعات ناموفق بوده است , لطفا ورودی های معتبری وارد کنید", "بروز رسانی ناموفق");
                case MsgBox.Msg.DeleteSuccesfull:
                    return new Tuple<string, string>("حذف اطلاعات با موفقیت انجام شد", "حذف موفقیت آمیز");
                case MsgBox.Msg.DeleteFailed:
                    return new Tuple<string, string>("حذف اطلاعات با شکست انجام شد", "حذف ناموفق");
                case MsgBox.Msg.InvalidRow:
                    return new Tuple<string, string>("ردیف انتخابی اشتباه است", "اعتبار سنجی انتخاب");
                case MsgBox.Msg.About:
                    return new Tuple<string, string>(
                        "این برنامه تحت عنوان مدیریت بیمه وسایل نقلیه برای شخص علی محجوب و برای استفاده شخصی وی ساخته شده است"+
                        "\n"+" استفاده از اثر مشروط به دریافت اجازه کتبی از صاحب اثر یا سازنده آن میباشد"+ "\n" +
                        "ارتباط با سازنده: \namir.hematyar76@gmail.com", "درباره اثر");

                case MsgBox.Msg.Support:
                    return new Tuple<string, string>("در صورت مشاهده این پیام , میتوانید با پشتیبانی تماس بگیرید", "با پشتیبانی تماس بگیرید");

                case MsgBox.Msg.Explain:
                    {
                        
                        foreach (DataRow item in QueryModel.SelectedModel.Rows)
                        {
                            carNumber = string.Format("توضیحات مربوط به شماره پلاک '{0}' به شرح زیر است", item["CarNumber"].ToString());
                            explain = item["Explain"].ToString();
                        }
                        return new Tuple<string, string>(explain, carNumber);
                    }
                default:
                    return new Tuple<string, string>("0", "0");
            }
        }
    }
}
