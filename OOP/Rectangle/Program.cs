using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();

            Console.Write("Enter rectangle width: ");
            rect.Width = double.Parse(Console.ReadLine());
            Console.Write("Enter rectangle height: ");
            rect.Height = double.Parse(Console.ReadLine());

            Console.WriteLine(rect);
        }
    }
}