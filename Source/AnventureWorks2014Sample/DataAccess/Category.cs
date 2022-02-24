using System.Data;

namespace AnventureWorks2014Sample.DataAccess
{
    public class Category
    {
        private static string GetAll =>
            "select \n" +
            "ProductCategoryID,\n" +
            "Name\n" +
            "from Production.ProductCategory\n";


        public static DataTable GetCategories()
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
