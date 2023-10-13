using System;

namespace lernen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // arrays
            int[] arr = new int[5];
            arr[0] = 100;
            arr[1] = 200;
            arr[2] = 300;
            arr[3] = 400;
            arr[4] = 500;

            for (int i = 0; i < arr.Length; i++) {
                System.Console.WriteLine("El." + i + " :" + arr[i]);
            }

            // System.Console.WriteLine("El.:" + arr[0]);

            // string[] words = new striing[] {"Name1", "Name2", "Name3"};

            // words[1] = "Otto";
            // words[2] = "Hans";


        }
    }
}