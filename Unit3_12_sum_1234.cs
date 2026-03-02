ÿ//  Calculate sum of the number inputted by the user
// Enrollment number : 92400527061
// Name : Nipunsinh Jadeja


using System;

namespace Unit_3_12_sum_1234
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, add = 0,m;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
             
            while (num > 0)
            {
                m = num % 10;
                num = num / 10;
                add = add + m;
            }
            Console.WriteLine("addition: " + add);
        }
    }
}
