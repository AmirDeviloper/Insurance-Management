using Bus_Insurance_Library.Logics;
using Bus_Insurance_Library.Models;

namespace BusInsuranceSQL.OfflineSQL
{
    public static class SQLInsert
    {
        public static void InsertCustomer(FullModel model)
        {
            SQLChoice.Insert(string.Format("insert into dbo.tblCustomer values('{0}','{1}','{2}','{3}')", model.CarNumber, model.FullName, model.Status, model.Explain));

            SQLChoice.Insert(
                string.Format(@"insert into dbo.tblDate values ('{0}','{1}','{2}','{3}','{4}')",
                model.CarNumber, model.EntryFuel, DateLogics.ExpierDate(model.EntryFuel) , model.EntryInsurance, DateLogics.ExpierDate (model.EntryInsurance)));

        }
    }
}
