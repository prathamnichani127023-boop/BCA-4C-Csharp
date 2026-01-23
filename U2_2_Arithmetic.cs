using System;

namespace P_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, add, sub, mul, div;

            Console.WriteLine("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            add = a + b;
            sub = a - b;
            mul = a * b;
            div = a / b;

            Console.WriteLine("addition: " + add);
            Console.WriteLine("subtration: " + sub);
            Console.WriteLine("Multiplion: " + mul);
            Console.WriteLine("division: " + div);

        }
    }
}
