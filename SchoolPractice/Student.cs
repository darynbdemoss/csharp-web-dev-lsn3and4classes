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

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
        }

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel(int credits)
        {
            // Determine the grade level of the student based on NumberOfCredits
            return "grade level tbd";
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.

    }
}
