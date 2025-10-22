namespace BusInsuranceSQL.OfflineSQL
{
    public static class SQLDelete
    {
        public static void DeleteSelectedModel(string carNumber)
        {

            SQLChoice.Delete(string.Format("DELETE FROM tblDate WHERE tblDate.CarNumber = '{0}'", carNumber));

            SQLChoice.Delete(string.Format("DELETE FROM tblCustomer WHERE tblCustomer.CarNumber = '{0}'", carNumber));

        }
    }
}
