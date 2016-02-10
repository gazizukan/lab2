using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 1; i < n; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
                int min = arr[1], max = arr[0];
                for (int i = 1; i < n; i++)
                {
                    if (min > arr[i])
                    {
                        min = arr[i];
                    }
                    if(max < arr[i])
                    {
                        max = arr[i];
                    }
                }
                Console.WriteLine("Min is" + min);
                Console.WriteLine("Max is" + max);
                Console.ReadKey();

        }
    }
}
