﻿using System;
using System.Collections.Generic;

namespace lernen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> li = new List<int> () {
                1, 2, 3
            };
            li.Add(5);
            li.Add(7);
            li.Add(6);
            li.Remove(1);
            li.Sort();
            //li.Reverse();
            li.Clear();

            foreach(int el in li) {
                System.Console.WriteLine("El.:" + el);
            }
        }
    }
}
