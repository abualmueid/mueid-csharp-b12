/*
// See https://aka.ms/new-console-template for more information
using ADODotNet;

string connectionString = @"Server=DESKTOP-SJFJ7LE\SQLEXPRESS01;Database=CSharpB12;Trusted_Connection=True";
DataUtility datautility = new DataUtility(connectionString);

string commandText = "insert into Courses(Title, Fees, ClassStartDate, IsOpen, CourseCode) values('Node.js', 6000, '10-1-2023', 1, '1CC7D510-8130-4248-9947-BA2B3083B9EB')";
//datautility.InsertData(commandText);

string deleteCommand = "delete from Courses where id=4";
// datautility.ExecuteQuery(deleteCommand);

string query = "select * from Courses";
//datautility.ExecuteQuery2(query);

/*
string getQuery = "select * from Courses";

List<Dictionary<string, object>> result = datautility.DisplayData(getQuery);
foreach (var dict in result)
{
    foreach (var item in dict)
    {
        Console.Write($"{item.Key}:{item.Value} ");
    }
    Console.WriteLine();
}
*/

// --------------------------------------------------------------------

using ADODotNet;
using System.Collections.Generic;
using System.Data.SqlClient;

Console.WriteLine("Hello World");

string connectionString = @"Server=DESKTOP-SJFJ7LE\SQLEXPRESS01;Database=CSharpB12;Trusted_Connection=True";
DataUtility datautility = new DataUtility(connectionString);

//  ----------- Insert Data ----------- //

Console.Write("Enter Title: "); string title = Console.ReadLine();
Console.Write("Enter Fees: "); double fees = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Class Start Date: "); DateTime classStartDate = Convert.ToDateTime(Console.ReadLine());
Console.Write("Enter IsOpen: "); bool isOpen = Convert.ToBoolean(Console.ReadLine());
                                     Guid courseCode = Guid.NewGuid();

List<SqlParameter> sqlParameters = new List<SqlParameter>();
sqlParameters.Add(new SqlParameter("Title", title));
sqlParameters.Add(new SqlParameter("Fees", fees));
sqlParameters.Add(new SqlParameter("ClassStartDate", classStartDate));
sqlParameters.Add(new SqlParameter("IsOpen", isOpen));
sqlParameters.Add(new SqlParameter("CourseCode", courseCode));

string commandText = "insert into Courses(Title, Fees, ClassStartDate, IsOpen, CourseCode) values(@title, @fees, @classStartDate, @isOpen, @courseCode)";
datautility.InsertData(commandText, sqlParameters);

//  ----------- Display Data ----------- //

string query = "select * from Courses";
// string query2 = "select * from Courses where fees=@fees";
/*List<Dictionary<string, object>> result = datautility.DisplayData(query, sqlParameters);
foreach (var dict in result)
{
    foreach (var item in dict)
    {
        Console.Write($"{item.Key}:{item.Value} ");
    }
    Console.WriteLine();
}*/

