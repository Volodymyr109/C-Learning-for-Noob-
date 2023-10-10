using System;

namespace lernen {

    class Program {

        static void Main() {
            
            int num_1 = 0, num_2 = 0;
            Console.WriteLine("Wnter num_1: ");
            num_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wnter num_2: ");
            num_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num_1: " + num_1 + " " + "num_2: " + num_2 + " ");
            // Variables and out
            int i = 200; 
            float f = 2.1f;
            double d = 100000.444;
            string s = "My_String_MOOOOIN";
            char c = 'H';
            bool istrue = true;
            Console.WriteLine("Variable i int is: " + i);
            Console.WriteLine("Variable f float is: " + f);
            Console.WriteLine("Variable d double is: " + d);
            Console.WriteLine("String s is: " + s);
            Console.WriteLine("Char c is: " + c);
            Console.WriteLine("Bool istrue is: " + istrue);
            // Out line
            Console.WriteLine("My string out: MoIN MOIN!");
            Console.ReadLine();
        }

    }
}
