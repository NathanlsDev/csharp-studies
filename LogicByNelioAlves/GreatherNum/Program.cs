using System;

namespace GreeatherNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type tree numbers:");
            int n1, n2, n3;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            double result = Greather(n1, n2, n3);

            Console.WriteLine($"The Greather Number is: {result}");
        }

        static int Greather(int a, int b, int c) 
        {
            if (a > b && a > c)
            {
                return a;
            }

            if (b > c)
            {
                return b;
            }

            return c;            
        }
    }
}
