using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyManagementSystem
{
    internal class Supplier
    {
        private static int SupplierIDBase = 1000;
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string ProductSupplied { get; set; }
        public int Units { get; set; }
        public int Price { get; set; }
        public int Balance { get; set; }
        public DateOnly PurchasedDate { get; set; }
        public DateOnly DueDate { get; set; }

        public Supplier( string supplierName, string productSupplied, int units, int price, DateOnly purchasedDate)
        {
            SupplierID = CalculateSupplierID();
            SupplierName = supplierName;
            ProductSupplied = productSupplied;
            Units = units;
            Price = price;
            Balance = CalculateBalance();
            PurchasedDate = purchasedDate;
            DueDate = DueDateCalculator();
        }
        
        public int CalculateSupplierID()
        {
            return SupplierIDBase++;

        }
        public override string ToString()
        {
            return $" Supplier ID : {SupplierID} \n Supplier Name : {SupplierName} \n Product Name : {ProductSupplied}\n Balance : {Balance} \n Due Date :{DueDate}";

        }
        public int CalculateBalance()
        {
            return Units * Price;
        }
        public DateOnly DueDateCalculator()
        {
            return PurchasedDate.AddDays(14);
        }
       

    }
}
