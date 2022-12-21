using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODotNet
{
    public class DataUtility
    {
        private readonly string _connectionString;

        public DataUtility(string connectionString)
        {
            _connectionString = connectionString;
        }

        // ------------- Insert Operation-------------- //
        public void InsertData(string commandText, IList<SqlParameter> parameters)
        {
            using SqlCommand command = GetCommand(commandText, parameters);

            command.ExecuteNonQuery(); 
            //command.Parameters.AddRange(parameters.ToArray());

            /*
            connection.Close();
            command.Dispose();
            */
        }

        // ------------- Delete Operation --------------- //
        public void ExecuteQuery(string deleteCommand, IList<SqlParameter> parameters)
        {
            using SqlCommand command = GetCommand(deleteCommand, parameters);

            command.ExecuteNonQuery();
        }

        //---------- Display Operation (Hard Coded) ----------- //
        public void ExecuteQuery2(string commandText2, IList<SqlParameter> parameters)
        {
            using SqlCommand command = GetCommand(commandText2, parameters);

            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine($"Id: {reader[0]}, Title: {reader["Title"]}, Fees: {reader["Fees"]}");
            }
        }

        // ----------- Display Operation (Genuine Procedure) --------------- //
        public List<Dictionary<string, object>> DisplayData(string commandText, IList<SqlParameter> parameters)
        {
            using SqlCommand command = GetCommand(commandText, parameters);

            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            SqlDataReader reader = command.ExecuteReader();
            while ( reader.Read() )
            {
                Dictionary<string, object> dict = new Dictionary<string, object>();
                for(int i=0; i<reader.FieldCount; i++)
                {
                    dict.Add(reader.GetName(i), reader.GetValue(i));
                }
                result.Add(dict);
            }
            
            return result;
        }

        private SqlCommand GetCommand(string commandText, IList<SqlParameter> parameters)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = connection.CreateCommand();
            command.Connection = connection;
            command.CommandText = commandText;

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            command.Parameters.AddRange(parameters.ToArray());
            return command;
        }
    }
}
