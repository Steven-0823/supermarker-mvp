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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(CategoryModel categoryModel)
        {
            throw new NotImplementedException();
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
            string catrgoryName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Category
                                        WHEREcategory_Id=@id or category_Observation LIKE @Observation+ '%'
                                        ORDER By Pay_Mode_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = catrgoryId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = catrgoryName;
                using (var reader = command.ExecuteReader())
                {
                    var categoryModel = new CategoryModel();
                    categoryModel.Id = (int)reader["category_Name"];
                    categoryModel.observation = reader["category_Observation"].ToString();
                    catrgoryList.Add(categoryModel);
                }

            }
            return catrgoryList;
        }
    }
}
