// See https://aka.ms/new-console-template for more information
using PartialClass;

Console.WriteLine("Hello, World!");

Form form = new Form();
form.SetName("rasel");
Console.WriteLine(form.GetName());
form.Reset();
Console.WriteLine(form.GetName());
