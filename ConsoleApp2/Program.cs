using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mainmenu();

            int choice=Convert.ToInt32(Console.ReadLine());
            if(choice == 1) {
                add();

            }
            else if (choice == 2)
            {
                sub();
            }
            else if(choice == 3)
            {
                multi();
            }
            else if(choice == 4){
                div();
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        static void add() {
            Console.WriteLine("Enter number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int total=num1+ num2;
            Console.WriteLine(total);
            Console.WriteLine("Do you  want to do another calculation ?(Y/N)");
            string selection = Console.ReadLine();
            if(selection == "Y")
            {
                mainmenu();
            }
            else if(selection=="N")
            {
                Console.WriteLine("Thank You");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        
        }
        static void sub()
        {
            Console.WriteLine("Enter number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int total = num1 - num2;
            Console.WriteLine(total);
            Console.WriteLine("Do you  want to do another calculation ?(Y/N)");
            string selection = Console.ReadLine();
            if (selection == "Y")
            {
                mainmenu();
            }
            else
            {
                Console.WriteLine("Thank You");
            }

        }
        static void multi()
        {
            Console.WriteLine("Enter number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int total = num1 * num2;
            Console.WriteLine(total);
            Console.WriteLine("Do you  want to do another calculation ?(Y/N)");
            string selection = Console.ReadLine();
            if (selection == "Y")
            {
                mainmenu();
            }
            else
            {
                Console.WriteLine("Thank You");
            }

        }
        static void div()
        {
            Console.WriteLine("Enter number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int total = num1 / num2;
            Console.WriteLine(total);
            Console.WriteLine("Do you  want to do another calculation ?(Y/N)");
            string selection = Console.ReadLine();
            if (selection == "Y")
            {
                mainmenu();
            }
            else
            {
                Console.WriteLine("Thank You");
            }

        }

        static void mainmenu()
        {
            Console.WriteLine("Select the suitable command ");
            Console.WriteLine(" 1 - Addition");
            Console.WriteLine(" 2 - Substraction");
            Console.WriteLine(" 3 - Multiplication");
            Console.WriteLine(" 4 - Division");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                add();

            }
            else if (choice == 2)
            {
                sub();
            }
            else if (choice == 3)
            {
                multi();
            }
            else if (choice == 4)
            {
                div();
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
