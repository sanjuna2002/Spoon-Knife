using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public double Vat { get; set; }

        public Product(int productID, string category, double price)
        {
            ProductID = productID;
            Category = category;
            Price = price;
            Vat = VatCal();
        }
        public double VatCal()
        {
            if (Price > 0 && Price <= 100)
            {
                return Price * 0.10;
            }
            else if(Price > 100 && Vat <= 200) {
                return Price * 0.2;
            }
            else
            {
                return Price*0.3;
            }

        }



    }
}
