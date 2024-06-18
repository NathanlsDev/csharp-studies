using System;

namespace AverageWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeOne, employeeTwo;

            employeeOne = new Employee();
            employeeTwo = new Employee();

            GetEmployeeData(employeeOne, employeeTwo);
        }

        static void GetEmployeeData(Employee employeeOne, Employee employeeTwo)
        {
            Console.WriteLine("Employee name:");
            employeeOne.Name = Console.ReadLine();
            Console.WriteLine("Employee salary:");
            employeeOne.Salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Employee name:");
            employeeTwo.Name = Console.ReadLine();
            Console.WriteLine("Employee salary:");
            employeeTwo.Salary = double.Parse(Console.ReadLine());

            CalculateAverageWage(employeeOne, employeeTwo);
        }

        static void CalculateAverageWage(Employee employeeOne, Employee employeeTwo)
        { 
            double average = (employeeOne.Salary + employeeTwo.Salary) / 2;
            DisplayeAverageWage(average);
        }

        static void DisplayeAverageWage(double average)
        {
            Console.WriteLine($"Employees average wage is {average}");
        }
    }
}