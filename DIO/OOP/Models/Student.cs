using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.Models
{
    public class Student : Person
    {
        public Student(string name) : base (name)
        {

        }

        public double Grade { get; set; }

        public override void Salutations()
        {
            Console.WriteLine($"Hello my name is {Name}, I'm {Age} years old, And I got a: {Grade}");
        }
    }
}