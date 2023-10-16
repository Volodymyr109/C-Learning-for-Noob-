using System;

namespace lernen {

    public class Program {

        public static void Main(string[] args) {
            
            int[] arr1 = {1, 4, 5, 6, 7};
            int res1 = summa(arr1);
            Console.WriteLine("res: " + res1);

            int[] arr2 = {7, 6, 7, 5, 4};
            int res2 = summa(arr2);
            Console.WriteLine("res: " + res2);

        }

        public static int summa(int[] arr) {

            int summ = 0;
            foreach(int el in arr)
                summ += el;

            return summ;
        }

    }
}
