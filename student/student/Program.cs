using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
   class Student
    {
        public string name;
        public string surname;
        public double gpa;
        public string ID;
        public Student(string name, string surname, double gpa,string ID)
        {
            this.name = name;
            this.surname = surname;
            this.gpa = gpa;
            this.ID = ID;
        }
       

        public override string ToString()
        {
            return name + " " + surname + " " + gpa + " " + ID;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insert name, surname, GPA and your ID pls: ", "\n");
            int k = 0;
            Student[] information = new Student[100];
            
            while(1==1)
            {
                try
                {
                    string token = Console.ReadLine();
                    string[] info = token.Split(' ');
                    information[k] = new Student(info[0], info[1], double.Parse(info[2]), info[3]);
                    Console.WriteLine("If you want add one more student press Enter, if you dont want press escape");
                    ConsoleKeyInfo button = Console.ReadKey();
                    if (button.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("Enter new information");
                        k++;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                }


            }
            Console.WriteLine("If you want whole list at all press 1 If you want to see only gpa press 2");
            ConsoleKeyInfo button1 = Console.ReadKey();
    
            if (button1.Key == ConsoleKey.NumPad1)
            {
                for (int i = 0; i <= k; i++)
                {
                    Console.WriteLine(information[i]);

                }
            }
                else if (button1.Key == ConsoleKey.NumPad2)
             {
                for (int i = 0; i <= k; i++)
                {
                    
                    Console.WriteLine( " ID: {0} GPA: {1}",information[i].ID,information[i].gpa);

                }
            }
            
            Console.ReadKey();
        }
    }
}
