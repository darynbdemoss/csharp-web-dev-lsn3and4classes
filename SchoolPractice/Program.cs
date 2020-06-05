using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student daryn = new Student("Daryn", 1, 4.0, 1);

            Console.WriteLine($"The Student Class works! {daryn.Name} is a student!");
           
        }
    }
}
