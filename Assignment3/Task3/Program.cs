using System.Reflection.Metadata;
using Task3;

DatabaseConnection databaseConnection = new DatabaseConnection("Connected");
Console.WriteLine(databaseConnection.connectionName);