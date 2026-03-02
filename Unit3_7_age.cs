ÿ//  input age of person and display message as follows
// Enrollment number : 92400527061
// Name : Nipunsinh Jadeja
using System;


namespace Unit_3_7_age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age < 12)
            {
                Console.WriteLine("You are Kid");
            }
            else if (age >= 12 && age <= 17)
            {
                Console.WriteLine("You are Teenager");
            }
            else if (age >= 18 && age <= 60)
            {
                Console.WriteLine("You are Adult");
            }
            else
            {
                Console.WriteLine("You are Senior Citizen");
            }
        }
    }
}
