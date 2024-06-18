using DoubleTriangleArea;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DoubleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle x, y;

            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Enter the side lengths of  X:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the side lengths of  Y:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            CalculateTraingleArea(x, y);
        }

        static void CalculateTraingleArea(Triangle x, Triangle y)
        {
            double p = (x.A + x.B + x.C) / 2;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            DisplayAreaMessage(areaX, areaY);
            DisplayGreatherTriangleArea(areaX, areaY);
        }

        static void DisplayAreaMessage(double areaX, double areaY)
        {
            Console.WriteLine($"Triangle X area = {areaX.ToString("F4")}");
            Console.WriteLine($"Triangle Y area = {areaY.ToString("F4")}");
        }

        static void DisplayGreatherTriangleArea(double areaX, double areaY)
        {
            Console.WriteLine(areaX > areaY
              ? "Triangle X has the greater area"
              : "Triangle Y has the greater area");
        }
    }
}