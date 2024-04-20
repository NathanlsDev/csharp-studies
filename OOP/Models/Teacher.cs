using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.Models
{
    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {

        }
        
        public decimal Salary { get; set; }

        public sealed override void Salutations()
        {
            Console.WriteLine($"Hello my name is {Name}, I'm {Age} years old, And my salary is: {Salary}");
        }
    }
}