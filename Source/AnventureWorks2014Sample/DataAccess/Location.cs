using System.Data;

namespace AnventureWorks2014Sample.DataAccess
{
    public class Location
    {
        private static string GetAll =>
            "select \n" +
            "LocationID,\n" +
            "Name\n" +
            "from Production.Location\n";


        public static DataTable GetLocations()
        {
            using (var dataAccess = new DataAccess())
            {
                dataAccess.Open();

                var dt = dataAccess.GetData(GetAll, null);

                return dt;
            }
        }
    }
}
