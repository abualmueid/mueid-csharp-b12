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

// ------------------------------------------------------------- //


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