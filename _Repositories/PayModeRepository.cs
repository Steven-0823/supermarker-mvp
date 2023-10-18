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
    internal class PayModeRepository : BaseRepository, IPayModeRepository
    {

        public PayModeRepository(string connetionString)
        {
            this.connetionString = connetionString;
        }
        public void add(PayModeModel payModeModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void edit(PayModeModel payModeModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PayModeModel> GetAll()
        {
            var payModeList = new List<PayModeModel>();
            using (var connection = new SqlConnection(connetionString))
            using (var command = new SqlCommand())
            {
                
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM PayMode ORDER BY Pay_Mode_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var payModeModel = new PayModeModel();
                        payModeModel.id = (int)reader["Pay_Mode_Id"];
                        payModeModel.name = reader["Pay_Mode_Name"].ToString();//hay un error 
                        payModeModel.observation = reader["Pay_Mode_Observation"].ToString();
                        payModeList.Add(payModeModel);

                    }
                }
            }
            return payModeList;
        }

        public IEnumerable<PayModeModel> GetByValue(string value)
        {
            var payModeList = new List<PayModeModel>();
            int payModeId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string payModeName = value;
            using (var connection = new SqlConnection(connetionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM PayMode WHERE Pay_Mode_Id=@id AND Pay_Mode_Name LIKE @name+ ORDER BY Pay_Mode_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = payModeId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = payModeName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var payModeModel = new PayModeModel();
                        payModeModel.id = (int)reader["Pay_Mode_Id"];
                        payModeModel.name = reader["Pay Mode Name"].ToString();
                        payModeModel.observation = reader["Pay_Mode_Observation"].ToString();
                        payModeList.Add(payModeModel);
                    }
                }
            }

            return payModeList;
        }



    }
}


