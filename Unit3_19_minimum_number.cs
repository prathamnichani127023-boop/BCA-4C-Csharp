// minimum number 
using System;


namespace Unit_3_19_minimum_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int i, min;

            Console.WriteLine("Enter 5 values:");

            for (i = 0; i < 5; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            min = a[0];

            for (i = 1; i < 5; i++)
            {
                if (a[i]  < min )
                {
                    min = a[i];
                }
            }

            Console.WriteLine("Minimum value = " + min);
        }
    }
}
