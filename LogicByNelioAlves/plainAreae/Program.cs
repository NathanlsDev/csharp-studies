/*
 * Fazer um programa para ler as medidas da largura e comprimento de um tereno retangular com uma casa decimal, bem como
 * o valor do metro quadrado do terreno com duas casas decimais. Em seguida, o programa deve mostrar o valor da área do terreno,
 * bem como o valor do preço do terreno, ambos com duas casas decimais.
 */

using System;

namespace plainArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double landWidth, landLength, meterValue, totalLandArea, totalLandPrice;

            Console.WriteLine("Type the land width:");
            landWidth = double.Parse(Console.ReadLine());

            Console.WriteLine("Type the land length:");
            landLength = double.Parse(Console.ReadLine());

            Console.WriteLine("Price per square meter:");
            meterValue = double.Parse(Console.ReadLine());

            totalLandArea = landWidth * landLength;
            totalLandPrice = totalLandArea * meterValue;

            Console.WriteLine($"AREA = {totalLandArea.ToString("F2")}");
            Console.WriteLine($"PRICE = {totalLandPrice.ToString("F2")}");            
        }
    }
}