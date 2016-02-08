using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace filemanager
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"‪C:\");
            if (dir.Exists)
            {
                Console.WriteLine(dir.FullName);
            }
            FileInfo[] files = dir.GetFiles();
            int index = 0;
            while (true)
            {

                for (int i = 0; i < files.Length; i++)
                {
                    
                    if (index == i)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                     
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.WriteLine(files[i].Name);
                    Console.BackgroundColor = ConsoleColor.Black;

                }
                ConsoleKeyInfo button = Console.ReadKey();
                if (button.Key == ConsoleKey.UpArrow)
                {
                    if (index > 0)
                        index--;
                }
                if (button.Key == ConsoleKey.DownArrow)
                {
                    if (index < files.Length - 1)
                        index++;
                }
                Console.Clear();
            }
        }
    }
}
