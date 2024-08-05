namespace SupplyManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Supplier> SupplierDatalist = new List<Supplier>();
            Menu(SupplierDatalist);
            Menu(SupplierDatalist);

            foreach(Supplier supplier in SupplierDatalist)
            {
                string objectinList=(supplier.ToString());
                Console.WriteLine(objectinList);
            }
            

        }
        static void Menu(List<Supplier> SupplierDatalist)
        {
            Console.WriteLine(" Enter the Supplier Name ");
            string Suppliername = Console.ReadLine();

            Console.WriteLine(" Enter the Supplier Product ");
            string SupplierProductName = Console.ReadLine();

            Console.WriteLine(" Enter the Units Supplied : ");
            int SupplierUnits = int.Parse(Console.ReadLine());

            Console.WriteLine(" Enter the Price per Unit Supplied : ");
            int UnitPrice = int.Parse(Console.ReadLine());

            Console.WriteLine(" Enter the Purchased Date : ");
            string purchasedDateString = Console.ReadLine();

            if (DateOnly.TryParse(purchasedDateString, out DateOnly PurchasedDate)){

                Supplier supplier1 = new Supplier(Suppliername, SupplierProductName, SupplierUnits, UnitPrice, PurchasedDate);
                SupplierDatalist.Add(supplier1);
            }
            else {

                Console.WriteLine(" Invalid Date Format");
            }
            
        }
    }
}
        
  

