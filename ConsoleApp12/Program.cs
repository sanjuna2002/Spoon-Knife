namespace ConsoleApp12;
using System.Text.Json;

internal class Program
{
    static void Main(string[] args)
    {
        List<Products> list = new List<Products>();

        Products product1 = new Products("Parippu", 123, "Purchased");
        Products product2 = new Products("Ubalakada", 123, "Purchased");
        Products product3 = new Products("Parippu", 123, "Purchased");

        list.Add(product1);
        list.Add(product2);
        list.Add(product3);
               
            string ProductStrings= JsonSerializer.Serialize(list);
            File.WriteAllText("Products.json", ProductStrings);



    }static void ShowProducts(List<Products> list)
    {
        foreach(Products product in list)
        {
            Console.WriteLine($" {product.Name} {product.UnitPrice} {product.Description} ");
        }
    }
}
