using System;

// Interface that defines a Quit method
interface IQuittable
{
    // Any class that uses this interface must implement this method
    void Quit();
}

// Employee class that implements the IQuittable interface
class Employee : IQuittable
{
    // Property to store employee name
    public string Name { get; set; }

    // Implement the Quit() method from the interface
    public void Quit()
    {
        // Display a message when the employee quits
        Console.WriteLine(Name + " has quit the job.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object
        Employee emp = new Employee();

        // Assign a name to the employee
        emp.Name = "John";

        // Use polymorphism: treat the Employee object as IQuittable
        IQuittable quittableEmp = emp;

        // Call the Quit() method using the interface reference
        quittableEmp.Quit();

        // Keep the console window open
        Console.ReadLine();
    }
}