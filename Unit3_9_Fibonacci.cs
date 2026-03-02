ÿ// Fibonacci series up to a number inputted by user.
// Name : Nipunsinh Jadeja
// Enrollment number : 92400527061

using System;

namespace Unit_3_9_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a = 0, b = 1, c;

            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci series up to " + n + ":");

            Console.Write(a + " " + b + " ");

            c = a + b;
            while (c <= n)
            {
                Console.Write(c + " ");
                a = b;
                b = c;
                c = a + b;
            }
        }
    }
}
