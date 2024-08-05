namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Equipment> Equipmentlist = new List<Equipment>();
            List<RenterData> RenterDataList = new List<RenterData>();


        }
        static void Menu(List<Equipment> Equipmentlist, List<RenterData> RenterDataList)
        {
            Console.WriteLine();
            Console.Write(" 1- Enter Data Equipment\n 2- ViewCategorise Data ");
            int result = int.Parse(Console.ReadLine());
            if (result == 1) {
                EnterData(Equipmentlist);
            }
            else if (result == 2)
            {
                ViewCategory(Equipmentlist);
            }
            else if(result == 3)
            {
                RentalData(RenterDataList);
            }


        }
        static void EnterData(List<Equipment> Equipmentlist)
        {
            Console.WriteLine("Enter Equipment Name : ");
            string EquipName= Console.ReadLine();

            Console.WriteLine("Enter No Of Units : ");
            int EquipUnits = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Manufactorer Name : ");
            string ManufactorerName = Console.ReadLine();


            Console.WriteLine("Enter CategoryType : ");
            string Category = Console.ReadLine();

            Equipment equipment = new Equipment(EquipName, ManufactorerName, EquipUnits, Category);
            Equipmentlist.Add(equipment);

            Console.WriteLine(" Equipment Successfully Recorded ");


        }
        static void ViewCategory(List<Equipment> Equipmentlist)
        {
            Console.WriteLine(" Enter which category type to display : ");
            string ViewCategory= Console.ReadLine();
            var ViewCategoryData=Equipmentlist.Find(x => x.Category == ViewCategory);
            if (ViewCategoryData != null)
            {
                Console.WriteLine($" {ViewCategory} Data");
                /*Console.WriteLine($"{ViewCategoryData.Name}  {ViewCategoryData.SerialNumber }  {ViewCategoryData.NumberOfUnits}");*/
                string output=ViewCategoryData.ToString();
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine(" Category Doesnt Exist");
            }
        }static void RentalData(List<RenterData> RenterDataList)
        {
            Console.WriteLine("Enter Rental Name : ");
            string RentalName = Console.ReadLine();

            Console.WriteLine("Enter Department : ");
            String Department = Console.ReadLine();

            Console.WriteLine("Enter PurchaseDate : ");
            string PurchaseDateString = Console.ReadLine();

            if( DateOnly.TryParse(PurchaseDateString, out var PurchaseDate))
            {
                RenterData rental =new RenterData(RentalName,Department,PurchaseDate);
                RenterDataList.Add(rental);

            }
            else
            {
                Console.WriteLine(" Invalid Date format");
            }
        }
    }
}
