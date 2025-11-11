// Copyright (c) Akeoott <ame@akeoot.org>. Licensed under the LGPL-3.0 License.
// See the LICENSE file in the repository root for full license text.

namespace Practice;

//! --- Helper classes (Use these as reference!) --- :
#pragma warning disable

internal class Classes
{
    internal class Class_31
    {
        internal static void Hello()
        {
            Console.WriteLine("Hello! Welcome to the program.");
        }

        internal static void Waiting()
        {
            Console.WriteLine("I am waiting for something.");
        }

        internal static void Bye()
        {
            Console.WriteLine("Bye! Thanks for visiting.");
        }
    }

    internal class Class_32 // Would call this class "Human" if it wasn't for practice.
    {
        // These are fields, defining characteristics of an object.
        internal string name;
        internal int age;

        // These are objects, the actions of an object.
        internal void Eat()
        {
            Console.WriteLine($"{name} is eating.");
        }
        internal void Sleep()
        {
            Console.WriteLine($"{name} is sleeping.");
        }
    }

    internal class Class_33 // Would call this class "Car" if it wasn't for practice.
    {
        string make;
        string model;
        string color;
        int year;

        internal Class_33(string make, string model, string color, int year) // This is a constructor
        {
            this.make = make;
            this.model = model;
            this.color = color;
            this.year = year;
        }

        internal void Drive()
        {
            Console.WriteLine($"You drive the {make} {model}");
        }
    }

    internal class Class_34 // Would call this class "Car" if it wasn't for practice.
    {
        string model;
        internal int numberOfCars;              // Not static and object bound
        internal static int staticNumberOfCars; // Static and class bound

        internal Class_34(string model)
        {
            this.model = model;
            numberOfCars++;       // Adds 1 to any specific object making it not possible to count the amount of cars.
            staticNumberOfCars++; // Adds 1 to the class itself making it possible to actually count the amount of cars.
        }

        internal static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }

    internal class Class_35 // Would call this class "Pizza" if it wasn't for practice.
    {
        string bread;
        string sauce;
        string cheese;
        string topping;

        internal Class_35(string bread, string sauce, string cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }

        internal Class_35(string bread, string sauce, string cheese, string topping) // Same constructor but with more arguments
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
    }

    internal class Class_36 // Would call this class "Vehicle" if it wasn't for practice.
    {
        internal int speed = 0;

        internal void go()
        {
            Console.WriteLine($"This vehicle is moving {speed}km/h");
        }
    }
    // These are children classes. They inherit everything from the parent class (Class_36).
    internal class Class_36_Helper1 /* aka "car" */ : Class_36
    {
        internal int wheels = 4;
    }
    internal class Class_36_Helper2 /* aka "bike" */ : Class_36
    {
        internal int wheels = 2;
    }
    internal class Class_36_Helper3 /* aka "boat" */ : Class_36
    {
        internal int wheels = 0;
    }

    // Since "Class_37" has abstract in it, one can't make an object with it, adding security.
    internal abstract class Class_37 // Would call this class "Vehicle" if it wasn't for practice.
    {
        internal int speed = 0;

        internal void go()
        {
            Console.WriteLine($"This vehicle is moving {speed}km/h");
        }
    }
    internal class Class_37_Helper1 : Class_37
    {
        internal int wheels = 4;
    }
    internal class Class_37_Helper2 : Class_37
    {
        internal int wheels = 2;
    }
    internal class Class_37_Helper3 : Class_37
    {
        internal int wheels = 0;
    }

    internal class Class_38 // Would call this class "Car" if it wasn't for practice.
    {
        internal string model;

        internal Class_38(string model)
        {
            this.model = model;
        }
    }

    internal class Class_39 // Would call this class "Car" if it wasn't for practice.
    {
        internal string model;
        internal string color;

        internal Class_39(string model, string color)
        {
            this.model = model;
            this.color = color;
        }
    }

    internal class Class_40 // Would call this class "Animal" if it wasn't for practice.
    {
        // Must be abstract, virtual, or already overridden.
        // Used virtual.
        internal virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    internal class Class_40_Helper1 /* aka "Dog" */ : Class_40
    {
        // Added override to override the Speak method.
        internal override void Speak()
        {
            Console.WriteLine("The dog goes *WOOF*");
        }
    }
    internal class Class_40_Helper2 /* aka "Cat" */ : Class_40
    {
        // Added override to override the Speak method.
        internal override void Speak()
        {
            Console.WriteLine("The cat goes *MEOW*");
        }
    }

    internal class Class_41 // Would call this class "Car" if it wasn't for practice.
    {
        string make;
        string model;
        string color;
        int year;

        internal Class_41(string make, string model, string color, int year)
        {
            this.make = make;
            this.model = model;
            this.color = color;
            this.year = year;
        }

        // Overode ToString() method to return own message.
        public override string ToString()
        {
            return $"This is a {make} {model}";
        }
    }

    internal class Class_42 // Would call this class "Vehicle" if it wasn't for practice.
    {
        // Basically declare existence of a `Go` method
        internal virtual void Go() { }
    }
    internal class Class_42_Helper1 : Class_42
    {
        // Override `Go` method
        internal override void Go()
        {
            Console.WriteLine($"The car is moving");
        }
    }
    internal class Class_42_Helper2 : Class_42
    {
        internal override void Go()
        {
            Console.WriteLine($"The bicycle is moving");
        }
    }
    internal class Class_42_Helper3 : Class_42
    {
        internal override void Go()
        {
            Console.WriteLine($"The boat is moving");
        }
    }

    interface IClass_43_1 // Would call this class "Prey" if it wasn't for practice.
    {
        void Flee(); // Declare
    }
    interface IClass_43_2 // Would call this class "Predator" if it wasn't for practice.
    {
        void Hunt();
    }
    internal class Class_43_1 : IClass_43_1 // Would call this class "Rabbit" if it wasn't for practice.
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit flees!");
        }
    }
    internal class Class_43_2 : IClass_43_2 // Would call this class "Hawk" if it wasn't for practice.
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk hunts!");
        }
    }
    internal class Class_43_3 : IClass_43_1, IClass_43_2// Would call this class "Fish" if it wasn't for practice.
    {
        public void Flee()
        {
            Console.WriteLine("The fish flees!");
        }

        public void Hunt()
        {
            Console.WriteLine("The fish hunts!");
        }
    }

    internal class Class_45 // Would call this class "Player" if it wasn't for practice.
    {
        internal string userName;

        internal Class_45(string userName)
        {
            this.userName = userName;
        }
    }

    internal class Class_46 // Would call this class "Car" if it wasn't for practice.
    {
        private int speed; // is private to prevent tampering outside of set bounds made by the `Speed` property

        internal Class_46(int speed)
        {
            // we will assign property speed instead of assigning the field
            this.Speed = speed;
        }

        // speed property
        internal int Speed
        {
            get // read
            {
                return speed;
            }
            set // write
            {
                // prevents setting the value above 500 when someone attempts to change the value
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }

    internal class Class_47 // Would call this class "Car" if it wasn't for practice.
    {
        // if you got no additional logic,
        // you can instantiate the property in one line.
        internal string Model { get; set; }

        internal Class_47(string model)
        {
            this.Model = model;
        }
    }
}
