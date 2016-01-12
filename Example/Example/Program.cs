using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Complex
    {
        public int a, b;
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        //public Complex Add(Complex complex)
        //{
        //    Complex c = new Complex(this.a + complex.a, this.b + complex.b);
        //    return c;
        //}

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c3 = new Complex(c1.a + c2.a, c1.b + c2.b);
            return c3;
        }

        public override string ToString()
        {
            return a + "/" + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //string s = a.ToString();

            //Complex c = new Complex(4, 5);
            //Complex d = new Complex(5, 6);

            //Complex w = c + d + c + d;
            //Console.WriteLine(w);

            //Console.ReadKey();
            // 5 6 7

            string s = "hello world 1 2 3";
            string[] t = s.Split();
            foreach(string a in t)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine(s.Substring(2, 3));
            Console.WriteLine(s.Replace("llo", "ttv"));
            Console.ReadKey();

        }
    }
}
