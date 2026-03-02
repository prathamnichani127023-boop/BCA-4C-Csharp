ÿ// Even or Odd
// Enrollment number : 92400527061
// Name : Nipunsinh Jadeja

using System;

namespace Unit_3_6_Even_Odd
{
    internal class Program
    {
        static void Main()
        {
            int n;

            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("number is  Even Number");
            }
            else
            {
                Console.WriteLine("number is Odd Number");
            }
        }
    }
}
