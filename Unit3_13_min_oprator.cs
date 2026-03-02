// minimum of three numbers using conditional operator
// Enrollment number : 92400527061
// Name : Nipunsinh Jadeja

using System;


namespace Unit_3_13_min_oprator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3, min;

            Console.Write("Enter first number: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            n3 = int.Parse(Console.ReadLine());

            if (n1 < n2)
            {
                if (n1 < n3)
                    min = n1;
                else
                    min = n3;
            }
            else 
            {
                if (n2 < n3)
                    min = n2;
                else
                    min = n3;
            }
            Console.WriteLine("minimum number:  " + min);
        }
    }
}

