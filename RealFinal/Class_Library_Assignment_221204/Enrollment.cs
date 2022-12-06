using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library_Assignment
{
    public class Enrollment
    {
        public Enrollment() { }
        public Enrollment(string Date_Enrolled, string Grade, string Semester) 
        {
            this.Date_Enrolled = Date_Enrolled;
            this.Grade = Grade;
            this.Semester = Semester;
        }


        private Course _Course { get; set; }
        public Course course { get { return _Course; } set { this._Course = value; } }
        
        public string Date_Enrolled { get; set; }
        public string Grade { get; set; }
        public string Semester { get; set; }

    }
}
