using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating array
            int[] a = new int[5];
            // init array
            int[] b = { 1, 2, 3, 4, 5};

            // two dimension array
            int[,,] c = new int[4, 5, 6];

            // jaggled array
            int[][] d = new int[5][];
            for (int i = 0; i < 5; i++)
            {
                d[i] = new int[i + 1];
            }

            foreach(int x in b)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
