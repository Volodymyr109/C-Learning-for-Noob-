﻿using System;

namespace lernen {

    public class Program {

        public static void Main(string[] args) {
            
            string word = "MOIN MOIN ";
            word += "WILLST DU EIN FISCHBROTSCHEN";

            //System.Console.WriteLine(word.Length);
            //word = String.Concat(word, "?????????");
            //Console.WriteLine(string.Compare(word, "Helllo"));

            string people = " Alex, Bob, Alice";
            string[] names = people.Split(new char[]{','});
            foreach(string el in names)
                System.Console.WriteLine(el);
        }

    }
}