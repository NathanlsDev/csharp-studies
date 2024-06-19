using System;
using System.Reflection;

namespace ProductManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            Console.WriteLine("\nEnter product data\n");
            Console.Write("Name: ");
            product.Name = Console.ReadLine();

            Console.Write("Price: ");
            product.Price = double.Parse(Console.ReadLine());

            Console.Write("Quantity in stock: ");
            product.Qtd = int.Parse(Console.ReadLine());

            DisplayProductData(product);
        }

        static void DisplayProductData(Product product)
        {
            Console.WriteLine($"\nProduct data: {product}");
            ManageProductStock(product);
        }

        static void ManageProductStock(Product product)
        {
            int units;

            Console.Write("\nDo you want to 'Add' or 'Remove' products? ");
            string action = Console.ReadLine();

            Console.Write($"\n{action} products quantity: ");
            units = int.Parse(Console.ReadLine());

            string methodName = $"{action}Product";
            MethodInfo method = product.GetType().GetMethod(methodName);
            method.Invoke(product, new object[] { units });

            Console.WriteLine($"\nProduct data: {product}");
        }
    }
}