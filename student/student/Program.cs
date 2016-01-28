using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
   class Student
    {
        public string name;
        public string surname;
        public double gpa;
        public string ID;
        public Student(string name, string surname, double gpa,string ID)
        {
            this.name = name;
            this.surname = surname;
            this.gpa = gpa;
            this.ID = ID;
        }

        public override string ToString()
        {
            return name + " " + surname + " " + gpa + " " + ID;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
