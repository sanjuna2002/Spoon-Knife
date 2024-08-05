using System.Reflection.Metadata.Ecma335;
using System.Text.Json;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Product> list = new List<Product>();
            Menu(list);
        }
        static void Menu(List<Product> list)
        {
            while (true)
            {
                Console.WriteLine("====== Welcome to Inventory Management system ======");
                Console.Write(" 1 - Create a New Product \n 2 - Show the Product Data \n 3- Update Inventory \n 4- To Change Inventory : ");
                string result = Console.ReadLine();


                if (result == "1")
                {
                    Create(list);
                }
                else if (result == "2")
                {
                    ShowProducts(list);
                }
                else if (result == "3")
                {
                    update(list);
                }
                else if (result == "4")
                {
                    withdraw(list);
                }
            }

        }
        static void Create(List<Product> list)
        {

            Console.WriteLine(" Enter the Product Name : ");
            string Pname= Console.ReadLine();

            Console.WriteLine(" Enter the  number of Units Available : ");
            int NoOfUnits=int.Parse(Console.ReadLine());

            Console.WriteLine(" Enter the Price per Unit : ");
            double Price=double.Parse(Console.ReadLine());

            Console.WriteLine(" Enter the Purchase Date (yyyy-mm-dd) : ");
           DateOnly PurchaseDate= DateOnly.Parse(Console.ReadLine());

            Product product1=new Product(Pname, NoOfUnits, Price,PurchaseDate);
            list.Add(product1);

            Console.WriteLine($"Product Id : {product1.ProductID} Product Name : {product1.ProductName} Number of Units : {product1.NoOfUnits}");

            string JsonString= JsonSerializer.Serialize(product1);
            File.WriteAllText("Products.json",JsonString);

        }
        static void ShowProducts(List<Product> list)
        {
            if(list.Count > 0)
            {
                foreach(Product product in list)
                {
                    Console.WriteLine($" {product.ProductID} {product.ProductName} {product.PricePerUnit} {product.NoOfUnits} {product.Balance} {product.ExcessCost} {product.PurchaseDate} {product.DueDate}");
                }

            }
            else
            {
                Console.WriteLine(" There are no Data Available");
            }
        }
        static void update(List<Product> list)
        {
            if (list.Count > 0)
            {

                Console.WriteLine(" Enter the Product ID : ");
                int UpdateProduct = int.Parse(Console.ReadLine());

                var ProductCode = list.Find(a => a.ProductID == UpdateProduct);
                if (ProductCode != null)
                {
                    Console.WriteLine("Enter the New quantity");
                    int NewQuantity = int.Parse(Console.ReadLine());
                    ProductCode.NoOfUnits = NewQuantity;
                }
                else
                {
                    Console.WriteLine(" Invalid Product Id ");
                   
                }
            }
            else
            {
                Console.WriteLine(" There are No products ");
               
            }
        }
        static void withdraw(List<Product> list)
        {
            Console.WriteLine(" Enter the Product ID : ");
            int WproductID = int.Parse(Console.ReadLine());
             
            var WithdrawCode=list.Find(a=>a.ProductID == WproductID);
            if(WithdrawCode != null)
            {
                Console.WriteLine(" Enter the quantity changed : ");
                int WithdrawQuantity= int.Parse(Console.ReadLine());

                if(WithdrawQuantity  < WithdrawCode.NoOfUnits)
                {
                    WithdrawCode.NoOfUnits= WithdrawCode.NoOfUnits-WithdrawQuantity ;
                    Console.WriteLine("Your Quantity has been updated ");
                }
                else
                {
                    Console.WriteLine($"Insuffient Balance!!! your Balance is {WithdrawCode.NoOfUnits} ");
                    
                }
            }
            else
            {
                Console.WriteLine(" Your Product Id is Invalid");
            }
        }
    }
}