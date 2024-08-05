using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Products
    {
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public string Description { get; set; }

        public Products(string name, int unitPrice, string description)
        {
            Name = name;
            UnitPrice = unitPrice;
            Description = description;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Unit Price: {UnitPrice}, Description: {Description}";
        }


    }
}
