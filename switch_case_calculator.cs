using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double a, b;
            char c;
            Console.WriteLine("Enter first num: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What do yu want, + - * / ???");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter second num: ");
            b = Convert.ToDouble(Console.ReadLine());
            switch(c) {
                case '+':
                    Console.WriteLine("{0}+{1}={2}", a, b, a + b);
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                    break;
                case '*':
                    Console.WriteLine("{0}*{1}={2}", a, b, a * b);
                    break;
                case '/':
                    Console.WriteLine("{0}/{1}={2}", a, b, a / b);
                    break;
                default:
                    Console.WriteLine("Feller!! Error! ");
                    break;
            }
            Console.ReadLine(); 
        }
    }
}
