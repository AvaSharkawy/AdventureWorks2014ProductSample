using System.Data;
using System.Data.SqlClient;

namespace AnventureWorks2014Sample.DataAccess
{
    public class Products
    {
        private static string GetAll =>
            "select \n" +
            "product.ProductID,\n" +
            "product.ProductNumber,\n" +
            "loc.Name as ProductLocation,\n" +
            "ISNULL(inventory.Quantity, 0) as ProductStockQuantity,\n" +
            "subCategory.Name as ProductSubCategory,\n" +
            "category.Name as ProductCategory\n" +

            "from Production.ProductInventory inventory\n" +

            "right join Production.Product product\n" +
            " on product.ProductID = inventory.ProductID\n" +

            "left join Production.Location loc\n" +
            " on inventory.LocationID = loc.LocationID\n" +

            "inner join Production.ProductSubcategory subCategory\n" +
            " on subCategory.ProductSubcategoryID = product.ProductSubcategoryID\n" +

            "inner join Production.ProductCategory category\n" +
            "  on category.ProductCategoryID = subCategory.ProductCategoryID\n" +

            "where product.ProductID <> 0\n";


        public static DataTable GetProducts(string filter = "", SqlParameter[] sqlParameters = null)
        {
            using (var dataAccess = new DataAccess())
            {
                dataAccess.Open();

                var query = GetAll;

                if (filter.IsNullOrEmpty() == false)
                    query += filter;

                var dt = dataAccess.GetData(query, sqlParameters);

                return dt;
            }
        }
    }
}
