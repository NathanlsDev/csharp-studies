using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Salutations ()
        {
            Console.WriteLine ($"Hello my name is {Name}, and i'm {Age} years old.");
        }
    }
}