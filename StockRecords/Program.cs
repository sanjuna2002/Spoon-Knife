namespace StockRecords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Products> list = new List<Products>();
            Menu(list);

        }
        static void Menu(List<Products> list)
        {
            while (true)
            {
                Console.Write("1- Enter A Product \n 2- Show Records \n 3- Update Product ");
                int Result = int.Parse(Console.ReadLine());
                if (Result == 1)
                {
                    CreateProduct(list);
                }
                else if (Result == 2)
                {
                    ShowResults(list);
                }
                else if (Result == 3)
                {
                    UpdateProduct(list);
                }
                else
                {
                    Console.WriteLine(" Error");
                }
            }
        }
        static void CreateProduct(List<Products> list)
        {
            
            
                Console.WriteLine("Enter Product Name : ");
                string ProductName = Console.ReadLine();

                Console.WriteLine("Enter Product Units  : ");
                int ProductUnits = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Product Price : ");
                int ProductPrice = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Purchase Date : ");
                string PurchaseDateString = Console.ReadLine();

                DateOnly PurchaseDate;
                if (DateOnly.TryParse(PurchaseDateString, out PurchaseDate))
                {

                Products product1 = new Products(ProductName, ProductUnits, ProductPrice, PurchaseDate);
                list.Add(product1);



                }
                else
                {
                    Console.WriteLine(" Invalid Date Foremat");
                }
            

        }
        static void ShowResults(List<Products> list)
        {
            if (list.Count > 0)
            {
                foreach (Products product in list) { Console.WriteLine($"{product.ProductCode} {product.ProductName} {product.DueDate}"); }
            }
            else
            {
                Console.WriteLine(" No Data Available ");
            }
        }
        static void UpdateProduct(List<Products> list)
        {
            Console.WriteLine(" Enter Product Id ");
            int UproductCode = int.Parse(Console.ReadLine());
            var ProductCodeVerify = list.Find(a => a.ProductCode == UproductCode);
            if (ProductCodeVerify != null)
            {
                Console.WriteLine("Enter The New Units");
                int Uunits= int.Parse(Console.ReadLine());
                ProductCodeVerify.Units= Uunits;
                Console.WriteLine(" Product Units are updated");
            }
            else
            {
                Console.WriteLine(" Invalid Product Id");
            }
        }

    }
}
