using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student daryn = new Student("Daryn", 89, 4.0, 1);

            Console.WriteLine($"The Student Class works! {daryn.Name} is a student and he's a {daryn.GetGradeLevel()} and he has a GPA of {daryn.Gpa}!");
            daryn.AddGrade(4, 3.2);
            Console.WriteLine($"The new {daryn.Gpa} he's now a {daryn.GetGradeLevel()}");

            Student person = new Student("Violet");
            Console.WriteLine(person.ToString());

        }
    }
}
