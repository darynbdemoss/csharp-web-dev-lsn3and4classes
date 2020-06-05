using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace SchoolPractice
{
     public class Teacher
    {
        

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public string YearsOfTeaching { get; set; }

        public Teacher()
        {

        }

        public Teacher(string firstName, string lastName, string subject, string yearsOfTeaching)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
            YearsOfTeaching = yearsOfTeaching;
        }


    }
}
