using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32.SafeHandles;

namespace RevisionLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BookDetails> BookDetailsList = new List<BookDetails>();
            List<BorrowerData> borrowerDataList = new List<BorrowerData>();
            Menu(BookDetailsList, borrowerDataList);

            
            
        }
        static void Menu(List<BookDetails> BookDetailsList, List<BorrowerData> borrowerDataList)
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("1- Add Book Detils :\n 2- Add Borrower Details \n 3- View Book Details \n 4- View Borrower Details \n 5- Update Borrower Details \n 6- Update Book Details \n 7- Delete Book Details \n 8- Book Copies Available of The Book ");
                Console.WriteLine();
                int result = int.Parse(Console.ReadLine());
                if (result == 1)
                {
                    AddBookDetails(BookDetailsList);
                }
                else if (result == 2)
                {
                    AddBorrowerData(borrowerDataList);
                }
                else if (result == 3)
                {
                    ShowBookDetails(BookDetailsList);
                }
                else if (result == 4)
                {
                    ShowBorrowerDetails(borrowerDataList);
                }
                else if (result == 5)
                {
                    UpdateBorrowerDate(borrowerDataList);
                }
                else if (result == 6)
                {
                    UpdateBookDetails(BookDetailsList);
                }
                else if (result == 7)
                {
                    DeleteBookDetails(BookDetailsList);
                }
                else if (result == 8)
                {
                    BorrowerBookDetails(borrowerDataList, BookDetailsList);
                }
                else
                {
                    Console.WriteLine(" Invalid Input");
                }


            }
        }
        static void AddBookDetails(List<BookDetails> BookDetailsList)
        {
            Console.WriteLine(" Enter Book Name : ");
            string BookName= Console.ReadLine();

            Console.WriteLine(" Enter ISBN Number : ");
            int Isbn = int.Parse(Console.ReadLine());

            Console.WriteLine(" Enter Author Name : ");
            string AuthorName = Console.ReadLine();

            Console.WriteLine(" Enter Enter Number of Copies : ");
            int NumberofCopies = int.Parse(Console.ReadLine());

            Console.WriteLine(" Enter Publisher Name : ");
            string PublisherName = Console.ReadLine();

            BookDetails bookdetails1=new BookDetails(BookName,Isbn,AuthorName,NumberofCopies,PublisherName);
            BookDetailsList.Add(bookdetails1);
            Console.WriteLine(" Recorded Sucessfully");
          


        }
        static void AddBorrowerData(List<BorrowerData> borrowerDataList)
        {
            Console.WriteLine(" Enter Student Name : ");
            string StudentName = Console.ReadLine();

            Console.WriteLine(" Enter ID Number : ");
            int ID = int.Parse(Console.ReadLine());

            Console.WriteLine(" Enter Faculty Name : ");
            string FacultyName = Console.ReadLine();

            Console.WriteLine(" Enter Book Borrowng Date (yyyy-mm-dd) : ");
            string BorrowDateString = Console.ReadLine();

            if(DateOnly.TryParse(BorrowDateString,out DateOnly BorrowDate))
            {
                Console.WriteLine(" Recorded Sucessfully");
                BorrowerData borrowdata1 = new BorrowerData(StudentName, ID, FacultyName, BorrowDate);

                borrowerDataList.Add(borrowdata1);

            }
            else
            {
                Console.WriteLine("Invalid date");
            }
            

        }
        static void ShowBookDetails(List<BookDetails> BookDetailsList)
        {
            if(BookDetailsList.Count > 0)
            {
                foreach(BookDetails bookdetails in BookDetailsList)
                {
                    Console.Write($" {bookdetails.ISBNno}  {bookdetails.BookName}  {bookdetails.NoOfCopies}");
                }

            }
            else
            {
                Console.WriteLine(" There are no Records");
            }
        }
        static void ShowBorrowerDetails(List<BorrowerData> borrowerDataList)
        {
            if(borrowerDataList.Count > 0)
            {
                foreach(BorrowerData borrower in borrowerDataList)
                {
                    Console.Write($"{borrower.ID}  {borrower.StudentName}  {borrower.BorrowDate}  {borrower.DueDate}  {borrower.ExcessCost}");
                }
            }
            else
            {
                Console.WriteLine(" No Borrower Details");
            }

        }
        static void UpdateBorrowerDate(List<BorrowerData> borrowerDataList)
        {
            Console.WriteLine("Enter Student ID ");
            int studentID=int.Parse(Console.ReadLine());

            var updatestudent=borrowerDataList.Find(x => x.ID==studentID);
            if( updatestudent != null )
            {
                DateOnly currentDate=DateOnly.FromDateTime(DateTime.Today);
                if(updatestudent.DueDate > currentDate )
                {
                    Console.WriteLine(" Enter the New Borrowing Date (yyyy-mm-dd) : ");
                    string NewBorrowingDatestring=Console.ReadLine();
                    if(DateOnly.TryParse(NewBorrowingDatestring, out DateOnly NewBorrowingDate)) {
                        updatestudent.BorrowDate = NewBorrowingDate;
                        updatestudent.DueDate= NewBorrowingDate.AddDays(14);
                        updatestudent.ExcessCost = updatestudent.ExcessCostCal();
                        Console.WriteLine(" Borrowing date is Updated");

                        /* when Borrowing date is changed others also should be changed */
                    }
                    else
                    {
                        Console.WriteLine("In valid date format : ");
                    }
                }
                else
                {
                    Console.WriteLine(" Your Due Date has already passed ");
                }
            }
            else
            {
                Console.WriteLine(" Invalid Student Id !!!");
            }
        }
        static void UpdateBookDetails(List<BookDetails> BookDetailsList)
        {
            Console.WriteLine(" Enter The ISBNNO to update : ");
            int ISBNOtoUpdate= int.Parse(Console.ReadLine());
            var UpdateISBN=BookDetailsList.Find(a=>a.ISBNno==ISBNOtoUpdate);
            if( UpdateISBN != null )
            {
                Console.WriteLine("Enter New Book Name ");
                UpdateISBN.BookName = Console.ReadLine();

                Console.WriteLine("Enter New Author Name ");
                UpdateISBN.AuthorName = Console.ReadLine();

                Console.WriteLine("Enter New Number of Copies Name ");
                UpdateISBN.NoOfCopies = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter New Publisher Name ");
                UpdateISBN.PublisherName = Console.ReadLine();

                Console.WriteLine(" The Data have successfully Updated");
            }
            else
            {
                Console.WriteLine(" The Book ISBNo doesnt exsist");
            }
                
        }static void DeleteBookDetails(List<BookDetails> BookDetailsList)
        {
            Console.WriteLine(" Enter The ISBNNO to delete : ");
            int ISBNOtoDelete = int.Parse(Console.ReadLine());
            var DeleteISBN = BookDetailsList.Find(a => a.ISBNno == ISBNOtoDelete);
            if( DeleteISBN != null )
            {
                BookDetailsList.Remove(DeleteISBN);
                Console.WriteLine(" Records of the Book has Successfully Removed");
            }
            else
            {
                Console.WriteLine("In valid ISBNO");
            }
        }
        static void BorrowerBookDetails(List<BorrowerData> borrowerDataList, List<BookDetails> BookDetailsList)
        {
            Console.WriteLine(" Enter the Student ID : ");
            int studentID=int.Parse(Console.ReadLine());
            var BorrowerID=borrowerDataList.Find(a=>a.ID == studentID);
            if( BorrowerID != null )
            {
                if (BorrowerID.BorrowedBooks.Count > 2)   /*methana*/
                {
                    Console.WriteLine(" You Cant Borrow more Books");
                    return;
                }
                else
                {
                    Console.WriteLine(" Enter the ISBNO of the Book : ");
                    int BorrowerBookISBN = int.Parse((Console.ReadLine()));
                    var BookISBN = BookDetailsList.Find(a => a.ISBNno == BorrowerBookISBN);
                    if( BookISBN != null )
                    {
                        if (BookISBN.NoOfCopies <= 0)
                        {
                            Console.WriteLine(" No Copes of the Books are available");
                        }
                        else
                        {
                            BorrowerID.BorrowedBooks.Add(BookISBN);
                            BookISBN.NoOfCopies--;
                            Console.WriteLine("Book borrowed successfully.");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Book Not Found");
                    }
                }

            }
            else
            {
                Console.WriteLine("Invalid Student ID : ");
            }
        }

    }
}
