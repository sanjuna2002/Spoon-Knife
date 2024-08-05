using Microsoft.VisualBasic;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Date (yyyy-mm-dd): ");
            string purchasedateString = Console.ReadLine();

       
            DateTime purchasedate;
            if (DateTime.TryParse(purchasedateString, out purchasedate))
            {
  
                DateTime duedate = purchasedate.AddDays(14);
                Console.WriteLine("Your due date is " + duedate.ToString("yyyy-MM-dd"));

                // Get today's date
                DateTime today = DateTime.Today;


                int excessDays;


                if (today > duedate)
                {
                    excessDays = (today - duedate).Days;
                }
                else
                {
                    excessDays = 0;
                }

 
                int excessCharge = excessDays * 50;


                Console.WriteLine("Today's date is " + today.ToString("yyyy-MM-dd"));
                Console.WriteLine("Excess days: " + excessDays);
                Console.WriteLine("Total charge for excess days: $" + excessCharge);
            }
            else
            {

                Console.WriteLine("Invalid date format");

            }
        }
    }
}