using ExploringCSharp.Models;

Person citizen = new Person(name:"Francesco", lastName:"Virgolini");
Person student = new Person(name:"Derp", lastName:"Derpson");
Courses englishCourse = new Courses();

citizen.Age = 99;
citizen.Presentation();

student.Age = 23;

englishCourse.Name = "English B2";
englishCourse.Students = new List<Person>();
englishCourse.AddStudent(citizen);
englishCourse.AddStudent(student);
englishCourse.ShowEnrolledStudents();


decimal monetaryValue = 1450.2M;
Console.WriteLine($"{monetaryValue:C}");