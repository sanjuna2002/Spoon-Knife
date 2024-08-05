using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> ProductList24394 = new List<Product>();
            Product product1 = new Product(123, "vege", 250);
            ProductList24394.Add(product1);
            Product product2 = new Product(245, "chicken", 625);
            ProductList24394.Add(product2);
            Product product3 = new Product(156, "vege", 250);
            ProductList24394.Add(product3);
            ShowProducts(ProductList24394);
            Menu(ProductList24394);


        }
        static void ShowProducts(List<Product> ProductList24394)
        {
            foreach (Product product in ProductList24394)
            {
                Console.WriteLine(product.ProductID + " " + product.Category + " " + product.Price);
            }
        }
        static void CreateProduct(List<Product> ProductList24394)
        {
            Console.WriteLine("Enter your Product Id : ");
            int NewProduct24394 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Product Category : ");
            string NewCategory24394 = Console.ReadLine();

            Console.WriteLine("Enter your Product Price : ");
            double NewPrice24394 = double.Parse(Console.ReadLine());

            Product product4 = new Product(NewProduct24394, NewCategory24394, NewPrice24394);
            ProductList24394.Add(product4);
            Console.WriteLine(" Recorded successfully");


        }
        static void Menu(List<Product> ProductList24394)
        {
            while (true)
            {
                Console.WriteLine("=====Welcome to 24394 Super MNarket=======");
                Console.WriteLine(" Enter 'S' to show product List");
                Console.WriteLine(" Enter 'C' to show Craete List");
                string choice = Console.ReadLine();
                if (choice.ToUpper() == "S")
                {
                    ShowProducts(ProductList24394);
                }
                else if (choice.ToUpper() == "C")
                {
                    CreateProduct(ProductList24394);

                }
                else
                {
                    Console.WriteLine(" Invalid Input");
                    continue;
                }
            }
        }
    }
}
