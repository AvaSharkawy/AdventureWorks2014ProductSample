using System.Data;

namespace AnventureWorks2014Sample.DataAccess
{
    public class SubCategory
    {
        private static string GetAll =>
            "select \n" +
            "ProductCategoryID,\n" +
            "ProductSubcategoryID,\n" +
            "Name\n" +
            "from Production.ProductSubcategory\n";


        public static DataTable GetSubCategories()
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
