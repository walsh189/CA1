using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Subject
    {
        //private int year;
        public string Name { get; set; }
        public string Lecturer { get; set; }
        public int Year
        {
            get; set;
            //get
            //{
            //    if (Year < 5 && Year > 0)
            //        return year;
            //    else
            //        return 0;
            //}
            //set { }
        }

        public Subject(string name, string lecturer, int year)
        {
            Name = name;
            Lecturer = lecturer;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Name}\t{Lecturer}\t{Year}";
        }
    }
}
