using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WebAppAzure.Models;

namespace WebAppAzure.Services
{
    public class ProductService
    {
        private static string db_source = "azure-app.database.windows.net";
        private static string db_user = "azurewebmaster";
        private static string db_password = "SqlDatabase02";
        private static string db_database = "azure-appserver";

        private SqlConnection GetConnection()
        {
          var builder = new SqlConnectionStringBuilder();

            builder.DataSource = db_source;
            builder.UserID = db_user;
            builder.Password = db_password;
            builder.InitialCatalog = db_database;

            return new SqlConnection(builder.ConnectionString);
        }

        public List<Product> GetProducts()
        {
            SqlConnection conn = GetConnection();

            List<Product> prodList = new List<Product>();

            string statement = "SELECT ProductID, ProductName, Quantity from Products";

            conn.Open();

            SqlCommand cmd = new SqlCommand(statement, conn);

            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product()
                {
                    ProductID = reader.GetInt32(0),
                    ProductName = reader.GetString(1),
                    Quantity = reader.GetInt32(2)
                };
            prodList.Add(product);
            }
            conn.Close();
            return prodList;
        }

    }
}
