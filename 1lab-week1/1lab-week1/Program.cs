using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1lab_week1
{
    class Complex
    {
        static void Main(string[] args)
        {
            long a,b;
            Console.Write("Input first number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input last number: ");
            b = int.Parse(Console.ReadLine());
            for ( long i= a; i<= b;i++)
            {
                int count = 0;
                for (long k=1; k<=i;k++)
                {
                    if(i%k == 0)
                    {
                        count++;
                    }
                }
                if(count<=2)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
            }
            Console.ReadKey();

        }
}
}

