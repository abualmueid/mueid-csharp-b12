// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;
using Tuple;

Console.WriteLine("Hello, World!");

Person[] persons = new Person[2];
// initializing object values
// one way
Person p = new Person();
p.Id = 1;
p.Name = "mueid";
p.Age = 28;

// another way
Person p2 = new Person
{
    Id = 2,
    Name = "rasel",
    Age = 38
};

persons[0] = p;
persons[1] = p2;

Order[] orders = new Order[3];
orders[0] = new Order
{
    Id = 100,
    PersonName = "mueid",
    Price = 500
};

orders[1] = new Order
{
    Id = 200,
    PersonName = "rakib",
    Price = 1000
};

Order order3 = new Order();
order3.Id = 300;
order3.PersonName = "mueid";
order3.Price = 1500;
orders[2] = order3;

/*
Result[] results = new Result[3];
int counter = 0;
for(int i = 0; i < persons.Length; i++)
{
    for(int j = 0; j < orders.Length; j++)
    {
        if (persons[i].Name == orders[j].PersonName)
        {
            results[counter++] = new Result
            {
                Id = persons[i].Id,
                Price = orders[j].Price
            };
        }
    }
}
*/

(int id, double price)[] results = new (int id, double price)[3];
int counter = 0;
for (int i = 0; i < persons.Length; i++)
{
    for (int j = 0; j < orders.Length; j++)
    {
        if (persons[i].Name == orders[j].PersonName)
        {
            results[counter++] = (persons[i].Id, orders[j].Price);
        }
    }
}

foreach (var r in results)
    Console.WriteLine($"{r.id}, {r.price}");
    //Console.WriteLine(r.id + ", " + r.price);

