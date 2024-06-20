using System;

namespace SalaryIncrease
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();            

            Console.Write("Enter employee name: ");
            employee.Name = Console.ReadLine();

            Console.Write("Enter gross salary amount: ");
            employee.GrossSalary = double.Parse(Console.ReadLine());

            Console.Write("Enter taxes amount: ");
            employee.Taxes = double.Parse(Console.ReadLine());

            Console.WriteLine(employee);
            calcIncreasePercentage(employee);
        }

        static void calcIncreasePercentage(Employee employee)
        {
            double percentage;

            Console.Write($"\nEnter percentage value to increase {employee.Name} salary: "); 
            percentage = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nUpdated data: {employee.Name}, ${employee.SalaryIncrease(percentage).ToString("F2")}");
        }
    }
}