using System;
using CSharpProject.People;
using CSharpProject.Cars;
using CSharpProject.Occupation;

namespace CSharpProject.People
{
    public class Person
    {
        public string Name = "Max";
        public int Age = 20;
        public bool isStudent = true;
    }

    public class AnotherPerson
    {
        public string Name = "Sophie";
        public int Age = 25;
        public bool isStudent = false;
    }
}

namespace CSharpProject.Cars
{
    public class Car
    {
        public string Brand = "BMW";
        public int Year = 2020;
        public bool isElectric = true;
    }

    public class AnotherCar
    {
        public string Brand = "Audi";
        public int Year = 2019;
        public bool isElectric = false;
    }
}

namespace CSharpProject.Occupation
{
    public class Job
    {
        public string Company = "Goodgle";
        public int Salary = 100000;
        public bool isRemote = true;
    }

    public class AnotherJob
    {
        public string Company = "Aplacetowork";
        public int Salary = 120000;
        public bool isRemote = false;
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        AnotherPerson anotherPerson = new AnotherPerson();
        Car car = new Car();
        AnotherCar anotherCar = new AnotherCar();
        Job job = new Job();
        AnotherJob anotherJob = new AnotherJob();
        Console.WriteLine(person.Name + " and " + anotherPerson.Name + " are friends.");
        Console.WriteLine(person.Name + " drives a " + car.Brand + " and " + anotherPerson.Name + " drives an " + anotherCar.Brand + ".");
        Console.WriteLine(person.Name + " works at " + job.Company + " and " + anotherPerson.Name + " works at " + anotherJob.Company + ".");
    }
}
