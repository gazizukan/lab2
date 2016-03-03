using System;
using ConsoleApplication4;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student(" Gaziz", "123DA78JD", 3.44);
            Console.WriteLine(obj.GetID());
            obj.SetGPA(3.56);
            Student obj2 = new Student("Alibi", "123DA78J3", 3.89);
            if (obj > obj2)
            {
                Console.WriteLine("Perviy student");
            }
            else
            {
                Console.WriteLine("Vtoroy student");
            }
            //Object
            Student c = obj + obj2;
            //c.
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
