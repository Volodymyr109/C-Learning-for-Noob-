﻿using System;

namespace lernen {

    public class Program {

        public static void Main(string[] args) {
            
            int[] arr = {1, 4, 5, 6, 7};
            int res1 = summa(arr);
            Console.WriteLine("res: " + res1);
        }

        public static int summa(int[] arr) {

            int summ = 0;
            foreach(int el in arr)
                summ += el;

            return summ;
        }

    }
}