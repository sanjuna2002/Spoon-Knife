using System.Text.Json;
namespace Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BookDetails> BookDetailsList = new List<BookDetails>();
            List<BorrowerData> BorrowerDataList = new List<BorrowerData>();



        }
        static string read(string message)
        {
            Console.WriteLine(message);
            string UserInput = Console.ReadLine();
            return UserInput;
        }
        static int readInt(string message)
        {
            Console.WriteLine(message);
            int UserInput = int.Parse(Console.ReadLine());
            return UserInput;
        }
        static void CreateBook(List<BookDetails> BookDetailsList)
        {
            string BookName = read("Enter the Book Name : ");
            int BookISBN = readInt("Enter the Book ISBNNo : ");
            string AuthorName = read("Enter the Author Name : ");
            int NumberOfCopies = readInt("Enter the Number of Copies : ");
            string PublisherName = read("Enter the Publisher Name : ");

            BookDetails Book1=new BookDetails(BookName,BookISBN,AuthorName,NumberOfCopies, PublisherName);
            BookDetailsList.Add(Book1);
            Console.WriteLine(" Book is entered");
        }
        static void CreateBorrower(List<BorrowerData> BorrowerDataList)
        {
            string StudentName = read("Enter the Student Name : ");
            int studentID= readInt("Enter the student ID : ");
            string faculty = read("Enter the faculty Name : ");
            string BorrowDateString = read(" Enter the Date (yyyy-mm-dd) : ");
            if (DateOnly.TryParse(BorrowDateString, out DateOnly BorrowDate)) 
            {
                BorrowerData borrower=new BorrowerData(StudentName,studentID,faculty,BorrowDate);
                BorrowerDataList.Add(borrower);
            }
            else {
                Console.WriteLine(" Invalid Date");
            }

        }
        static void UpdateBorrowData(List<BorrowerData> BorrowerDataList)
        {
            int UpdateStudentID = readInt(" Enter the student ID");
            var Ustudentid=BorrowerDataList.Find(a=>a.ID==UpdateStudentID);
            if(Ustudentid!=null)
            {
                DateOnly currentDate = DateOnly.FromDateTime(DateTime.Today);
                if (Ustudentid.DueDate > currentDate)
                {
                    Console.WriteLine("Enter the New Borrowing Date :  ");
                    string NewBorrowingDateString=Console.ReadLine();
                    if (DateOnly.TryParse(NewBorrowingDateString, out DateOnly NewBorrowingDate))
                    {
                        Ustudentid.BorrowingDate = NewBorrowingDate;
                        Ustudentid.DueDate = Ustudentid.CalculateDueDate();
                        Ustudentid.Fine=Ustudentid.CalculateFine();
                    }
                    else
                    {
                        Console.WriteLine(" Invalid Date Formaat");
                    }
                    
                }
                else
                {
                    Console.WriteLine(" The Due Date has been Passed");
                }
            }
            else
            {
                Console.WriteLine(" Invaild Student ID");
            }
        }
        static void ViewBooks(List<BookDetails> BookDetailsList)
        {
            if (BookDetailsList.Count > 0)
            {
                foreach (BookDetails book in BookDetailsList)
                {
                    Console.WriteLine($" Book Id {book.ISBNNo}  Book Name: {book.BookName} Number of Copies{book.NoOfCopies} ");
                }
            } else { Console.WriteLine(" there are no Books"); }
        }
        static void UpDateBooks(List<BookDetails> BookDetailsList)
        {
            int BookID = readInt(" Enter the ISBNo : ");
            var UpdateBookID=BookDetailsList.Find(a=>a.ISBNNo == BookID);
            if(UpdateBookID != null)
            {
                UpdateBookID.BookName = read("Enter the Neew Book Name : ");
                UpdateBookID.AuthorName = read(" Enter the New Author Name : ");
                UpdateBookID.NoOfCopies = readInt(" Enter the Number of Copies : ");

            }
            else
            {
                Console.WriteLine(" Invalid ISBNO");
            }
        }
        static void DeleteBookRecords(List<BookDetails> BookDetailsList)
        {
            int BookID = readInt(" Enter the ISBNo : ");
            var DeleteBookID = BookDetailsList.Find(a => a.ISBNNo == BookID);
            if(DeleteBookID != null)
            {
                BookDetailsList.Remove(DeleteBookID);
                Console.WriteLine(" The Book Is Removed successfully");
            }
            else
            {
                Console.WriteLine(" The Book doesnt Exsist ");
            }

        }
        static void NewBorrowings(List<BookDetails> BookDetailsList, List<BorrowerData> BorrowerDataList) {
            int BorrowerID = readInt(" Enter the Borrower ID to update");
            var NewBorrowingID=BorrowerDataList.Find(a=>a.ID== BorrowerID);
            if (NewBorrowingID != null)
            {
                if (NewBorrowingID.BooksBorrowed.Count > 2)
                {
                    int BookBorrowed = readInt(" Enter the Book ISBNo to Borrow : ");
                    var BookToBorrow = BookDetailsList.Find(a => a.ISBNNo == BookBorrowed);
                    if (BookToBorrow != null)
                    {
                        if (BookToBorrow.NoOfCopies > 0)
                        {
                            BookToBorrow.NoOfCopies--;
                            NewBorrowingID.BooksBorrowed.Add(BookToBorrow);
                            Console.WriteLine()

                        }
                    }
                    else
                    {
                        Console.WriteLine(" Book doesntt Exsist");
                    }

                }
                else
                {
                    Console.WriteLine("You Cant Borrow new books");
                }
            }
            else
            {
                Console.WriteLine(" invalid Borrower : ");
            }


        }


    }
}