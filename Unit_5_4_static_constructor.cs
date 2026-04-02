// Write a program to illustrate the use of static constructor.

using System;
     
public class Employee
{          
	public int id;           
	public String name;          
	public float salary;          
	public Employee(int i, String n, float s)
	{              
		id = i;              
		name = n;              
		salary = s;          
	}          
	public void display()
	{              
		Console.WriteLine(id + " " + name+" "+salary);          
	}     
}     

class TestEmployee
{         
	public static void Main(string[] args)
	{              
		Employee e1 = new Employee(101, "Nipun", 890000f);              
		Employee e2 = new Employee(102, "Pratham", 490000f);              
		e1.display();              
		e2.display();            
	}      
} 