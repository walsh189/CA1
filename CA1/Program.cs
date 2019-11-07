//Aaron Walsh S00189286
//OOP CA1
//07/11/2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject1 = new Subject("Databases", "Padraig Harte", 1);
            Subject subject2 = new Subject("Programming", "Vivion Kinsella", 1);
            Subject subject3 = new Subject("UX Design", "Adrian Durcan", 2);
            Subject subject4 = new Subject("OOP", "Keith McManus", 2);

            List<Subject> allSubjects = new List<Subject>();
            allSubjects.Add(subject1);
            allSubjects.Add(subject2);
            allSubjects.Add(subject3);
            allSubjects.Add(subject4);

            Student student1 = new Student("Joe Smith", "21/10/2000");
            Student student2 = new Student("Jane Brown", "15/03/1998");

            List<Student> allStudents = new List<Student>();
            allStudents.Add(student1);
            allStudents.Add(student2);

            Display(allSubjects, allStudents);

            DisplayAgeInDays();
        }

        static void Display(List<Subject> subjects, List<Student> students)
        {
            foreach (Subject subject in subjects)
            {
                Console.WriteLine("{0,-10}", subject);
            }

            foreach (Student student in students)
            {
                Console.WriteLine("{0,-10}", student);
            }
        }

        static void DisplayAgeInDays()
        {
            string date = "21/10/2000";
            DateTime fullDate = DateTime.Parse(date);
            Console.WriteLine(fullDate);
        }
    }
}
