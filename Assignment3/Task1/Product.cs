using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }

        public Product() : this("Potato", 10, "Chips", "Yellow")
        {
            
        }

        public Product(string name, double price) : this()
        {
            Name = name;
            Price = price;
        }

         

        public Product(string name, double price, string description, string color)
        {
            Name = name;
            Price = price;
            Description = description;
            Color = color;

            Console.WriteLine("2nd constructor");
        }



    }
}
