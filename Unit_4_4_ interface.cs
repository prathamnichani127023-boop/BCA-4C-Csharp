/*  Write a program to implement an interface called Exam with 
a method Pass (intmark) that returns a boolean. Write 
another interface called Classify with a methodDivision (int 
average) which returns a String. Write a class called Result 
which implements both Exam and Classify. The Pass method 
should return true if the mark is greater than or equal to 50 
else false. The Division method must return “First” when the 
parameter average is 60 or 
more, “Second” when average is50 or more but below 60, 
“No division” when average is less than 50 */ 


using System;

interface Exam
{
    bool Pass(int mark);
}

interface Classify
{
    string Division(int average);
}

class Result : Exam, Classify
{
    public bool Pass(int mark)
    {
        return mark >= 50;
    }

    public string Division(int average)
    {
        if (average >= 60)
            return "First";
        else if (average >= 50)
            return "Second";
        else
            return "No division";
    }
}

class Program
{
    static void Main()
    {
        Result r = new Result();

        int marks = 55;
        int avg = 58;

        Console.WriteLine("Pass Status: " + r.Pass(marks));
        Console.WriteLine("Division: " + r.Division(avg));
    }
}