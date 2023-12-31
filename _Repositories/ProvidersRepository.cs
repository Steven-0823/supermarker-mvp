﻿using Microsoft.Data.SqlClient;
using Supermarket_mvp._Repositories;
using Supermarket_mvp.Models;
using Supermarket_mvp1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp1._Repositories
{
    internal class ProvidersRepository : BaseRepository, IProvidersRepository
    {
        public ProvidersRepository(string connetionString)
        {
            this.connectionString = connetionString;
        }
        public void Add(ProvidersModel providersModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Providers VALUES (@name, @observation)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providersModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = providersModel.Observation;
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
                command.CommandText = "DELETE FROM Providers WHERE providers_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProvidersModel providersMode)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Providers
                                        SET providers_Name =@name,
                                        providers_Observation = @observation
                                        WHERE providers_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providersMode.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = providersMode.Observation;
                command.Parameters.Add("@id", SqlDbType.Int).Value = providersMode.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProvidersModel> GetAll()
        {
            var providersModeList = new List<ProvidersModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {

                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Providers ORDER BY providers_Id DESC"; ;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providersModel = new ProvidersModel();
                        providersModel.Id = (int)reader["providers_Id"];
                        providersModel.Name = reader["providers_Name"].ToString();
                        providersModel.Observation = reader["providers_Observation"].ToString();
                        providersModeList.Add(providersModel);

                    }
                }
            }
            return providersModeList;
        }

        public IEnumerable<ProvidersModel> GetByValue(string value)
        {
            var providersModeList = new List<ProvidersModel>();
            int providersId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string providersName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Providers
                                        WHERE providers_Id=@id or providers_Name LIKE @name+ '%'
                                        ORDER By providers_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = providersId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providersName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providersModel = new ProvidersModel();
                        providersModel.Id = (int)reader["providers_Id"];
                        providersModel.Name = reader["providers_Name"].ToString();
                        providersModel.Observation = reader["providers_Observation"].ToString();
                        providersModeList.Add(providersModel);
                    }
                }

            }
            return providersModeList;
        }
    }
}
