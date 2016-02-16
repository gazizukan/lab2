using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            F4();
        }
        static void F4()
        {
            StreamReader sr = new StreamReader(@"D:\PTT\input.txt");
            string text = sr.ReadToEnd();

            FileStream fs = new FileStream(@"D:\PTT\output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);

            string[] arr = text.Split(' ');

            int[] x = new int[10];

            for (int i = 0; i < arr.Length; ++i)
            {
                x[i] = int.Parse(arr[i]);

            }

            int max = x[0];
            int min = x[0];
            for (int i = 1; i < x.Length; ++i)
            {
                if (x[i] > max)
                {
                    max = x[i];
                }
                else if (x[i] < min)
                {
                    min = x[i];
                }

            }

            sw.WriteLine("max is " + max + " , min is " + min);


            sr.Close();
            sw.Close();

        }
    }

}