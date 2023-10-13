using System;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
//           
            // int i = 10;
            // while (i >= 1) {
            //     Console.WriteLine("El. {0}:", i);
            //     i--;
            // }
//
            // bool isHappy = true;
            // while(isHappy) {
            //     string end = Console.ReadLine();
            //     if(end == "end"){
            //         isHappy = false;
            //         System.Console.WriteLine("NO HAPPY");
            //     }
            // }
//
            // int i = 100;
            // do {
            //     System.Console.WriteLine("El.: " + i);
            // } while( i < 10);
// bsp mit gerade zahlen in schleife
            for (int i = 0; i < 10; i++) {
                //if (i % 2 == 0) 
                //    continue;
                if (i % 3 == 0)
                    continue;
                Console.WriteLine("Element: " + i);
            }

        }
    }
}