using System;

namespace Si
{
    internal class Program
    {
        static void Main()
        {
            float p, r, t, si;

            
            Console.WriteLine("amount:  ");
            p = float.Parse(Console.ReadLine());

            Console.WriteLine("rate:  ");
            r = float.Parse(Console.ReadLine());

            Console.WriteLine("time:  ");
            t = float.Parse(Console.ReadLine());

            si = p * r * t / 100;

            Console.WriteLine(" simple Interest: " + si);

        }
    }
}
