using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library_Assignment
{
    public class Student : Person,IComparable<Student>
    {

        public Student(string name, string email, string telnum, string program, string dateRegistered, int studentId) : base(name, email, telnum)
        {
            Program = program;
            DateRegistered = dateRegistered;
            StudentId = studentId;
        }

        public Enrollment _Enrolled { get; set; }
        public String Program {get; set;}
        public String DateRegistered { get; set;}

        public int StudentId { get; set;}

        public static bool operator == (Student x, Student y) 
        {
            
            return object.Equals(x, y);
        }

        public static bool operator != (Student x, Student y) 
        {
            return !object.Equals(x, y);
        }
        int IComparable<Student>.CompareTo(Student other)
        {
            return this.StudentId.CompareTo(other.StudentId);
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Student rhs = obj as Student;
            return this.Program == rhs.Program && this.DateRegistered == rhs.DateRegistered && this.StudentId == rhs.StudentId; 
        }

        public override int GetHashCode()
        {
            return this.Program.GetHashCode() ^ this.DateRegistered.GetHashCode() ^ this.StudentId.GetHashCode();
        }


        public override string ToString()
        {
            return Name + " " +Email + " " +Tel_Num + " " + Program + " " + DateRegistered + " " + StudentId;

        }


    }

    
}
