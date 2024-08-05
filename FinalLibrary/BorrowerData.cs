using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLibrary
{
    internal class BorrowerData
    {
        public string StudentName { get; set; }
        public int ID { get; set; }
        public string Faculty { get; set; }
        public DateOnly BorrowDate { get; set; }
        public DateOnly DueDate { get; set; }
        public int ExcessCost { get; set; }

        public BorrowerData(string studentName, int iD, string faculty, DateOnly borrowDate)
        {
            StudentName = studentName;
            ID = iD;
            Faculty = faculty;
            BorrowDate = borrowDate;
            DueDate = CalDueDate();
            ExcessCost = CalExcessCost();
        }
        public DateOnly CalDueDate()
        {
            return BorrowDate.AddDays(14);
        }
        public int CalExcessCost()
        {
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Today);
            if(DueDate>currentDate)
            {
                int ExcessCost=(DueDate.DayNumber-currentDate.DayNumber)*100;
                return ExcessCost;
            }
            else
            {
                return 0;
            }
        }
    }
}
