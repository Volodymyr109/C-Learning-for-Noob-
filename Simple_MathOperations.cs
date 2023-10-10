using System;

namespace lernen {

    class Program {

        static void Main() {

            //Console.WriteLine(Math.Ceiling(4.11f));
            //Console.WriteLine(Math.Floor(4.91f));
            //Console.WriteLine(Math.Round(4.56f));
            //Console.WriteLine(Math.Cos());
            //Console.WriteLine(Math.Sin());
            //System.Console.WriteLine(Math.PI);
            //float result = 1;
            //result++;
            //Console.Write("Enter a float num: ");
            //float user_input = float.Parse(Console.ReadLine());
            //float result;
            //result = user_input + user_input;S
            //Console.WriteLine("result: " + result);

            //Circle area calculate
            System.Console.WriteLine("Enter circle rad.:");
            double rad = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(rad, 2);
            System.Console.WriteLine("Circle area is:" + area + " ");
        }
    }
}
