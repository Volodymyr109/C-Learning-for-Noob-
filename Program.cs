using System;

namespace lernen {

    class Program {

        static void Main() {

            int a = 5;
            int b = 7;
            bool ishappy = true;
            
            if (a > 7){
                System.Console.WriteLine("Num > 7");
                // Operator &&  -  "and"
            } else if (a == 5 && ishappy == false) {
                System.Console.WriteLine("Num a = 5 and I am happy");
                // Operator ||  -  "or"
            } else if (a < b || ishappy == true) {
                System.Console.WriteLine("5 is < 7 and I am happy");
            } else {
                System.Console.WriteLine("Num < 7");
            }
        }
    }
}
