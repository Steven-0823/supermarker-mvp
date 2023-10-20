using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket_mvp1.Models;
using System.Data;
using Supermarket_mvp._Repositories;

namespace Supermarket_mvp1._Repositories
{
    internal class ProductRepository : BaseRepository , IProductRepository


    {
        public ProductRepository(string connetionString)
        {
            this.connectionString = connetionString;
        }
        public void add(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Productos VALUES (@name, @category)";
                command.Parameters.Add("name", SqlDbType.NVarChar).Value = productModel.name;
                command.Parameters.Add("category", SqlDbType.NVarChar).Value = productModel.categority;
                command.ExecuteNonQuery();
            }
        }

        public void delete(ProductModel id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Productos WHERE Producto_id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Productos
                                      SET Producto_name =@name,
                                      Producto_category = @category
                                      WHERE Producto_id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.name;
                command.Parameters.Add("@category", SqlDbType.NVarChar).Value = productModel.categority;
                command.Parameters.Add("@id", SqlDbType.Int).Value = productModel.id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var productModeList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {

                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Productos ORDER BY Producto_id DESC"; ;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.id = (int)reader["Producto_id"];
                        productModel.name = reader["Producto_name"].ToString();
                        productModel.precio = (int)reader["Producto_precio"];
                        productModel.categority = reader["Producto_category"].ToString();
                        productModeList.Add(productModel);

                    }
                }
            }
            return productModeList;
        }

        public IEnumerable<ProductModel> GetByValue(string value)
        {
            var productModeList = new List<ProductModel>();
            int productModeId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productModeName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Productos 
                                      WHERE Producto_id=@id AND Producto_name LIKE @name+ '%' 
                                      ORDER BY Producto_id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productModeId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModeName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.id = (int)reader["Producto_id"];
                        productModel.name = reader["Producto_name"].ToString();
                        productModel.precio = (int)reader["Producto_precio"];
                        productModel.categority = reader["Producto_category"].ToString();
                        productModeList.Add(productModel);
                    }
                }
            }

            return productModeList;
        }
    }
}
