using System;

namespace DoubleTriangleArea
{
    internal class Triangle
    {
        public double A;
        public double B;
        public double C;

        public double CalculateTraingleArea()
        {
            double p = (A + B + C) / 2;
            double square = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return square;
        }
    }
}
 