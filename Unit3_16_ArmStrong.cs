// number is ArmStrong or not
using System;

namespace Unit_3_16_ArmStrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, a , r , sum = 0;

            Console.WriteLine("enter number: ");
            num = int.Parse(Console.ReadLine());

            a = r;   

            while (a > 0)
            {
                r = a % 10;
                sum = sum + (r * r * r);
                a = a / 10;
            }

            if (num== sum)
                Console.WriteLine("Entered number is Armstrong");
            else
                Console.WriteLine("Entered number is Not Armstrong");
        }
    }
}