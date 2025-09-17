using System;

// Disabeling warnings for practice
#pragma warning disable CA5394, CS8321, CS8600, CA1305

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Practice()
            {
                /*  List of themes covered here:

                  ⇓ #1  the beginning                   | ⇓ #21 arrays                      | ⇓ #41 ToString method
                    #2  output                          |   #22 foreach loop                |   #42 polymorphism
                    #3  variables                       |   #23 methods                     |   #43 interfaces
                    #4  constants                       |   #24 return keyword              |   #44 Lists
                    #5  type casting                    |   #25 method overloading          |   #45 List of objects
                    #6  user input                      |   #26 params keyword              |   #46 getters & setters
                    #7  arithmetic operators            |   #27 exception handling          |   #47 auto implemented properties
                    #8  Math class                      |   #28 conditional operator        |   #48 enums
                    #9  random numbers                  |   #29 string interpolation        |   #49 generics
                    #10 hypotenuse calculator program   |   #30 multidimensional arrays     |   #50 multithreading
                    #11 string methods                  |   #31 classes
                    #12 if statements                   |   #32 objects
                    #13 switches                        |   #33 constructors
                    #14 logical operators && ||         |   #34 static
                    #15 while loops                     |   #35 overloaded constructors
                    #16 for loops                       |   #36 inheritance
                    #17 nested loops                    |   #37 abstract classes
                    #18 number guessing game            |   #38 array of objects
                    #19 rock-paper-scissors game        |   #39 objects as arguments
                    #20 calculator program              |   #40 method overriding
                */

                static void Method_1()
                {
                    /*
                        --- 1 - The Beginning! ---
                    */
                    Console.WriteLine("\nIM TEXT GETTING PRINTED!\n");
                }

                static void Method_2()
                {
                    /*
                        --- 2 - Output! ---
                    */
                    Console.Write("\nOh, ");             // Just writing this into anything that exists! No new line.
                    Console.WriteLine("Hello World!"); // Literally a new line with this text
                    Console.Beep();                    // Makes a BEEP sound on some devices. Depends

                    // NIGER im a comment

                    /*
                    NIGGI DI DIGGI
                    asd FUCK
                    im a multi line comment
                    */

                    Console.WriteLine("AKEOOT!\n");

                    /*
                    Console.ReadKey(); // Requires input to exit/finish operation! Kinda like input() from python.
                    */
                }

                static void Method_3()
                {
                    /*
                        --- 3 - Variables! ---
                    */
                    // int = intiger = a whole number.
                    int x;       // decleration
                    x = 123;     // initialization
                    int y = 321; // decleration + initialization

                    int z = x + y; // Adding two intigers

                    int age = 16;

                    Console.WriteLine(x);
                    Console.WriteLine(y);
                    Console.WriteLine(z);

                    // The $ sign lets us use variables easier in strings. Like: $"TEXT AHH {variable} MORE TEXT!"
                    Console.WriteLine($"\nYour age is {age}\n");

                    // Basically, container for values:
                    int whole_num = 1;        // int is for whole numbers like 1
                    double decimal_num = 1.1; // double is for decimal numbers like 1.0
                    bool boolean = true;      // bool is for true/false aka yes/no
                    char symbol = '@';        // char is for a single character like '@' or 'A'
                    string name = "Akeoot";   // string is for a series of characters like "hello"

                    Console.WriteLine($"[Type]     [Data]  |  [Description]");
                    Console.WriteLine($"int      = {whole_num}       |  int aka a whole number");
                    Console.WriteLine($"double   = {decimal_num}     |  double aka a decimal number");
                    Console.WriteLine($"bool     = {boolean}    |  bool aka ture or false");
                    Console.WriteLine($"char     = {symbol}       |  char aka a single character");
                    Console.WriteLine($"string   = {name}  |  string aka a series of characters");
                    Console.WriteLine($"int      = {whole_num}       |  int aka a whole number\n");
                }

                static void Method_4()
                {
                    /*
                        --- 4 - Constants! ---
                    */
                    // constants  = immutable values which are known at compile time,
                    //              and do not change for the life of the program.

                    // The value pi cannot be changed cause its a constant!
                    // If it wherent a constant, then i would be able to change the value.
                    const double pi = 3.14159;

                    Console.WriteLine($"\npi is a constant so it cant get changed!: {pi}\n");
                }

                static void Method_5()
                {
                    /*
                        --- 5 - Type Casting! ---
                    */
                    // type casting   = Converting a value to a different data type.
                    //                  Useful when we accept user input (string).
                    //                  Different data types can do different things.

                    double a = 3.14;            // double aka decimal
                    Console.WriteLine($"\ndouble a = {a} = {a.GetType()}");

                    int b = Convert.ToInt32(a); // double gets converted to int aka whole number
                    Console.WriteLine($"double a as int b = {b} = {b.GetType()}");

                    string c = Convert.ToString(b);
                    Console.WriteLine($"int b as string c = {c} = {c.GetType()}\n");
                }

                static void Method_6()
                {
                    /*
                        --- 6 - User Input! ---
                    */
                    Console.WriteLine("\nWhats your name?");
                    string name = Console.ReadLine();

                    Console.WriteLine("Whats your age?");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Hello {name}! Your {age} years old.\n");

                }
                static void Method_7()
                {
                    /*
                        --- 7 - Arithmetic Operations! ---
                    */
                    int friends = 65;

                    friends = friends + 1;
                    friends = friends - 1;
                    friends = friends * 1;
                    friends = friends / 1;

                    friends += 2;
                    friends -= 2;
                    friends *= 2;
                    friends /= 2;

                    friends++;
                    friends--;

                    Console.WriteLine($"\nFriends: {friends}");

                    int remainder = friends % 3;

                    Console.WriteLine($"Remainder of Friends: {remainder}\n");

                }

                static void Method_8()
                {
                    /*
                        --- 8 - Math Class! ---
                    */

                    double x = 3.99;
                    double y = Math.Pow(x, 2);

                    Console.WriteLine(  // Print out results
                        "\nValues\n" +
                        "double x = 3.99;               // val: 3.99\n" +
                        "double y = Math.Pow(x, 2);     // val: 9.00\n\n" +

                        $"Math.Pow(x, y):   {Math.Pow(x, y)}\n" +  // Raise the value to the power of someting else.
                        $"Math.Sqrt(x):     {Math.Sqrt(x)}\n" +    // Get the Square root of a value.
                        $"Math.Abs(x):      {Math.Abs(x)}\n" +     // Get the absolute number of a value.
                        $"Math.Round(x):    {Math.Round(x)}\n" +   // Round a value.
                        $"Math.Ceiling(x):  {Math.Ceiling(x)}\n" + // Round up.
                        $"Math.Floor(x):    {Math.Floor(x)}\n" +   // Round down.
                        $"Math.Max(x, y):   {Math.Max(x, y)}\n"    // Get the max between two values.
                        );
                }

                static void Method_9()
                {
                    /*
                        --- 9 - Random Numbers! ---
                    */

                    Random random = new Random();   // Initializes a new instance of the Random class

                    int numa = random.Next(0, 100);     // Returns a random integer that is within a specified range.
                    double numb = random.NextDouble();  // Returns a random floating-point number that is greater than or equal to 0.0, and less than 1.0.

                    Console.WriteLine(
                        "\nRandom random = new Random();   // Initializes a new instance of the Random class\n\n" +

                        $"random.Next(0, 100):   {numa}\n" +
                        $"random.NextDouble():     {numb}\n\n"
                    );
                }

                // Remove/Add comment to enable/disable a function.

                //Method_1();
                //Method_2();
                //Method_3();
                //Method_4();
                //Method_5();
                //Method_6();
                //Method_7();
                //Method_8();
                Method_9();
            }

            Practice();
        }
    }
}