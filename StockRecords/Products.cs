using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockRecords
{
    internal class Products
    {
        private static int ProductBase = 1000;
        public int ProductCode { get;  }
        public String ProductName { get; set; }
        public int Units { get; set; }
        public int Price { get; set; }
        public int Balance { get; set; }
        public DateOnly PurchaseDate { get; set; }
        public DateOnly DueDate { get; set; }

        public Products( string productName, int units, int price, DateOnly purchaseDate)
        {
            ProductCode = productCodeGenerator( ProductBase);
            ProductName = productName;
            Units = units;
            Price = price;
            Balance =   BalanceCal();
            PurchaseDate = purchaseDate;
            DueDate = DueDateCal();
        }

        public int productCodeGenerator(int productCode)
        {
            
            productCode= productCode + 1;
            return productCode;

        }
        public DateOnly DueDateCal()
        {
            DateOnly dueDate = PurchaseDate.AddDays(14);
            return dueDate;
        }
        public int BalanceCal()
        {
            return Units * Price;
        }
    }

}
