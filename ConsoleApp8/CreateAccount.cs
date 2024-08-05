using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class CreateAccount
    {

        public int AccountNumber { get;  }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double InitialBalance { get; set; }

        public CreateAccount( string firstName, string lastName, double initialBalance)
        {
            AccountNumber = AccountGenerator();
            FirstName = firstName;
            LastName = lastName;
            InitialBalance = initialBalance;
        }


 
        public int AccountGenerator()
        {
            Random random = new Random();
            var AccountNo = random.Next(1000, 9999);
            return AccountNo;
           

        }
        public void MoneyDeposit()
        {
            Console.WriteLine(" Enter the Amount you wants To Deposit");
            double deposit=double.Parse(Console.ReadLine());
            InitialBalance= deposit+ InitialBalance;

        }
    }
}
