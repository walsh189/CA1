using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Student
    {
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public List<Subject> Subjects { get; set; }

        public Student()
        {

        }
        public Student(string name, string dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"{Name}\t{DateOfBirth}\t{Subjects}";
        }
    }
}
