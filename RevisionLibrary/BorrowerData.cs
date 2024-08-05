using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionLibrary
{
    internal class BorrowerData
    {
        public string StudentName { get; set; }
        public int ID { get; set; }
        public string Faculty { get; set; }
        public DateOnly BorrowDate { get; set; }
        public DateOnly DueDate { get; set; }
        public int ExcessCost { get; set; }
        public List<BookDetails> BorrowedBooks { get; set; } /* Methana */

        public BorrowerData(string studentName, int iD, string faculty, DateOnly borrowDate)
        {
            StudentName = studentName;
            ID = iD;
            Faculty = faculty;
            BorrowDate = borrowDate;
            DueDate = DueDateCal(BorrowDate);
            ExcessCost = ExcessCostCal();
            BorrowedBooks = new List<BookDetails>();
        }
        public DateOnly DueDateCal(DateOnly BorrowingDate)
        {
            return BorrowingDate.AddDays(14);
        }
        public int ExcessCostCal()
        {
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Today);
            int excessDays= currentDate.DayNumber-DueDate.DayNumber;
            if(excessDays > 0)
            {
                return excessDays* 100;
            }
            else
            {
                return 0;
            }

        }
    }
}
