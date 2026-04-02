/* Create a class “Vehicle” with instance variable vehicle_type. 
Inherit the class in a class called “Car” with instance 
model_type, company name etc. display the information of 
the vehicle by defining the show() in both super and sub 
class  */

using System;


class Vehicle
{
    protected string vehicle_type;

    public Vehicle(string type)
    {
        vehicle_type = type;
    }

    
    public virtual void Show()
    {
        Console.WriteLine("Vehicle Type: " + vehicle_type);
    }
}


class Car : Vehicle
{
    string model_type;
    string company_name;

    public Car(string type, string model, string company) : base(type)
    {
        model_type = model;
        company_name = company;
    }

    
    public override void Show()
    {
        base.Show();
        Console.WriteLine("Model Type: " + model_type);
        Console.WriteLine("Company Name: " + company_name);
    }
}


class Program
{
    static void Main()
    {
        Vehicle v = new Car("Four Wheeler", "SUV", "Toyota");
        v.Show();
    }
}