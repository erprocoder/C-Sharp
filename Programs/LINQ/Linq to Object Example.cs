using System;
using System.Collections.Generic;
using System.Linq;


//Linq To Objects Example
namespace ProgrammingHub
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentClass { get; set; }
        public string StudentDivision { get; set; }
        public string StudentCity { get; set; }
    }
    class LinqToObjectsExample
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { StudentID = 1, StudentName = "Avinash", StudentClass = "Seventh", StudentDivision = "A", StudentCity = "Ram Nagar" });
            students.Add(new Student { StudentID = 2, StudentName = "Miten", StudentClass = "Fifth", StudentDivision = "B", StudentCity = "Vasant Vihar" });
            students.Add(new Student { StudentID = 3, StudentName = "Prasanna", StudentClass = "First", StudentDivision = "C", StudentCity = "Jain Colony" });

            var studentList = from s in students
                                 select s;

            foreach (var stud in studentList)
            {
                Console.WriteLine("Student {0} lives in {1}.",
                                  stud.StudentName, stud.StudentCity);
            }
           
            Console.ReadKey();
        }


    }
}