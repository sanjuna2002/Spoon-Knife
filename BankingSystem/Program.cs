namespace BankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> ProductList24394 = new List<Product>();
            Product product1 = new Product(123, "book", 150.00);
            Product product2 = new Product(456, "book", 259.00);
            Product product3 = new Product(789, "book", 550.00);

            ProductList24394.Add(product1);
            ProductList24394.Add(product2);
            ProductList24394.Add(product3);

            Menu(ProductList24394 );

        }
        static void ShowProducts(List<Product> ProductList24394)
        {
            Console.WriteLine(" Product ID   Category   Price"); 
            foreach (Product product in ProductList24394)
            {
                Console.WriteLine(product.ProductID + " " + product.Category +" "+ product.Price);
            }
        }
        static void CreateProduct24394(List<Product> ProductList24394)
        {
            Console.WriteLine("Enter  ProductID : ");
            int NewProductID24394= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter  Category: ");
            string NewCategory24394 =Console.ReadLine(); 

            Console.WriteLine("Enter  Price : ");
            double NewPrice = double.Parse(Console.ReadLine());

            Product product4= new Product(NewProductID24394 , NewCategory24394,NewPrice);
            ProductList24394.Add(product4);

            Console.WriteLine(" Product entered ");

        }
        static void Menu(List<Product> ProdctList24394)
        {
            while(true)
            {
                Console.WriteLine(" Your welcome to 24394 Super Market");
                Console.WriteLine("Enter 'S' to show the list of Products ");
                Console.WriteLine("Enter 'C' to enter a new product");
                string result = Console.ReadLine();

                if(result.ToUpper() == "S")
                {
                    ShowProducts(ProdctList24394);
                }
                else if(result.ToUpper() =="C")
                {
                    CreateProduct24394(ProdctList24394);

                }
                else
                {
                    Console.WriteLine(" Please enter'S' or 'C'");
                    continue;
                }

            }
        }
    }
}
