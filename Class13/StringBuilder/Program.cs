// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

string location = "Dhaka";
location += ", Bangladesh";
Console.WriteLine(location);

StringBuilder stringBuilder = new StringBuilder(location);
stringBuilder.Append(", Asia");
Console.WriteLine(stringBuilder);

stringBuilder.Replace('a', 'A');
Console.WriteLine(stringBuilder);

stringBuilder.Insert(5, '*');
Console.WriteLine(stringBuilder);

stringBuilder[0] = '#';
Console.WriteLine(stringBuilder);