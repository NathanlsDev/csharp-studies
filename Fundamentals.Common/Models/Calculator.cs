using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentals.Common.Calculator{ 
  public class Calculator  {
    public void Sum(int x, int y){
      Console.WriteLine($"{x} + {y} = {x + y}");
    }

    public void Subtract(int x, int y){
      Console.WriteLine($"{x} - {y} = {x - y}");
    }

    public void Multiplication(int x, int y){
      Console.WriteLine($"{x} x {y} = {x * y}");
    }

    public void Division(float x, float y){
      Console.WriteLine($"{x} / {y} = {(x / y).ToString("0.00")}");
    }

    public void Power (int x, int y){
      double power = Math.Pow(x, y); 
      Console.WriteLine($"{x} ^ {y} = {power}");
    }

    public void Sine(double angle){
      double radian = angle * (Math.PI / 180);
      double sine = Math.Sin(radian);
      Console.WriteLine($"The sine of {angle}° = {Math.Round(sine, 4)}");
    }

    public void Cosine(double angle){
      double radian = angle * (Math.PI / 180);
      double cosine = Math.Cos(radian);
      Console.WriteLine($"The cosine of {angle}° = {Math.Round(cosine, 4)}");
    }

    public void Tangent(double angle){
      double radian = angle * (Math.PI / 180);
      double tangent = Math.Tan(radian);
      Console.WriteLine($"The tangent of {angle}° = {Math.Round(tangent, 4)}");
    }

    public void Square(double x){
      double square = Math.Sqrt(x);
      Console.WriteLine($"Square root of {x} = {square}");      
    }
  }
}