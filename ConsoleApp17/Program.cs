namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List< Product> Productlist24394 = new List<Product>();
            Product product1=new Product(1235,"vegetable",32);
            Product product2 = new Product(1002, "Chicken", 54);
            Product product3 = new Product(2000, "fish ", 45);
            Productlist24394.Add(product1);
            Productlist24394.Add(product2);
            Productlist24394.Add(product3);
            

            do
            {
                Console.WriteLine("======Welcome to the 24394 Super Market=====");
                Console.WriteLine(" Enter 'S' to show list of Products \n Enter'C'to create a new product");
                Console.WriteLine("======End of the Menu=====");
                string result = Console.ReadLine();
                if (result.ToLower() == "s")
                {
                    ShowProduct(Productlist24394);
                }
                else if (result.ToLower() == "c")
                {
                    CreateProduct24394(Productlist24394);
                }
                else
                {
                    Console.WriteLine(" Enter 'S' or 'C' ");
                }
            }
            while (true);



        }
        static void ShowProduct(List<Product> Productlist24394)
        {
            if(Productlist24394.Count > 0)
            {
                foreach(Product product in Productlist24394)
                {
                    Console.WriteLine($"{product.ProductID}  {product.Price}  {product.Category} ");
                }
            }
            else
            {
                Console.WriteLine("No data lists in the List ");
            }
        }
        static void CreateProduct24394(List<Product> Productlist24394)
        {
            Console.WriteLine("Enter the ProductID :  ");
            int NewProductID24394 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Category :  ");
            string NewCategory24394 = Console.ReadLine();

            Console.WriteLine("Enter the Price :  ");
            double NewPriceID24394 = double.Parse(Console.ReadLine());

            Product product4 = new Product(NewProductID24394, NewCategory24394, NewPriceID24394);
            Productlist24394.Add(product4);
        }
            
        

        }
    }

