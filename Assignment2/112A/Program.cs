// See https://aka.ms/new-console-template for more information

string str1, str2;

str1 = Console.ReadLine();
str2 = Console.ReadLine();

str1 = str1.ToLower();
str2 = str2.ToLower();

Console.WriteLine(string.Compare(str1, str2));
