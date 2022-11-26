// See https://aka.ms/new-console-template for more information
using NullableType;

Console.WriteLine("Hello, World!");

int? x = null;

x = 5;

if(x.HasValue)
    Console.WriteLine(x.Value);
else
    Console.WriteLine("Not assigned");

Person p = GetPerson("mueid");
p?.Talk("Hello"); // p can be nullable. Checking if condition 

Person GetPerson(string name)
{
    if (name == "mueid")
        return new Person() { Name = name };
    else
        return null; // null value return
}

// Ternery Operator

// p.Name = null;
string name = p?.Name ?? "Null"; // checking condition and assigning values
Console.WriteLine(name);

Person p2 = null;
p2 ??= p; // p2 null hole assign hobe
Console.WriteLine(p2.Name);