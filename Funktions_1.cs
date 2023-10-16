﻿using System;
using System.Collections.Generic;

namespace lernen {

    public class Program {

        public static void Main(string[] args) {
            
            print("TEST first out MOIN OIN");
            int res1 = sum(1, 2);
            int a = 1, b = 4;
            int res2 = sum(a, b);

            print(res1.ToString());
            print(res2.ToString());
        }

        public static void print(string s) {
            System.Console.WriteLine(s);
        }

        public static int sum(int x, int y) {
            return x + y;
        }

    }
}
