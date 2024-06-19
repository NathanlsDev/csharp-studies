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

            CalcArea(x, y);
        }

        static void CalcArea(Triangle x, Triangle y)
        {
            double areaX = x.CalculateTraingleArea();
            double areaY = y.CalculateTraingleArea();

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