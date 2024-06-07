using System;

namespace ex02inputDAta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Full namme:");
            string name = Console.ReadLine();
            Console.WriteLine("How many rooms are in your house ?");
            int rooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Type a product price:");
            double productPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Type your last name, age and heigth at same line:");
            string[] personal = Console.ReadLine().Split(' ');

            Console.WriteLine($"\nlHello {name}, your house has {rooms} rooms");
            Console.WriteLine($"This product price is: {productPrice}");
            Console.WriteLine($"Your last name is {personal[0]}, your age is {personal[1]}, and your heigth is {personal[2]}");
        }
    }

}