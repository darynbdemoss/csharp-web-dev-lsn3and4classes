using System;


namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
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
            // Update the appropriate fields: NumberOfCredits, Gpa
            double newGpa = ((Gpa * NumberOfCredits) + (courseCredits * grade)) / (NumberOfCredits + courseCredits);
            int newNumberOfCredits = NumberOfCredits + courseCredits;
            Gpa = newGpa;
            NumberOfCredits = newNumberOfCredits;          


        }

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel()
        {
            string gradeLevel = " ";
            if (NumberOfCredits >= 90)
            {
                gradeLevel = "Senior";
                return gradeLevel;

            }
            else if (NumberOfCredits >= 60)
            {
                gradeLevel = "Junior";
                return gradeLevel;
            }
            else if (NumberOfCredits >= 30)
            {
                gradeLevel = "Sophomore";
                return gradeLevel;
            }
            else 
            {
                gradeLevel = "Freshmen";
                return gradeLevel;
            }
            
        }

        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";


            
        }


        public override boolean Equals(object toBeCompared)
        {

            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            Student s = toBeCompared as Student;
            return s.StudentId == StudentId;
        }




        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.

    }
}
