using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CreateAccount> list = new List<CreateAccount>();
            GetResults(list);


        }
        static void CreateAnAccount(List<CreateAccount> list) {
            Console.WriteLine("Console WriteLine Enter First Name : ");
            string Fname = Console.ReadLine();

            Console.WriteLine("Console WriteLine Enter Last Name : ");
            string Lname = Console.ReadLine();


            Console.WriteLine("Console WriteLine Enter initial Deosut : ");
            double Ideposit = double.Parse(Console.ReadLine());

            CreateAccount NAccount= new CreateAccount(Fname, Lname, Ideposit);
            list.Add(NAccount);
            Console.WriteLine(" Record Entereed successfully");

        }
        static void ShowDetails(List<CreateAccount> list)
        {
            foreach(var item in list)
            {
                Console.WriteLine(item.AccountNumber+" "+item.FirstName + " " +item.LastName + " " + item.InitialBalance);
            }
        }
        static void GetResults(List<CreateAccount> list)
        {
            while(true)
            {
                Console.WriteLine(" Enter 'C' to Create an Account ");
                Console.WriteLine(" Enter 'S' to show Accounts ");
                Console.WriteLine(" Enter 'D' to deposit Money to an Account ");
                Console.WriteLine(" Enter 'R' to delete a record : ");
                Console.WriteLine("Enter 'U' to update a record ");
                Console.WriteLine(" Enter 'W' to Withdraw Money : ");

                string result= Console.ReadLine();
                if(result.ToUpper() == "C")
                {
                    CreateAnAccount(list);
                }
                else if(result.ToUpper() == "S")
                {
                    if (list.Count > 0)
                    {
                        ShowDetails(list);
                    }
                    else
                    {
                        Console.WriteLine("There is No details to Show");
                    }
                
                    
                }
                else if (result.ToUpper() == "D") {
                    Console.WriteLine(" Enter Your Account Number : ");
                    int Daccount = int.Parse(Console.ReadLine());
                    var AccountNo=list.Find(a=>a.AccountNumber == Daccount);
                    if (AccountNo != null)
                    {
                        AccountNo.MoneyDeposit();
                    }
                    else
                    {
                        Console.WriteLine(" Invalid Account No");
                        continue;
                    }


                }
                else if( result.ToUpper() == "R") {
                    Console.WriteLine("Enter the Account Number of Record Yo want to delete : ");
                    int Raccount= int.Parse(Console.ReadLine());
                    var AccountNo=list.Find(a=> a.AccountNumber == Raccount);
                    if (AccountNo != null)
                    {
                        list.Remove(AccountNo);
                        Console.WriteLine("Successfully Removed");
                    }
                    else
                    {
                        Console.WriteLine(" Your Account number is Not available");
                    }
                }else if( result.ToUpper() == "U")
                {
                    Console.WriteLine(" Enter the user Account that you need to Update :");
                    int Uaccount= int.Parse(Console.ReadLine());
                    var AccountNo=list.Find(a=> a.AccountNumber == Uaccount);
                    if (AccountNo != null)
                    {
                        Console.WriteLine(" Enter New Name : ");
                        string NewName=Console.ReadLine();
                        AccountNo.FirstName = NewName;

                        Console.WriteLine(" Enter the New last Name : ");
                        string NewLastName=Console.ReadLine();
                        AccountNo.LastName = NewLastName;
                        Console.WriteLine(" Data updated Successfully");

                        
                    }
                    else
                    {
                        Console.WriteLine(" The account doesnt exsist ");
                    }
                }
                else if(result.ToUpper()=="W")
                {
                    Console.WriteLine(" Enter the Account Number : ");
                    int Waccount= int.Parse(Console.ReadLine());
                    var AccountNo=list.Find(list=> list.AccountNumber == Waccount);
                    if (AccountNo != null)
                    {
                        Console.WriteLine(" Enter the withdraw amount : ");
                        double withdraw=double.Parse(Console.ReadLine());
                        if(withdraw > AccountNo.InitialBalance) { 
                            Console.WriteLine("Insufficient Balance Your Balance is " + AccountNo.InitialBalance);
                            continue;
                        }
                        else
                        {
                            AccountNo.InitialBalance = AccountNo.InitialBalance- withdraw;
                            Console.WriteLine(" Withdraw Successfully and Your Initial Balance is " + AccountNo.InitialBalance);
                        }
                    }
                    else
                    {
                        Console.WriteLine(" Your Account Number is not Valid");
                    }

                }
                else
                {
                    Console.WriteLine(" Ennter the correct command ");
                    continue;
                }


            }
         }
    }

 }

