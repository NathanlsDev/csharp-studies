using System;

namespace beecrowd1019
{
    class Program
    {
        static void Main(string[] args) 
        {
            int N, hours,minutes, seconds, rest;

            Console.WriteLine("Input seconds to be converted in time:");
            N = int.Parse(Console.ReadLine());

            hours = N / 3600;
            rest = N % 3600;

            minutes = rest / 60;
            seconds = rest % 60;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}