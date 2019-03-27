using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Experts
{
    public class ProductDB
    {
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            Product product= null;

            SqlConnection connection = TravelExpertsDB.GetConnection();

            var sqlSelect = "SELECT ProductId, ProdName FROM Products";

            //from Products p, Products_Suppliers s, Packages_Products_Suppliers r
            //where p.ProductId = s.ProductId and s.ProductSupplierId = r.ProductSupplierId and PackageId = @PackageId
            SqlCommand selectCmd = new SqlCommand(sqlSelect, connection);

            // execute
            try
            {
                // connect
                connection.Open();

                SqlDataReader dr = selectCmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    product = new Product();
                    product.ProductId = (int)dr["ProductId"];
                    product.ProdName = (string)dr["ProdName"];

                    products.Add(product);

                }
                dr.Close();

                return products;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
