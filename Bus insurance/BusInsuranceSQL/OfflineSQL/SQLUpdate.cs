using Bus_Insurance_Library.Logics;
using Bus_Insurance_Library.Models;

namespace BusInsuranceSQL.OfflineSQL
{
    public static class SQLUpdate
    {
        public static void UpdateSelectedModel(FullModel model)
        {
         
            SQLChoice.Update(string.Format(@"UPDATE tblCustomer set tblCustomer.CarNumber = '{0}',tblCustomer.FullName ='{1}',
                                               tblCustomer.Status ='{2}',tblCustomer.Explain ='{3}' where tblCustomer.CarNumber ='{0}'",
                                               model.CarNumber, model.FullName, model.Status,model.Explain));

            SQLChoice.Update(string.Format(@"UPDATE tblDate set tblDate.CarNumber = '{0}',tblDate.FuelEntry ='{1}',
                                               tblDate.FuelExpier ='{2}',tblDate.InsuranceEntry ='{3}',
                                               tblDate.InsuranceExpier ='{4}' where tblDate.CarNumber  ='{0}'",
                                               model.CarNumber, model.EntryFuel, DateLogics.ExpierDate(model.EntryFuel),
                                               model.EntryInsurance, DateLogics.ExpierDate(model.EntryInsurance)));


        }
    }
}
