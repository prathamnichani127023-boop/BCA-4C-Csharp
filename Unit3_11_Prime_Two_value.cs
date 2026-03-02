ÿ// prime numbers between two values inputted by the user 
// Enrollment number : 92400527061
// Name : Nipunsinh Jadeja


using System;

namespace Unit_3_11_Prime_Two_value
{
    internal class Program
    {
        static void Main()
        {
            int a, b, i, j, flag;

            Console.Write("Enter first number: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            b = int.Parse(Console.ReadLine());

            for (i = a; i <= b; i++)
            {
                if (i >= 2)
                {
                    flag = 0;

                    for (j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            flag = 1;
                            break;
                        }
                    }

                    if (flag == 0)
                        Console.Write(i + "  ");
                }
            }

        }
    }
}
