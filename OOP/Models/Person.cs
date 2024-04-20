using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.Models
{
    public class Person
    {   
        public Person ()
        {

        }
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public virtual void Salutations ()
        {
            Console.WriteLine ($"Hello my name is {Name}, and i'm {Age} years old.");
        }
    }
}