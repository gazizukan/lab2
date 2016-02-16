﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complex2
{
    class Complex
    {
        int x, y;
        public Complex()
        {
            x = y = 0;
        }
        public Complex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static Complex operator +(Complex a, Complex b)
        {
            int up = a.x * b.y + a.y * b.x;
            int down = a.y * b.y;
            int g = gcd(up, down);
            up /= g;
            down /= g;
            return new Complex(up, down);
        }
        public static int gcd(int a, int b)
        {
            if (b == 0) return a;
            return gcd(b, a%b);
        }
        public override string ToString()
        {
            return x+"/"+y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a1, a2, b1, b2;
            a1 = int.Parse(Console.ReadLine());
            a2=int.Parse(Console.ReadLine()); 
            b1=int.Parse(Console.ReadLine());
            b2 = int.Parse(Console.ReadLine());
            Complex a = new Complex(a1, a2);
            Complex b = new Complex(b1, b2);
            Console.WriteLine(a + b);
            Console.ReadKey();
        }
    }
}
