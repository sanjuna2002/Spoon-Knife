using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class RenterData
    {
        private static int RentalIDBase = 100;
        public string RenterName { get; set; }
        public int RenterID { get; set; }
        public string Department { get; set; }
        public DateOnly PurchaseDate { get; set; }
        public DateOnly DueDate { get; set; }
        public int Excesscost { get; set; }

        public RenterData(string renterName, string department,DateOnly purchasedate)
        {
            RenterName = renterName;
            RenterID = CalculateRentalID();
            Department = department;
            PurchaseDate = purchasedate;
            DueDate = DueDateCal();
            Excesscost=ExcessCostCal();
        }
        public int CalculateRentalID()
        {
            return RentalIDBase++;
        }
        public DateOnly DueDateCal()
        {
            return PurchaseDate.AddDays(7);
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Today);

        }
        public int ExcessCostCal()
        {
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Today);
            if (DueDate > currentDate)
            {
                int Excessdays=(DueDate.DayNumber-currentDate.DayNumber);
                return Excessdays*1;
            }
            else
            {
                return 0;
            }
        }
    }
}
