using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class BorrowerData
    {
        
        public string StudenName { get; set; }
        public int ID { get; set; }
        public string Faculty { get; set; }
        public DateOnly BorrowingDate { get; set; }
        public DateOnly DueDate { get; set; }
        public int Fine { get; set; }
        public List<BookDetails> BooksBorrowed { get; set; }

        public BorrowerData(string studenName, int iD, string faculty, DateOnly borrowingDate)
        {
            StudenName = studenName;
            ID = iD;
            Faculty = faculty;
            BorrowingDate = borrowingDate;
            DueDate = CalculateDueDate();
            Fine = CalculateFine();
            BooksBorrowed= new List<BookDetails>();
        }
        public DateOnly CalculateDueDate()
        {
            return BorrowingDate.AddDays(14);
        }
        public int CalculateFine()
        {
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Today);
            if(DueDate>currentDate)
            {
                int fine=(DueDate.DayNumber-currentDate.DayNumber)*100;
                return fine;
            }
            else
            {
                return 0;
            }
        }

    }
}
