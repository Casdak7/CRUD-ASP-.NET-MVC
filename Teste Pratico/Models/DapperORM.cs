using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Teste_Pratico.Models
{
    public static class DapperORM
    {
        private static string connectionString = "server=localhost;user=root;password=root;database=db_teste_pratico";

        public static void ExecuteWithoutReturn(string procedureName, DynamicParameters param)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();
                mySqlConnection.Execute(procedureName, param, commandType: CommandType.StoredProcedure);
            }
        }

        // DapperORM.ExecuteReturnScalar<int>(_,_)
        public static T ExecuteReturnScalar<T>(string procedureName, DynamicParameters param)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();
                return (T) Convert.ChangeType(mySqlConnection.ExecuteScalar(procedureName, param, commandType: CommandType.StoredProcedure), typeof(T));
            }
        }

        // DapperORM.ReturnList<Produto>(_,_) <=   IEnumerable<Employee>
        public static IEnumerable<T> ReturnList<T>(string procedureName, DynamicParameters param = null)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();
                return mySqlConnection.Query<T>(procedureName, param, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
