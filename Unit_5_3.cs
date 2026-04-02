/* Describe an abstract class called Shape which has three 
subclasses say Triangle,Rectangle, and Circle. Define one 
method area () in the abstract class and override this area 
() in these three subclasses to calculate for specific objects 
i.e., area () of Triangle subclass should calculate area of 
triangle etc. Same for Rectangle and Circle */ 
 

using System;


abstract class Shape
{
    
    public abstract double Area();
}


class Triangle : Shape
{
    double baseVal, height;

    public Triangle(double b, double h)
    {
        baseVal = b;
        height = h;
    }


    public override double Area()
    {
        return 0.5 * baseVal * height;
    }
}


class Rectangle : Shape
{
    double length, width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    
    public override double Area()
    {
        return length * width;
    }
}


class Circle : Shape
{
    double radius;

    public Circle(double r)
    {
        radius = r;
    }

    
    public override double Area()
    {
        return Math.PI * radius * radius;
    }
}


class Program
{
    static void Main()
    {
        Shape t = new Triangle(5, 10);
        Shape r = new Rectangle(4, 6);
        Shape c = new Circle(3);

        Console.WriteLine("Triangle Area = " + t.Area());
        Console.WriteLine("Rectangle Area = " + r.Area());
        Console.WriteLine("Circle Area = " + c.Area());
    }
}