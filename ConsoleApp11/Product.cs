using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Product
    {
        private static int productidbase = 1000;
        public int ProductID { get;  }
        public string ProductName { get; set; }
        public int NoOfUnits { get; set; }
        public double PricePerUnit { get; set; }
        public double Balance { get; set; }
        public DateOnly PurchaseDate { get; set; }
        public DateOnly DueDate { get;  }
        public int ExcessCost { get; set; }

        public Product( string productName, int noOfUnits, double pricePerUnit,  DateOnly purchaseDate)
        {
            ProductID = ProductIDCal();
            ProductName = productName;
            NoOfUnits = noOfUnits;
            PricePerUnit = pricePerUnit;
            Balance = CalculateBal( pricePerUnit, noOfUnits);
            PurchaseDate = purchaseDate;
            DueDate = CalDuedate(  purchaseDate);
            ExcessCost = CalExcessCost();

        }



        public int ProductIDCal( )
        {
            productidbase=productidbase+1;
            return productidbase;


        }
        public DateOnly CalDuedate( DateOnly submitdate)
        {
            return PurchaseDate.AddDays(14);
        }
        public double CalculateBal( double price, double NoOfUnits)
        {
            return price*NoOfUnits;
        }
        public int CalExcessCost()
        {
            DateOnly currentDate= DateOnly.FromDateTime(DateTime.Now);
            if(DueDate<currentDate)
            {
                int excessDays= currentDate.DayNumber- DueDate.DayNumber;
                int excessCost= excessDays*NoOfUnits * 100;
                return excessCost;

            }
            else
            {
                int excessCost=0;
                return excessCost;
            }
        }
        

        
    }
}
