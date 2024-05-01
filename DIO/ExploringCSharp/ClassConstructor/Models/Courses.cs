using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringCSharp.Models
{
    public class Courses
    {
        public string Name { get; set; }
        public List<Person> Students { get; set; }
        
        public void AddStudent(Person student)
        {
            Students.Add(student);
        }

        public int GetEnrolledStudents()
        {
            int quantity = Students.Count;
            return quantity;
        }

        public bool RemoveStudent(Person student)
        {   
            return Students.Remove(student);
        }

        public void ShowEnrolledStudents()
        {
            int id = 0;
            foreach(Person student in Students)
            {   
                id++;
                Console.WriteLine($"ID: {id} - Name: {student.FullName}");
            }
        }
    }
}