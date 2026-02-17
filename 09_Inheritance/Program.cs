namespace _09_Inheritance;

class Program
{
    static void Main(string[] args)
    {
        var myDog = new Dog();
        myDog.MakeSound();
        myDog.Eat();

        var myCat = new Cat();
        myCat.MakeSound();

        var baseClass = new BaseClass();
        baseClass.ShowFields();

        DerivedClass derivedClass = new DerivedClass();
        derivedClass.AccessFields();
        derivedClass.ShowFields();
        
        // Abstract classes and methods
        var circle = new Circle { Radius = 15 };
        var rectangle = new Rectangle { Width = 4, Height = 6 };

        circle.ShowArea();
        rectangle.ShowArea();
        
        // Constructor Inheritance
        // Employee joe = new Employee("Joe", 32, "Director", 1);
        // joe.DisplayPersonInfo();

        Manager carl = new Manager("Carl", 43, "Manager", 1001, 100);
        carl.DisplayManagerInfo();
        
        
    }

    // Base Class ( Parent Class )
    // The class whose members are inherited
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        // virtual allows Override in derived classes
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }
    
    // Derived Class (Subclass):
    // The class that inherits the members of the base class.
    class Dog : Animal // IS-A relationship (inheritance)
    {
        
        public override void MakeSound() // override keyword
        {
            base.MakeSound();
            Console.WriteLine("Barking...");
        }
    }

    class Engine
    {
        public void Start()
        {
            Console.WriteLine("Engine started..");
        }
    }
    class Car // HAS-A relationship (composition)
    {
        private Engine engine = new Engine();

        public void StartCar()
        {
            engine.Start();
        }
    }
    
    // EXPLANATION:
    // A is a B? - Inheritance (class : class)
    // A has a B? - Composition (class { method() };)

    // A breed of Dog (Multilevel inheritance)
    class Collie : Dog
    {
        public void Active()
        {
            Console.WriteLine("Collie is being active..");
        }
    }
    
    /// Hierarchical Inheritance 
    class Cat : Animal // cat IS-A animal
    {
        // override is used to redefine a base class method in a derived class
        public override void MakeSound() // override keyword
        {
            Console.WriteLine("Cat is meowing...");
        }
    }

    /// Access Modifiers
    class BaseClass
    {
        public int publicField; // accessible everywhere
        protected int protectedField; // all members
        private int privateField; // accessible only inside this class

        public void ShowFields()
        {
            Console.WriteLine($"{publicField}, {protectedField}, {privateField}.");
        }
    }
    class DerivedClass : BaseClass
    {
        public void AccessFields()
        {
            publicField = 1;
            protectedField = 2;
            // privateField = 0; unaccessible due to its protection
        }
    }
    
    // Sealed Method
    
    // A method in a derived class
    // that cannot be overridden further in any subclass (only with override)
    class Human
    {
        public virtual void Speak() => Console.WriteLine("Speaking..");
    }
    class Student : Human
    {
        // sealed method = locks the method in that class (cannot be overriden)
        public sealed override void Speak()
            => Console.WriteLine("Student is speaking in the lecture...");
    }
    class Simon : Student
    {
        // cannot override sealed method ❌
        // public override void Speak() 
        //     => Console.WriteLine("Simon is speaking now...");
        public void Speak() => Console.WriteLine("Simon is speaking now...");
    }
    
    // Abstract Classes and Methods

    abstract class Shape
    {
        public abstract double Area(); // Must be implemented by derived classes
        public abstract void ShowArea(); // Must be implemented by derived classes
        public void Display() => Console.WriteLine("Displaying shape");
    }

    /// <summary>
    /// Circle implements (IS-A) Shape
    /// </summary>
    class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area() => Math.Round(Math.PI * Radius * Radius, 2);
        public override void ShowArea() => Console.WriteLine(Area());
    }

    // Rectangle implements (IS-A) Shape
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area() => Width * Height;
        public override void ShowArea() => Console.WriteLine(Area());
    }

    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        
        /// Base class constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person constructor called");
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"{Name}, {Age} y.o.");
        }
    }

    // Inherits from Person
    public class Employee : Person
    {
        public string JobTitle { get; private set; }
        public int EmployeeId { get; private set; }
        // Employee IS-A person
        public Employee(string name, int age, string jobTitle, int employeeId) : base(name, age)
        {
            JobTitle = jobTitle;
            EmployeeId = employeeId;
            Console.WriteLine("Employee (derived class) constructor called");
        }
        
        public void DisplayEmployeeInfo() // Call method
            => Console.WriteLine($"{Name}, {Age} y.o., {JobTitle}, ID: {EmployeeId}");
    }

    // Inherits from Employee
    public class Manager : Employee
    {
        public int TeamSize { get; private set; }

        public Manager(string name, int age, string jobTitle,
            int employeeId, int teamSize) : base(name, age, jobTitle, employeeId)
        {
            TeamSize = teamSize;
        }

        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo();
            Console.WriteLine($"Team Size: {TeamSize} members");
        }
    }
}