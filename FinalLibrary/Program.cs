namespace FinalLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BorrowerData> BorrowerDatalist = new List<BorrowerData>();
            List<BookDetails> BookDetailsList= new List<BookDetails>();
            Console.WriteLine("1- To Enter a Book \n 2- To Enter a Borrower \n 3- Update BorrowingDate");
            int result=int.Parse(Console.ReadLine());
            if(result == 1) { 
                EnterBook(BookDetailsList);
            }
            else if(result == 2)
            {
                EnterBorrower(BorrowerDatalist);
            }
            else if(result==3){
                UpdateBorrowerDate(BorrowerDatalist);

            }


           




        }
        static void EnterBook(List<BookDetails> BookDetailsList)
        {
            string BookName = read(" Enter the Book Name : ");
            int ISBNNo = readInt("Enter the ISBN number : ");
            string AuthorName = read(" Enter the Author Name : ");
            int NumberOfCopies = readInt("Enter the Number of Copies : ");
            string PublisherName = read(" Enter the Puublisher Name : ");
            BookDetails book1=new BookDetails(BookName,ISBNNo, AuthorName,NumberOfCopies, PublisherName);
            BookDetailsList.Add(book1);
            Console.WriteLine(" Entered Successfully");

        }
        static void EnterBorrower(List<BorrowerData> BorrowerDatalist)
        {
            string BorrowerName = read(" Enter the Borrower Name : ");
            int ID = readInt("Enter the Identity number : ");
            string Faculty = read(" Enter the Faculty Name : ");
            string BorrowerDateString = read(" Enter the Borrowed Date (yyyy-mm-dd) : ");
            if(DateOnly.TryParse(BorrowerDateString,out DateOnly BorrowDate))
            {
                BorrowerData borrower = new BorrowerData(BorrowerName, ID, Faculty,BorrowDate);
                BorrowerDatalist.Add(borrower);
                Console.WriteLine(" Entered Successfully");
            }
            else
            {
                Console.WriteLine(" Invalid format");
            }

        }
        static void UpdateBorrowerDate(List<BorrowerData> BorrowerDatalist)
        {
            int UpdateBorrower = readInt(" Enter the ID number");
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Today);

            var UBorrowerID=BorrowerDatalist.Find(a=>a.ID==UpdateBorrower);
            if( UBorrowerID!=null ) {
                if (UBorrowerID.DueDate > currentDate)
                {
                    string UpdateBorrowingDateString = read(" Enter Borrowing Date :(yyyy.mm.dd)");
                    if(DateOnly.TryParse(UpdateBorrowingDateString,out DateOnly BorrowingDate))
                    {
                        UBorrowerID.BorrowDate = BorrowingDate;
                        Console.WriteLine(" Borrowing Date Successfully Upddated");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Date format");
                    }
                  
                }
                else
                {
                    Console.WriteLine("Your Due Date has Passed");
                }

            }
            else
            {
                Console.WriteLine("Invalid ID ");
            }

        }

        static string read(string message)
        {
            Console.WriteLine(message);
            string userInputString = Console.ReadLine();
            return userInputString;
        }
        static int readInt(string message)
        {
            Console.WriteLine(message);
            int UserInputInt=int.Parse(Console.ReadLine());
            return UserInputInt;
        }
    }
}
