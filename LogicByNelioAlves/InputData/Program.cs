using System;

namespace InputData
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type some salutations message! And the 'rgb' colors:l");
            string salutation = Console.ReadLine();
            string red = Console.ReadLine();
            string green = Console.ReadLine();
            string blue = Console.ReadLine();
            Console.WriteLine($"your message: {salutation}, {red}, {green}, {blue}");

            Console.WriteLine("Type three words, let's split then!");
            string[] formatedSentence = Console.ReadLine().Split(' ', ',');
            string firstWord = formatedSentence[0];
            string secondWord = formatedSentence[1];
            string thirdWord = formatedSentence[2];
            Console.WriteLine($"{firstWord}, {secondWord}, {thirdWord}");
        }
    }
}