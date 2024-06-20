namespace SalaryIncrease
{
    internal class Employee
    {
        public string Name;
        public double GrossSalary;
        public double Taxes;
        public double Salary;

        public double NetSalary(double grossSalary, double taxes)
        {
            double salary = grossSalary - taxes;
            return Salary = salary;
        }

        public double SalaryIncrease(double percentage)
        {
            return Salary += (GrossSalary * percentage) / 100;
        }

        public override string ToString()
        {
            return $"\nEmployee: {Name}, ${NetSalary(GrossSalary, Taxes).ToString("F2")}";
        }
    }
}
