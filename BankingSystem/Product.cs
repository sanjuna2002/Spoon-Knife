using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public double VAT { get; set; }

        public Product(int productID, string category, double price)
        {
            ProductID = productID;
            Category = category;
            Price = price;
            VAT = VatCal();
        }
        public double VatCal()
        {
            if (Price> 0 && Price<=100) {
                double VatAmount = Price *0.1 ;
                return VatAmount;
                
            }
            else if(Price>100 && Price<=200) {
                double VatAmount = Price * 0.2;
                return VatAmount;

            }
            else
            {
                double VatAmount = Price * 0.3;
                return VatAmount;
            }
        }

    }
    
   
}
