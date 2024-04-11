using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringCSharp.Models
{
    public class Person
    {
        public Person()
        {
            
        }
        
        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        private string _name;
        private int _age;

        public string Name 
        { 
            get => _name.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("The name can't be empty!");
                }
                _name = value;
            }
        }

        public string LastName { get; set; }

        public string FullName => $"{Name} {LastName}".ToUpper();
        
        public int Age 
        { 
            get => _age; 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The age can't be lesser than 0!");
                }
                _age = value;
            }
        }

        public void Presentation()
        {
            Console.WriteLine($"Name: {FullName}, Age: {Age}");
        }
    }
}