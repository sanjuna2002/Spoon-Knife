namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*
            Books book1 = new Books(1001, "Madol Duuwa", " Martin Wikramasinghe");
            Books book2 = new Books(1001, "Transformers", "J.J");

            string bookstring= book1.ToString();
            Console.WriteLine(bookstring);  
            */

            Console.WriteLine(" Enter the due date(yyyy-mm-dd ");
            DateTime date=Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(date);


            /*
            DateOnly currentDate=DateOnly.FromDateTime(DateTime.Today);
            if(DateOnly.TryParse( DateString, out DateOnly duedate)) { 
                if(duedate> currentDate)
                {
                    int excessmonths=duedate.Month-currentDate.Month;
                    Console.WriteLine($"You Have {excessmonths} months to the duedate");

                }
                else
                {
                    Console.WriteLine(" Your due date has been passed");
                }
            }
            else
            {
                Console.WriteLine(" Invalid Date ");
                return;
            }
            */
        }
    }
}
