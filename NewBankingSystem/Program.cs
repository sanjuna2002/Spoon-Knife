using System.Text.Json;
namespace NewBankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CreateAccount> AccountList = new List<CreateAccount>();
            Menu(AccountList);

            foreach (var account in AccountList)
            {
                string jsonstring = JsonSerializer.Serialize(account);
                File.WriteAllText("Accounts.json", jsonstring);
            }
            
            
        }
        static void Menu(List<CreateAccount> AccountList)
        {
            while (true)
            {
                Console.Write(" Enter 'C' to Create an Account \n Enter 'D' to Deposit Money \n Enter 'S' to Show Details ");
                Console.WriteLine();
                string result = Console.ReadLine();
                if (result.ToUpper() == "C")
                {
                    CreateanAccount(AccountList);

                }
                else if (result.ToUpper() == "S")
                {
                    ShowDetails(AccountList);
                }
                else if (result.ToUpper() == "D")
                {
                    DepositMoney(AccountList);
                }
                else
                {
                    Console.WriteLine(" Enter A correct Command");
                    break;
                }
            }

        }
        static void CreateanAccount(List<CreateAccount> AccountList)
        {
            Console.WriteLine(" Enter the ID Nuumber");
            int ID=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the First Name : ");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Enter the Last Name : ");
            string LastName = Console.ReadLine();

            Console.WriteLine("Enter the Initial Blance: ");
            int InitialBalance = int.Parse(Console.ReadLine());

            CreateAccount account = new CreateAccount(ID, FirstName, LastName, InitialBalance);
            AccountList.Add(account);
            Console.WriteLine(" Account entered successfully");
            string output=account.ToString();
            Console.WriteLine(output);


        }
        static void ShowDetails(List<CreateAccount> AccountList)
        {
            if(AccountList.Count > 0)
            {
               /* string output = AccountList.ToString();
                Console.WriteLine(output); */
               foreach(CreateAccount account in AccountList)
                {
                    Console.WriteLine($"{account.AccountNumber}  {account.IDNumber} {account.FirstName} {account.LastName}  {account.InitialBalance}");
                }
            }
            else
            {
                Console.WriteLine(" There are No records to show");
            }

        }
        static void DepositMoney(List<CreateAccount> AccountList)
        {
            Console.WriteLine(" Enter Your Account Nuumber : ");
            int DepositAccount=int.Parse(Console.ReadLine());
            var DepositAccountId=AccountList.Find(a=>a.AccountNumber==DepositAccount);
            if(DepositAccountId != null)
            {
                DepositAccountId.MoneyDeposit();

            }
            else
            {
                Console.WriteLine("That account doesnt Exsist");
            }
        }
    }
}
