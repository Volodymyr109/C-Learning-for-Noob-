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

        }
    }
}
