// Maximum number 
using System;

namespace Unit_3_18_maximum_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int i, max;

            Console.WriteLine("Enter 5 values:");

            for (i = 0; i < 5; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            max = a[0];

            for (i = 1; i < 5; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            Console.WriteLine("Maximum value = " + max);
        }
    }
}
