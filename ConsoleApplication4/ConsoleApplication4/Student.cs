using System;
using ConsoleApplication4;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Student
    {
        public string name;
        public string id;
        public double gpa;
        

        public Student()
        {
            this.name = "Unknown";
            this.id = "unknown";
            this.gpa = 0;
        }

        public Student(string name, string id, double gpa)
        {
            this.name = name;
            this.id = id;
            this.gpa = gpa;
        }

        public Student(string name, string id)
        {
            this.name = name;
            this.id = id;
            this.gpa = 0;
        }

        public string GetID()
        {
            return this.id;
        }

        //GETTER FOR GPA
        //GETTER FOR NAME

        public void SetGPA(double gpa)
        {

            this.gpa = gpa;
        }

        //SETTER FOR NAME
        //SETTER FOR ID

        public static bool operator >(Student a, Student b)
        {
            return a.gpa > b.gpa;
        }

        public static bool operator <(Student a, Student b)
        {
            return a.gpa < b.gpa;
        }

        public static Student operator +(Student a, Student b)
        {
            return new Student(a.name + " " + b.name, a.id + " " + b.id, (a.gpa + b.gpa) / 2);
        }

        public override string ToString()
        {
            return " Меня зовут " + this.name + ", мой GPA " + this.gpa;
        }
        
        

    }
}
