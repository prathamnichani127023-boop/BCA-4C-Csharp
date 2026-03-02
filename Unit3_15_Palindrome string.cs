// Palindrome number

using System;


namespace Unit_3_14_palindrome_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            string reversed = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }

            if (str == reversed)
                Console.WriteLine("It is palindrome");
            else
                Console.WriteLine("It is not palindrome");
        }
    }
}
