using System;

namespace lernen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++) {
                Random random = new Random();
                arr[i] = random.Next(1, 99);
                System.Console.WriteLine("Element" + i + " :" + arr[i]);
            }

            // multidimensional arr, bsp 2 dim.
            int[,] arr = {
                {1, 2, 3},
                {6, 7, 8},
                {9, 4, 1},
            };
            
            arr[0,0] = 55;
            System.Console.WriteLine(arr[0, 0]);
        }
    }
}
