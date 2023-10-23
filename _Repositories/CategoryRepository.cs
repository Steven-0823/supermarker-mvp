using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket_mvp.Models;
using System.Data;
using Supermarket_mvp._Repositories;
using Supermarket_mvp1.Models;

namespace Supermarket_mvp1._Repositories
{
    internal class CategoryRepository : BaseRepository, ICategoryRepository
    {

        public CategoryRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(CategoryModel categoryModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Category VALUES (@observation)";
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = categoryModel.observation;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Category WHERE category_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CategoryModel categoryModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Category
                                        SET 
                                        category_Observation = @observation
                                        WHERE category_Id = @id";
                
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = categoryModel.observation;
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoryModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CategoryModel> GetAll()
        {
            var catrgoryList = new List<CategoryModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Category ORDER BY category_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoryModel = new CategoryModel();
                        categoryModel.Id = (int)reader["category_Id"];
                        categoryModel.observation = reader["category_Observation"].ToString();
                        catrgoryList.Add(categoryModel);
                    }
                }
            }
            return catrgoryList;
        }

        public IEnumerable<CategoryModel> GetByValue(string value)
        {
            var catrgoryList = new List<CategoryModel>();
            int catrgoryId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string catrgoryObservation = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Category
                                        WHERE category_Id=@id or category_Observation LIKE @observation+ '%'
                                        ORDER By category_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = catrgoryId;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = catrgoryObservation;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {


                        var categoryModel = new CategoryModel();
                        categoryModel.Id = (int)reader["category_Id"];
                        categoryModel.observation = reader["category_Observation"].ToString();
                        catrgoryList.Add(categoryModel);


                    }


                }

            }
            return catrgoryList;
        }
        
    }

}
