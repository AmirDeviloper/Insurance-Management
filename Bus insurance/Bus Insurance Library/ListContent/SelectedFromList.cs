using Bus_Insurance_Library.Logics;
using Bus_Insurance_Library.Models;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Bus_Insurance_Library.ListContent
{
    public static class SelectedFromList
    {
        public static FullModel SelectedModel()
        {
            FullModel orginalModel = new FullModel();

            foreach (DataRow item in QueryModel.SelectedModel.Rows)
            {
                orginalModel.CarNumber = item["CarNumber"].ToString();
                orginalModel.FullName = item["FullName"].ToString();
                orginalModel.EntryFuel = item["FuelEntry"].ToString();
                orginalModel.EntryInsurance = item["InsuranceEntry"].ToString();
                orginalModel.Status = bool.Parse(item["Status"].ToString());
                orginalModel.Explain = item["Explain"].ToString();
            }

            return orginalModel;
        }
        public static void FullModelGridShow(DataGridView ListGW)
        {
            ListGW.Rows.Clear();
            foreach (DataRow item in QueryModel.FullModels.Rows)
            {
                int n = ListGW.Rows.Add();
                ListGW.Rows[n].Height = 30;
                ListGW.Rows[n].Cells[0].Value = n + 1 ;
                ListGW.Rows[n].Cells[1].Value = item["FullName"].ToString();
                ListGW.Rows[n].Cells[2].Value = item["CarNumber"].ToString();
                ListGW.Rows[n].Cells[3].Value = item["FuelEntry"].ToString();
                ListGW.Rows[n].Cells[4].Value = item["FuelExpier"].ToString();
                ListGW.Rows[n].Cells[5].Value = item["InsuranceEntry"].ToString();
                ListGW.Rows[n].Cells[6].Value = item["InsuranceExpier"].ToString();
                ListGW.Rows[n].Cells[7].Value = item["Status"];

                RowColorChanger(ListGW.Rows[n], item["FuelExpier"].ToString(),item["InsuranceExpier"].ToString(), (bool)item["Status"]);

            }
        }
        private static void RowColorChanger(DataGridViewRow row , string expierFuel , string expierInsurance , bool status)
        {
            row.DefaultCellStyle.BackColor = Color.Lime;
            if ((DateLogics.DaysBettwenDate(expierFuel) <= 0 || DateLogics.DaysBettwenDate(expierInsurance) <= 0))
            {
                row.DefaultCellStyle.BackColor = Color.Red;
            }
            if (status)
            {
                row.DefaultCellStyle.BackColor = Color.Yellow;
            }
        }
    }
}
