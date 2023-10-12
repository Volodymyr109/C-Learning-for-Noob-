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

//Example
using System;

namespace lernen {

    class Program {

        static void Main() {

            System.Console.WriteLine("Enter name: ");
            string role = Console.ReadLine();

            if ( role == "Admin") {
                Console.Write("Enter username: ");
                string user_name = Console.ReadLine();
                Console.Write("Enter {0} age: ", user_name);
                int age = Convert.ToInt32(Console.ReadLine());

                if (age < 0 || age > 99) {
                    Console.Write("Enter {0} age: ", user_name);
                    age = Convert.ToInt32(Console.ReadLine());
                } 
                if (age < 0 || age > 99) {
                    Console.WriteLine("Err");
                    age = 0;
                } else {
                    System.Console.WriteLine("Users age is: " + age);
                }    
            } else {
                System.Console.WriteLine("You are not Admin");
            }
        }
    }
}
