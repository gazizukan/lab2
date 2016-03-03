using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Student
    {
        public string name;
        public string surname;
        public Double GPA;

        public Student(string _name, string _surname, Double _gpa)
        {
            this.name = _name;
            this.surname = _surname;
            this.GPA = _gpa;
        }

        public override string ToString()
        {
            return name + " " + surname + " " + GPA;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            Double gpa = Convert.ToDouble(Console.ReadLine());
            Student information = new Student(name, surname, gpa);

            Console.WriteLine(information);
            Console.ReadKey();
        }
    }
}