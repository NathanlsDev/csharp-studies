using System;

namespace DoubleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideAX, sideBX, sideCX, sideAY, sideBY, sideCY;

            Console.WriteLine("Enter the side lengths of  X:");
            sideAX = double.Parse(Console.ReadLine());
            sideBX = double.Parse(Console.ReadLine());
            sideCX = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the side lengths of  Y:");
            sideAY = double.Parse(Console.ReadLine());
            sideBY = double.Parse(Console.ReadLine());
            sideCY = double.Parse(Console.ReadLine());

            double p = (sideAX + sideBX + sideCX) / 2;
            double areaX = Math.Sqrt(p * (p - sideAX) * (p - sideBX) * (p - sideCX));

            p = (sideAY + sideBY + sideCY) / 2;
            double areaY = Math.Sqrt(p * (p - sideAY) * (p - sideBY) * (p - sideCY));

            Console.WriteLine($"Triangle X area = {areaX.ToString("F4")}");
            Console.WriteLine($"Triangle Y area = {areaY.ToString("F4")}");

            if (areaX > areaY)
            {
                Console.WriteLine("Triangle X has the greather area");
            } else
            {
                Console.WriteLine("Triangle X has the greather area");
            }
        }
    }
}