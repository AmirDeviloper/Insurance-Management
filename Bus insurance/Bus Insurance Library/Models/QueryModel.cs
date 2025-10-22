using System.Data;

namespace Bus_Insurance_Library.Models
{
    public static class QueryModel
    {
        public static DataTable FullModels{ get; set; }
        public static DataTable SelectedModel{ get; set; }

        public static DataTable SelectedExplain{ get; set; }
    }
}
