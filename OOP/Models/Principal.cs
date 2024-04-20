using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.Models
{
    public class Principal : Teacher
    {
        public override void Salutations()
        {
            Console.WriteLine($"I'm the principal school.");
        }
    }
}