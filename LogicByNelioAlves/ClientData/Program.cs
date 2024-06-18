using System;

namespace ClientData
{
    class Program
    {
        static void Main(string[] args)
        {
            Person clientOne, clientTwo;

            clientOne = new Person();
            clientTwo = new Person();

            GetUserData(clientOne, clientTwo);
        }

        static void GetUserData(Person clientOne, Person clientTwo)
        {
            Console.Write("Type your name:");
            clientOne.Name = Console.ReadLine();
            Console.WriteLine("Type your age:");
            clientOne.Age = int.Parse(Console.ReadLine());

            Console.Write("Type your name:");
            clientTwo.Name = Console.ReadLine();
            Console.WriteLine("Type your age:");
            clientTwo.Age = int.Parse(Console.ReadLine());

            DisplayOlderClient(clientOne, clientTwo);
        }

        static void DisplayOlderClient(Person clientOne, Person clientTwo)
        {
            Console.WriteLine(clientOne.Age > clientTwo.Age
                ? $"{clientOne.Name} is more older."
                : $"{clientTwo.Name} is more older.");
        }
    }
}
