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
        Console.WriteLine(person.Name);
        Console.WriteLine(person.Age);
        Console.WriteLine(person.isStudent);

        AnotherPerson anotherPerson = new AnotherPerson();
        Console.WriteLine(anotherPerson.Name);
        Console.WriteLine(anotherPerson.Age);
        Console.WriteLine(anotherPerson.isStudent);

        Car car = new Car();
        Console.WriteLine(car.Brand);
        Console.WriteLine(car.Year);
        Console.WriteLine(car.isElectric);

        AnotherCar anotherCar = new AnotherCar();
        Console.WriteLine(anotherCar.Brand);
        Console.WriteLine(anotherCar.Year);
        Console.WriteLine(anotherCar.isElectric);

        Job job = new Job();
        Console.WriteLine(job.Company);
        Console.WriteLine(job.Salary);
        Console.WriteLine(job.isRemote);

        AnotherJob anotherJob = new AnotherJob();
        Console.WriteLine(anotherJob.Company);
        Console.WriteLine(anotherJob.Salary);
        Console.WriteLine(anotherJob.isRemote);
    }
}