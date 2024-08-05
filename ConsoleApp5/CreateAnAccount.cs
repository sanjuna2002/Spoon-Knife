using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class CreateAnAccount
    {
        public double AccountNumber { get; }
        public int ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public float IntialBalance { get; set; }
        public double Pin { get; }

        public CreateAnAccount( int iD, string fname, string lname, float intialBalance)
        {
            AccountNumber = AccNum();
            ID = iD;
            Fname = fname;
            Lname = lname;
            IntialBalance = intialBalance;
            Pin=SecurityPin();
        }
        public double AccNum() {
            Random random = new Random();
            var account = random.Next(100000000, 999999999);
            return account;
        }
        public double SecurityPin()
        {
            Random pinNumber = new Random();
            var pin = pinNumber.Next(1000, 9999);
            return pin;
        }
        public void MoneyDeposit()
        {
            Console.WriteLine(" Enter your Deposit Amount : ");
            float Deposit= float.Parse(Console.ReadLine());
            IntialBalance = IntialBalance + Deposit;
            Console.WriteLine(" Your deposit has been sucessfully recorded" + Deposit);

        }



    }
}
