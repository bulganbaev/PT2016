using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECOND
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,c;
            string num;
            Console.WriteLine("Enter your first number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("What operation do you want to do?(*,/,+,-)");
            num = Console.ReadLine();
            c = 0;
            if (num == "+")
            {
                c = a + b;
            }
            else if(num == "-")
            {
                c = a - b;
            }
            else if (num == "*")
            {
                c = a * b;
            }
            else if (num == "/")
            {
                c = a / b;
            }
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
