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
        public void InsertData()
        {
            //string connectionString = @"Server=DESKTOP-SJFJ7LE\SQLEXPRESS01;Database=CSharpB12;User Id=DESKTOP-SJFJ7LE\Abu Al Mueid;Password=;";
            string connectionString = @"Server=DESKTOP-SJFJ7LE\SQLEXPRESS01;Database=CSharpB12;Trusted_Connection=True";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = connection.CreateCommand();
            command.Connection = connection;

            //command.CommandText = "insert into Courses(Title, Fees, ClassStartDate, IsOpen, CourseCode) values('Node.js', 6000, '10-1-2023', 1, '1CC7D510-8130-4248-9947-BA2B3083B9EB')";
            string commandText = "insert into Courses(Title, Fees, ClassStartDate, IsOpen, CourseCode) values('Node.js', 6000, '10-1-2023', 1, '1CC7D510-8130-4248-9947-BA2B3083B9EB')";
            command.CommandText = commandText;

            

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            command.ExecuteNonQuery();
            connection.Close();
            command.Dispose();
        }


    }
}
