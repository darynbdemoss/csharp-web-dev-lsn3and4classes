using System;


namespace SchoolPractice
{
    public class Student
    {
        public string Name;
        public int NumberOfCredits;
        public double Gpa;
        public int StudentId;

        public Student(string name, int numberOfCredits, double gpa, int studentId)
        {
            Name = name;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
            StudentId = studentId;
        }
    }
}
