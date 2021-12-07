//Using statements 

using System;
using System.IO;
using System.Collections.Generic;

//Namespace
namespace SampleNamespace
{
//Class declaration
    class Program
    {
    //function declaration
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person newGuy = new Person();
            newGuy.Introduce();

            Person someOtherPerson = new Person("Tommy", "Nguyen");
            someOtherPerson.Introduce();

            Console.WriteLine(newGuy.getFirstName());
            newGuy.setFirstName("Stefan");
            Console.WriteLine(newGuy.getFirstName());

            Employee Kyler = new Employee(40, 18.50, "Kyler", "Dennis");
            Kyler.doWork();
            Kyler.Introduce();

            Trainee Melinda = new Trainee();
            Melinda.doWork();
            Melinda.Introduce();
            Console.WriteLine(Melinda.getInTraining());


            Customer Howard = new Customer(200, "Howard", "Wen");
            Howard.Introduce();
            Console.WriteLine(Howard.CashOnHand);


            Intern Steve = new Intern(30, "Steve", "Burns");
            Steve.Introduce();
            Console.WriteLine("I made, " + Steve.coffeeMade + " coffees!");

            Computer Owner = new Computer(40);
            Console.WriteLine("This computer has been used for " + Owner.HoursWorked + " hours!" );
        }
    }
}