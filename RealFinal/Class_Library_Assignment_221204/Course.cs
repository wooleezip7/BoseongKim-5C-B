using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library_Assignment
{
    public class Course: IComparable<Course>
    {
        public Course() { }
        public Course(string CourseCode, string CourseName, double Cost) 
        {
            this.CourseCode = CourseCode;
            this.CourseName = CourseName;
            this.Cost = Cost;
        }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public double Cost { get; set; }

        int IComparable<Course>.CompareTo(Course other)
        {
            return this.Cost.CompareTo(other.Cost);
        }
    }
}
