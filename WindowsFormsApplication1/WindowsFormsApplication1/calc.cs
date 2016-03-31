using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class calc
    {

        public static double first;
        public static double second;
        private static double result;
        public static string operation;
        public static string show;

        public static void Calculate()
        {
            switch (operation)
            {
                case "+":
                    result = first + second;
                    TWO();
                    break;
                case "-":
                    result = first - second;
                    TWO();
                    break;
                case "*":
                    result = first * second;
                    TWO();
                    break;
                case "/":
                    result = first / second;
                    TWO();
                    break;
                case "sqrt":
                    result = Math.Sqrt(first);
                    show= first.ToString()+operation+ "=" + result.ToString();
                    break;
                case "^":
                    result = Math.Pow(first, second);
                    TWO();
                    break;
                case "sqr":
                    result = Math.Pow(first,2.0);
                    show = first.ToString() + operation + "=" + result.ToString();
                    break;
                case "sin":
                    result = Math.Sin((first*3.14159265359)/180);
                    trig();
                    break;
                case "cos":
                    result = Math.Cos((first * 3.14159265359) / 180);
                    trig();
                    break;
                case "tan":
                    result = Math.Tan((first * 3.14159265359) / 180);
                    trig();
                    break;
                case "ctg":
                    result = 1/Math.Tan((first * 3.14159265359) / 180);
                    trig();
                    break;
                case "log":
                    result = Math.Log10(first);
                    trig();
                    break;
                case "!":
                    result = 1;
                    for (int i = 1; i <=first; i++)
                    {
                        result = result * i;
                    }

                    show = first + operation + "=" + result;
                    break;
            }
            
        }
        public static double Result
        {
            get { return result; }
            set { result = value; }
        }
        public static void TWO()
        {
            show = string.Empty;
            show = first.ToString() + operation + second.ToString() + "=" + result.ToString();
        }
        public static void trig()
        {
            show = string.Empty;
            show =operation +"("+first.ToString()+")" + "=" + result.ToString();
        }
    }
}
