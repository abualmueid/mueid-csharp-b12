// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

DateTime dateTime = new DateTime(2022, 11, 27);
Console.WriteLine(dateTime);

dateTime = dateTime.AddMonths(2);
Console.WriteLine(dateTime);

DateTime dateTime2 = DateTime.UtcNow;
Console.WriteLine(dateTime2);

TimeSpan timeSpan = dateTime2.Subtract(dateTime);
Console.WriteLine(timeSpan.TotalDays);