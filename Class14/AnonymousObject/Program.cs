// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

object point = new { x = 5, y = 6, z = 7 };
dynamic point2 = new { x = 5, y = 6, z = 7 };
Console.WriteLine(point2.x);