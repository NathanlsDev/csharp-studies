using System;

namespace area1
{
    class Program
    {
        static void Main(string[] args)
        {
            double triangleBase, triangleHeight, area, perimeter, diagonal;

            Console.WriteLine("Define triangle base:");
            triangleBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Define triangle heigth:");
            triangleHeight = double.Parse(Console.ReadLine());

            area = triangleBase * triangleHeight;
            perimeter = 2 * (triangleBase + triangleHeight);
            diagonal = Math.Sqrt(Math.Pow(triangleBase, 2.0) + Math.Pow(triangleHeight, 2.0));

            Console.WriteLine($"Area = {area.ToString("F4")}");
            Console.WriteLine($"Area = {perimeter.ToString("F4")}");
            Console.WriteLine($"Area = {diagonal.ToString("F4")}");



        }
    }
}