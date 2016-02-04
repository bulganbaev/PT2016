using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _2lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your numbers");
            string a = Console.ReadLine();
            Read(a);
            Console.WriteLine("Press any button;");
            Console.ReadKey();
            Output();
            Console.ReadKey();
        }
        public static void Read(string inp)
        {
            FileStream fread = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fwrite = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fread);
            StreamWriter input = new StreamWriter(fread);
            StreamWriter sw = new StreamWriter(fwrite);
            input.WriteLine(inp);
            input.Close();
            fread.Close();
            string[] token = sr.ReadLine().Split();
            int temp = 0;
            int[] array = new int[token.Length];
            for (int i = 0; i < token.Length; i++)
            {
                array[i] = int.Parse(token[i]);
            }
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            int count = 0;
            for (int i=0; i<array.Length;i++)
            {
                for(int k=1;k< array[i];k++)
                {
                    if (array[i] % k == 0)
                        count++;
                }
                if(count<=2)
                {
                    sw.WriteLine("The  minimum is {0};", array[i]);
                    break;
                }
            }
            
            sw.Close();
            sr.Close();
            fwrite.Close();
            fread.Close();
        }
        static void Output()
        {
            FileStream fs = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string a = sr.ReadLine();
            Console.WriteLine(a);
            fs.Close();
            sr.Close();

        }
    }
}
