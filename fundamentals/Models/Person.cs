using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fundamentals.Models
{
  public class Person
  {
    public string Name { get; set; }
    public int Age { get; set; }
    public void Presentation()
    {
      Console.WriteLine($"Hello, my name is {Name}, and i'm {Age} years old.");      
    }
  }
}