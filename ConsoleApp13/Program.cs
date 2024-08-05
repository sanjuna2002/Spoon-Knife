namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter Birthdates : ");
            string BdateString = Console.ReadLine();

            if (DateOnly.TryParse(BdateString, out DateOnly Bdate))
            {

                DateOnly Currentdate = DateOnly.FromDateTime(DateTime.Now);

                int NumberOfMonths = (Currentdate.Month - Bdate.Month)+ ((Currentdate.Year - Bdate.Year)*12);
                Console.WriteLine(NumberOfMonths);
            }
            else
            {
                Console.WriteLine(" Invalid Format");
            }
        }

    }
}
