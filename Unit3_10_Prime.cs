ÿ// Chek from prime number
// Enrollment number : 92400527061
// Name : Nipunsinh Jadeja

using System;

namespace Unit_3_10_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, flag = 0;

            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            if (n <= 1)
                flag = 1;  

            for (i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    flag = 1; 
                    break;
                }
            }

            if (flag == 0)
                Console.WriteLine("It is a prime number");
            else
                Console.WriteLine("It is not a prime number");
        }
    }
}
