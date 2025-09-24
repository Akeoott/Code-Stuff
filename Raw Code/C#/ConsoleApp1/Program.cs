using System;

// Disabeling warnings for practice
//#pragma warning disable CA5394, CS8321, CS8600, CA1305
#pragma warning disable

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Practice()
            {
                /*  List of themes covered here:
                |
                | ⇓ #1  the beginning                   | ⇓ #21 arrays                      | ⇓ #41 ToString method
                |   #2  output                          |   #22 foreach loop                |   #42 polymorphism
                |   #3  variables                       |   #23 methods                     |   #43 interfaces
                |   #4  constants                       |   #24 return keyword              |   #44 Lists
                |   #5  type casting                    |   #25 method overloading          |   #45 List of objects
                |   #6  user input                      |   #26 params keyword              |   #46 getters & setters
                |   #7  arithmetic operators            |   #27 exception handling          |   #47 auto implemented properties
                |   #8  Math class                      |   #28 conditional operator        |   #48 enums
                |   #9  random numbers                  |   #29 string interpolation        |   #49 generics
                |   #10 hypotenuse calculator program   |   #30 multidimensional arrays     |   #50 multithreading
                |   #11 string methods                  |   #31 classes                     |
                |   #12 if statements                   |   #32 objects                     |
                |   #13 switches                        |   #33 constructors                |
                |   #14 logical operators && ||         |   #34 static                      |
                |   #15 while loops                     |   #35 overloaded constructors     |
                |   #16 for loops                       |   #36 inheritance                 |
                |   #17 nested loops                    |   #37 abstract classes            |
                |   #18 number guessing game            |   #38 array of objects            |
                |   #19 rock-paper-scissors game        |   #39 objects as arguments        |
                |   #20 calculator program              |   #40 method overriding           |
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

                    // ? NIGER im a comment

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
                    Console.WriteLine($"\ndouble a = {a} = {a.GetType()}"); // GetType displays what data type it is (in this case a double)

                    int b = Convert.ToInt32(a); // double gets converted to an int aka whole number in the 32-bit range
                    Console.WriteLine($"double a as int b = {b} = {b.GetType()}");

                    string c = Convert.ToString(b);
                    Console.WriteLine($"int b as string c = {c} = {c.GetType()}\n");
                }

                static void Method_6()
                {
                    /*
                        --- 6 - User Input! ---
                    */
                    Console.Write("\nWhats your name?: ");
                    string name = Console.ReadLine(); // Reads input and asigns it to a var

                    Console.Write("Whats your age?: ");
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

                    friends++; // adds 1
                    friends--; // removes 1

                    Console.WriteLine($"\nFriends: {friends}");

                    int remainder = friends % 3; // gets the remainder of 3

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

                    int num_a = random.Next(0, 100);     // Returns a random integer that is within a specified range.
                    double num_b = random.NextDouble();  // Returns a random floating-point number that is greater than or equal to 0.0, and less than 1.0.

                    Console.WriteLine(
                        "\nRandom random = new Random();   // Initializes a new instance of the Random class\n\n" +

                        $"random.Next(0, 100):   {num_a}\n" +
                        $"random.NextDouble():   {num_b}\n\n"
                    );
                }

                static void Method_10()
                {
                    /*
                        --- 10 - Hypotenuse Calculator Program! ---
                    */

                    Console.Write("\nEnter side A: ");
                    double a = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter side B: ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    double c = Math.Sqrt((a * a) + (b * b));

                    Console.WriteLine($"\nThe hypotenuse is: {c}");
                }

                static void Method_11()
                {
                    /*
                        --- 11 - String Methods! ---
                    */

                    string fullName = "Ame Janin";
                    Console.WriteLine(fullName);

                    fullName = fullName.ToUpper(); // All upper case
                    Console.WriteLine(fullName);

                    fullName = fullName.ToLower(); // All lower case
                    Console.WriteLine(fullName);

                    int nameLength = fullName.Length; // Get the amount of characters as an int
                    Console.WriteLine(nameLength);

                    string firstName = fullName.Substring(0, 3); // Takes a part of a string in a set range
                    Console.WriteLine(firstName);

                    string lastName = fullName.Substring(0, 3);
                    Console.WriteLine(lastName);

                    string userName = firstName.Insert(0, "@"); // Adds a character at a specified place in a string
                    Console.WriteLine(userName);


                    string phoneNumber = "123-456-6677";
                    Console.WriteLine(phoneNumber);

                    Console.WriteLine(phoneNumber.Replace("-", "/")); // Replaces a specific character with something else
                    Console.WriteLine(phoneNumber.Replace("-", "@"));
                    Console.WriteLine(phoneNumber.Replace("-", " "));

                    string numbers = phoneNumber.Replace("-", "");
                    Console.WriteLine(numbers);
                }

                static void Method_12()
                {
                    /*
                        --- 12 - If Statements! ---
                    */

                    Console.Write("\nHow old are you?: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    if (age > 100)
                    {
                        Console.WriteLine("How are you so old unc 💀");
                    }
                    else if (age < 0) // If the one above isnt right, this will be next
                    {
                        Console.WriteLine("You dont even exist yet ;-;");
                    }
                    else if (age >= 18)
                    {
                        Console.WriteLine("Your old enought to visit adult websites!");
                    }
                    else // If nothing is right, this will always execute
                    {
                        Console.WriteLine("Your NOT old enought to visit adult websites!");
                    }

                    Console.Write("Whats you name?: ");
                    string name = Console.ReadLine();

                    if (name != "")
                    {
                        Console.WriteLine($"Hello {name}!");
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a name!");
                    }
                }

                static void Method_13()
                {
                    /*
                        --- 13 - Switches! ---
                    */
                    // switch = an efficient alternative to many else if statements

                    Console.Write("What day of the is it today? (Mo,Tu,We,Th,Fr,Sa,Su): ");
                    string day = Console.ReadLine();

                    switch (day)    // init cases in a switch
                    {
                        case "Mo":  // each case is like an if statement. if (day == "Mo") { Doing something }
                            Console.WriteLine("It's Monday!");
                            break;
                        case "Tu":
                            Console.WriteLine("It's Tuesday!");
                            break;
                        case "We":
                            Console.WriteLine("It's Wednesday!");
                            break;
                        case "Th":
                            Console.WriteLine("It's Thursday!");
                            break;
                        case "Fr":
                            Console.WriteLine("It's Friday!");
                            break;
                        case "Sa":
                            Console.WriteLine("It's Monday!");
                            break;
                        case "Su":
                            Console.WriteLine("It's Saturday!");
                            break;
                        default:
                            Console.WriteLine($"I dont know what {day} is...");
                            break;
                    }
                }

                static void Method_14()
                {
                    /*
                        --- 14 - Logical Operators! ---
                    */
                    // logical operators = Can be used to check if more than 1 condition is true/false

                    // && (AND)
                    // || (OR)

                    Console.Write("What's the fucking temperature outside? (°C): ");
                    double temp = Convert.ToDouble(Console.ReadLine());

                    if (temp >= 15 && temp <= 25) // Above 10 AND below 30 check
                    {
                        System.Console.WriteLine("The temp outside is perfect!");
                    }
                    else if (temp <= -50 || temp >= 50)
                    {
                        System.Console.WriteLine("Hey, how about you go for a walk!");
                    }
                }

                static void Method_15()
                {
                    /*
                        --- 15 - While Loops! ---
                    */

                    Console.Write("Enter your name: ");
                    string name = Console.ReadLine();

                    while (name.Length <= 2) // If name is 3 characters min long, the loop ends.
                    {
                        Console.Write("Enter your name: ");
                        name = Console.ReadLine();
                    }
                    Console.WriteLine($"YO WASSUP {name.ToUpper()} MA NIGGA!");
                }

                static void Method_16()
                {
                    /*
                        --- 16 - For Loops! ---
                    */
                    // for loop = repeats some code a finite amount of time.

                    // First one  (int i = 1)   is a way to keep track of which iteration this loop is on!
                    // Second one (i < 10)      tells us when to stop the loop (If index hits a certain value).
                    // Third one  (i += 1)      says how much should be added/removed to "i" after every loop.

                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"Index: {i}"); // Displays 1 to 10
                    }

                    for (int i = 10; i >= 1; i--)
                    {
                        Console.WriteLine($"Index: {i}"); // Displays 10 to 1
                    }
                }

                //* Remove/Add comment to enable/disable a function.

                //Method_1();
                //Method_2();
                //Method_3();
                //Method_4();
                //Method_5();
                //Method_6();
                //Method_7();
                //Method_8();
                //Method_9();
                //Method_10();
                //Method_11();
                //Method_12();
                //Method_13();
                //Method_14();
                //Method_15();
                Method_16();
            }

            //  =============================================================================================
            //  =-----------------------------------------Seperator-----------------------------------------=
            //  =============================================================================================

            static void TinyProjects()
            {
                static void Method_1()
                {
                    /*
                        --- Pseudo-random number hypotenuse calculator! ---
                    */

                    Random random = new Random(); // Init random

                    Console.WriteLine("\nPseudo-random number hypotenuse calculator!");
                    Console.Write("Select a decimal in the 32-bit range: ");
                    int range = Convert.ToInt32(Console.ReadLine());

                    double a = random.Next(0, range);
                    double b = random.Next(0, range);

                    Console.WriteLine(
                        $"\nGenerated random numbers:\n" +
                        $"A = {a}\n" +
                        $"B = {b}\n"
                        );

                    double result = Math.Sqrt((a * a) + (b * b));

                    Console.WriteLine($"\nThe hypotenuse is: {result}");
                }

                //* Remove/Add comment to enable/disable a function.

                Method_1();
            }

            //* Remove/Add comment to enable/disable an area.

            Practice();
            //TinyProjects();
        }
    }
}