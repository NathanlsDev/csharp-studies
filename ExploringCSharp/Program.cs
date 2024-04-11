using ExploringCSharp.Models;

Person citizen = new Person(name:"Francesco", lastname:"Virgolini");
citizen.Age = 99;
citizen.Presentation();

Person student = new Person(name:"Derp", lastname:"Derpson");
student.Age = 23;

Courses englishCourse = new Courses();
englishCourse.Name = "English B2";
englishCourse.Students = new List<Person>();

englishCourse.AddStudent(citizen);
englishCourse.AddStudent(student);
englishCourse.ShowEnrolledStudents();


