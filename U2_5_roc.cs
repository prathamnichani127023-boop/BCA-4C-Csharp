using System;


namespace P_5
{
    internal class Program
    {
        static void Main()
        {
            int r;
            double roc;

            Console.WriteLine("radius of a circle : \n");
            r = Convert.ToInt32(Console.ReadLine());

            roc = 3.14 * r * r;

            Console.WriteLine("radius of a circle: " + roc);




        }
    }
}
