using Bus_Insurance_Library.ListContent;
using Bus_Insurance_Library.Models;
using System.Windows.Forms;

namespace BusInsuranceSQL.OfflineSQL
{
    public static class SQLSelect 
    {
        public static void SelectAllModels(DataGridView ListGW)
        {
            QueryModel.FullModels = SQLChoice.Select(@"SELECT tblCustomer.CarNumber,tblCustomer.FullName,tblCustomer.Status,
		                                                     tblDate.FuelEntry,tblDate.FuelExpier,tblDate.InsuranceEntry,tblDate.InsuranceExpier
		                                                     FROM tblDate INNER JOIN tblCustomer  on tblCustomer.CarNumber = tblDate.CarNumber");

            SelectedFromList.FullModelGridShow(ListGW);

        }

        public static void SelectModelsWithName(DataGridView ListGW , string name)
        {
            QueryModel.FullModels = SQLChoice.Select(@"SELECT tblCustomer.CarNumber,tblCustomer.FullName,tblCustomer.Status,
		                                                     tblDate.FuelEntry,tblDate.FuelExpier,tblDate.InsuranceEntry,tblDate.InsuranceExpier
		                                                     FROM tblDate INNER JOIN tblCustomer  on tblCustomer.CarNumber = tblDate.CarNumber
                                                             where tblCustomer.FullName like'%" + name + "%'" );

            SelectedFromList.FullModelGridShow(ListGW);
        }

        public static void SelectModelsWithCarNumber(DataGridView ListGW, string carNumber)
        {
            QueryModel.FullModels = SQLChoice.Select(@"SELECT tblCustomer.CarNumber,tblCustomer.FullName,tblCustomer.Status,
		                                                     tblDate.FuelEntry,tblDate.FuelExpier,tblDate.InsuranceEntry,tblDate.InsuranceExpier
		                                                     FROM tblDate INNER JOIN tblCustomer  on tblCustomer.CarNumber = tblDate.CarNumber
                                                             where tblCustomer.CarNumber like'%" + carNumber + "%'");

            SelectedFromList.FullModelGridShow(ListGW);
            
        }

        public static void SelectedModel(string carNumber)
        {
            QueryModel.SelectedModel = SQLChoice.Select(@"SELECT tblCustomer.CarNumber,tblCustomer.FullName,tblCustomer.Status,
                                                            tblCustomer.Explain,tblDate.FuelEntry,tblDate.InsuranceEntry
		                                                     FROM tblDate INNER JOIN tblCustomer  on tblCustomer.CarNumber = tblDate.CarNumber
                                                             where tblCustomer.CarNumber ='" + carNumber + "'");

            
        }
    }
}
