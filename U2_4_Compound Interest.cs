using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p, r, t, ci,a,n;



            Console.WriteLine("amount:  ");
            p = double.Parse(Console.ReadLine());

            Console.WriteLine("rate:  ");
            r = double.Parse(Console.ReadLine());

            Console.WriteLine("time:  ");
            t = double.Parse(Console.ReadLine());

            Console.WriteLine("compounding year: ");
            n = double.Parse(Console.ReadLine());

            a = p * Math.Pow((1 + r / n), n * t);
            ci = a - p;

            Console.WriteLine("Compound Interest: " + ci);


            
        }
    }
}
