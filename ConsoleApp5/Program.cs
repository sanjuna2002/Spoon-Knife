using System.Collections.Generic;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CreateAnAccount> accountDetails = new List<CreateAnAccount>();
            GetResults(accountDetails);
            
        }
        static CreateAnAccount Account()
        {
            Console.WriteLine(" Enter Id");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine(" Enter First Name : ");
            string FirstName = Console.ReadLine();

            Console.WriteLine(" Enter Last Name : ");
            string LastName = Console.ReadLine();

            Console.WriteLine(" Enter Initial Balance : ");
            float initial= float.Parse(Console.ReadLine());

            CreateAnAccount accountDetails = new CreateAnAccount(id, FirstName, LastName, initial);
            return accountDetails;


        }
        static void ShowDetails(List<CreateAnAccount> accountDetails )
        {
            foreach(CreateAnAccount list in accountDetails )
            {
                Console.WriteLine("Account Num : " + list.AccountNumber +"Name is " + list.Fname );
            }
        }
        static void GetResults(List<CreateAnAccount> accountDetails)
        {
            while(true)
            {
                Console.WriteLine(" Enter 'C' to create an Account or Enter 'D' for deposit an amount");
                string result=Console.ReadLine();

                if (result.ToUpper() == "C")
                {
                    var account= Account();
                    accountDetails.Add(account);

                    ShowDetails(accountDetails);

                }
                else if(result.ToUpper() == "D")
                {
                    if(accountDetails.Count == 0) {
                        Console.WriteLine(" No accounts exsisted ");
                    }
                    else
                    {
                        Console.WriteLine(" Enter Pin Number : ");
                        int pinNum= int.Parse(Console.ReadLine());
                        var PinNo = accountDetails.Find(a => a.Pin == pinNum);
                        if (PinNo==null)
                        {
                            Console.WriteLine(" Invalid Pin : ");
                        }
                        else
                        {
                            PinNo.MoneyDeposit();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Option");
                }
            }

        }
        

        
    }
}
