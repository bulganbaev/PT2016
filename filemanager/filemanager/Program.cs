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
            try {
                string file = @"M:/";
                filem(file);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
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

                for (int i = 0; i < docs.Count; i++)
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
                    Console.WriteLine(docs[i].Name);
                    Console.BackgroundColor = ConsoleColor.Black;

                }
                ConsoleKeyInfo button = Console.ReadKey();
            
                switch (button.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (index < docs.Count - 1)
                            index++;
                        break;
                    case ConsoleKey.Enter:
                        if (docs[index].GetType() == typeof(DirectoryInfo))
                        {
                            path = docs[index].FullName;
                            
                            filem(path);
                            docs.Clear();
                        }
                        else if (docs[index].GetType() == typeof(FileInfo))
                        {
                            FileStream fs = new FileStream(docs[index].FullName, FileMode.Open, FileAccess.Read);
                            StreamReader sr = new StreamReader(fs);
                            string readfile = sr.ReadToEnd();
                    
                            Console.Clear();
                            Console.WriteLine(readfile);
                        }
                        break;

                    case ConsoleKey.Escape:
                        int count = 0;
                        for(int i =path.Length-2;i>=0;i--)
                         {
                            if (Convert.ToInt32(path[i]) == 92 )
                                break;
                            else
                            {

                                count++;
                            }
                         }
                       
                        path = path.Remove(path.Length - count-1);
                        
                        filem(path);
                        break;
                
                        
                }
                Console.Clear();
            }
        }
    }
}
