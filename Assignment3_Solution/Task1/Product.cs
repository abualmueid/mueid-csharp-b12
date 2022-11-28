using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }

        public Product()
            : this(string.Empty)
        {

        }

        public Product(string name) 
            : this(name, 0, string.Empty, string.Empty)
        {

        }

        public Product(string name, double price, string description, string color)
        {
            Name = name;
            Price = price;
            Description = description;
            Color = color;
        }
    }
}
