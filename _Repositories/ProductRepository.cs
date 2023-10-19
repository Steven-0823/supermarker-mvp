using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket_mvp1.Models;
using System.Data;

namespace Supermarket_mvp1._Repositories
{
    internal class ProductRepository : BaseRepository, IProductRepository


    {
        public ProductRepository(string connetionString)
        {
            this.connetionString = connetionString;
        }
        public void add(ProductModel productModel)
        {
            throw new NotImplementedException();
        }

        public void delete(ProductModel productModel)
        {
            throw new NotImplementedException();
        }

        public void Edit(ProductModel productModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var productModeList = new List<ProductModel>();
            using (var connection = new SqlConnection(connetionString))
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
            using (var connection = new SqlConnection(connetionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Productos WHERE Producto_id=@id AND Producto_name LIKE @name+ ORDER BY Producto_id DESC";
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
