namespace StudentGrades
{
    internal class Student
    {
        public string Name;
        public double Grade1, Grade2, Grade3;

        public double YearlyGrade(double grade1, double grade2, double grade3)
        {
            return grade1 + grade2 + grade3;
        }

        public void IsApproved()
        {
            double finalGrade = (YearlyGrade(Grade1, Grade2, Grade3));
            string status = finalGrade >= 60 ? "APPROVED!" : "REPROVED." + $"\n{60 - finalGrade} POINTS WERE MISSING!";


            Console.WriteLine($"FINAL GRADE = {finalGrade.ToString("F2")}"
                + $"\n{status}");
        }
    }
}
