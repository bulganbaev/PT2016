using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"M:/";
            filem(file);

        }
        public static void filem(string path)
        {
            Console.Clear();

            DirectoryInfo dir = new DirectoryInfo(path);
            List<FileSystemInfo> docs = new List<FileSystemInfo>();
            docs.AddRange(dir.GetDirectories());
            docs.AddRange(dir.GetFiles());
            int index = 0;
            while (true)
            {
                for(int i = 0; i<docs.Count(); i++)
                {
                    if(index == i)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.WriteLine(docs[i].Name);
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                ConsoleKeyInfo button = Console.ReadKey();
                switch (button.Key)
                {
                    case ConsoleKey.UpArrow:
                        index--;
                        break;
                    case ConsoleKey.DownArrow:
                        index++;
                        break;
                    case ConsoleKey.Enter:
                               if(docs[index].GetType() == typeof(DirectoryInfo))
                        {
                            path = docs[index].FullName;
                           filem(path);
                            docs.Clear();
                        }
                               else if (docs[index].GetType()==typeof(FileInfo))
                        {
                            FileStream st = new FileStream(docs[index].FullName, FileMode.Open, FileAccess.Read);
                            StreamReader sr = new StreamReader(st);
                            string content = sr.ReadToEnd();
                            Console.Clear();
                            Console.WriteLine(content);

                        }
                        break;
                    case ConsoleKey.Escape:
                        DirectoryInfo dr = new DirectoryInfo(path);
                        DirectoryInfo ds = dr.Parent;
                        filem(ds.FullName);
                        docs.Clear();


                        break;
                        
                }
                Console.Clear();
            }
        
        }
    }
}
