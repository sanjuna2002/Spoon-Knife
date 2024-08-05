using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NewBankingSystem
{
    internal class CreateAccount
    {
        public int AccountNumber { get; set; }
        public int IDNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int InitialBalance { get; set; }

        public CreateAccount( int iDNumber, string firstName, string lastName, int initialBalance)
        {
            AccountNumber = CalculateAccountNumber();
            IDNumber = iDNumber;
            FirstName = firstName;
            LastName = lastName;
            InitialBalance = initialBalance;
        }
        public int CalculateAccountNumber()
        {
            Random random = new Random();
            AccountNumber = random.Next(100000000, 999999999);
            return AccountNumber;

        }
        public int MoneyDeposit()
        {
            Console.WriteLine("Enter the Deposit Money");
            int deposit=int.Parse(Console.ReadLine());
            InitialBalance = InitialBalance + deposit;
            return InitialBalance;
        }
        public override string ToString()
        {
            return $"Account Number : {AccountNumber} \n  ID Number {FirstName} \n First Name : {FirstName} \n Last Name : {LastName} \n Initial Blance : {InitialBalance}";
        }
    }
}
