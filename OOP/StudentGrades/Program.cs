using System;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.Write("Enter student name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter student grade 1: ");
            student.Grade1 = double.Parse(Console.ReadLine());    
            
            Console.Write("Enter student grade 2: ");
            student.Grade2 = double.Parse(Console.ReadLine());   
            
            Console.Write("Enter student grade 3: ");
            student.Grade3 = double.Parse(Console.ReadLine());

            student.IsApproved();
        }
    }
}