// Copyright (c) Akeoott <amejanin00@gmail.com>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Diagnostics.Tracing;
using System.Net.Sockets;
using System.Reflection.Metadata;

// Disabeling warnings for practice
//#pragma warning disable CA5394, CS8321, CS8600, CA1305
#pragma warning disable

/*
    C# compilation
*/
//? --- Basic Development and Testing ---
// `dotnet run`                 //? Run directly (no executable created)
// `dotnet build`               //? Build without publishing (creates DLLs in bin/)
// `dotnet build -c Release`    //? Build optimized but still development-friendly

//? --- Single File Executables ---
// `dotnet publish -c Release -r linux-x64 --self-contained true -p:PublishSingleFile=true -o ./builds/linux/`  //? linux bin
// `dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -o ./builds/windows/`  //? windows exe
// `dotnet publish -c Release -r osx-x64 --self-contained true -p:PublishSingleFile=true -o ./builds/macos/`    //? mac app

//? Dont forget to make the program executable!
// `chmod +x ./program`

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Warning! It's highly recomended to use the source code as reference.\nIt's necessary to remove comments from within the source code to enable and dissable methods.\n");

            /*  List of themes covered here (aka things that are gonna get covered in the future):
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

                Console.Write("\nOh, ");           // Just writing this into anything that exists! No new line.
                Console.WriteLine("Hello World!"); // Literally a new line with this text
                Console.Beep();                    // Makes a BEEP sound on some devices. Depends

                //? NIGER im a comment

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
                // int  = intiger = a whole number.

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
                // constants    = immutable values which are known at compile time,
                //                and do not change for the life of the program.

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
                // type casting = Converting a value to a different data type.
                //                  Useful when we accept user input (string).
                //                  Different data types can do different things.

                double a = 3.14;            // double aka decimal
                Console.WriteLine($"\ndouble a = {a} = {a.GetType()}"); // GetType displays what data type it is (in this case a double)

                int b = Convert.ToInt32(a); // double gets converted to an int aka whole number in the 32-bit range
                Console.WriteLine($"double a as int b = {b} = {b.GetType()}");

                string c = Convert.ToString(b);
                Console.WriteLine($"int b as string c = {c} = {c.GetType()}\n");

                //! NOTE: There are a lot of data types and a lot of ways to convert data into a different type. Not everything is here!
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
                else if (age < 0) // If the if statement above isnt right, this will be next
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
                // switch   = an efficient alternative to many else if statements

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
                        Console.WriteLine("It's Saturday!");
                        break;
                    case "Su":
                        Console.WriteLine("It's Sunday!");
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

            static void Method_17()
            {
                /*
                    --- 17 - Nested Loops! ---
                */
                // nested loops = loops inside of other loops.
                //                Uses vary. Used a lot in sorting algorithms.

                Console.Write("How many rows?: ");
                int rows = Convert.ToInt32(Console.ReadLine());

                Console.Write("How many columns?: ");
                int columns = Convert.ToInt32(Console.ReadLine());

                Console.Write("What symbol?: ");
                string str = Console.ReadLine();

                /*
                For loop 1 will immediately go in for loop 2
                For loop 2 will write the entire column,
                then loop 1 will add a new row.
                This will repeat till the box is finished!
                */
                for (int i = 0; i < rows; i++)          // loop 1
                {
                    for (int j = 0; j < columns; j++)   // loop 2
                    {
                        Console.Write(str);         // string/symbol
                    }
                    System.Console.WriteLine();     // newline
                }
            }

            static void Method_18()
            {
                /*
                    --- 18 - Number Guessing Game! ---
                */

                Random random = new Random();   // Init random

                int range;              // Set range for random
                int rand;               // Generated random number
                int input;          // User input
                int attempt;        // Amount of guesses
                string response = "y";  // Should repeat game
                bool playAgain = true;  // Repeat/don't repeat the game

                Console.WriteLine("Number Guessing Game!");
                Console.Write("What range should the random number have? (from 1 to x): x = ");
                range = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nGood luck ;)");

                while (playAgain)
                {
                    // Reset game
                    rand = random.Next(1, range + 1);   // generate a num from range 1 to whatever is selected ("range")
                    input = 0;
                    attempt = 0;

                    // Start game
                    while (input != rand)
                    {
                        attempt++;  // Add attempt
                        Console.Write($"\nAttempt {attempt}: ");
                        input = Convert.ToInt32(Console.ReadLine());

                        if (input == rand)
                        {
                            Console.WriteLine($"YOU WON!\n\nAI: {rand}\nYou: {input}\nAttempts {attempt}");
                        }
                        else if (input > rand)
                        {
                            Console.WriteLine("Try a smaller number!");
                        }
                        else
                        {
                            Console.WriteLine("Try a bigger number!");
                        }
                    }

                    Console.Write("Wanna play again? (Y/n): ");
                    response = Console.ReadLine();
                    response = response.ToLower();
                    playAgain = (response == "y");  // Automatically becomes true/false depending if the statement is true or false.

                    if (!playAgain)  // (playAgain) checks if its true.
                    {               // (!playAgain) checks if its NOT true.
                        Console.WriteLine("\nSee you next time :3");
                    }
                    else
                    {
                        Console.WriteLine("\nTime for another round!");
                    }
                }
                // Thank you python knowledge for making this easy. I wrote this really fast on my own without help!
            }

            static void Method_19()
            {
                /*
                    --- 19 - Rock-Paper-Scissors Game! ---
                */

                // Init variables or some shit
                Random random = new Random(); // Init random
                string userName = "";
                string userInput;
                string computerInput;
                int userTies = 0;
                int userWins = 0;
                int userLosses = 0;
                string playAgainAsk = "";
                bool playAgain = true;

                // Get name cuz why not
                while (userName.Length <= 2)
                {
                    Console.Write("Enter your name!: ");
                    userName = Console.ReadLine();

                    if (userName.Length <= 2)
                    {
                        Console.WriteLine("Your name is too short.");
                    }
                }
                Console.WriteLine($"\nHello {userName}!\nWelcome to this Rock-Paper-Scissors Game!");

                while (playAgain)
                {
                    // Reste inputs
                    userInput = "";
                    computerInput = "";

                    // Get inputs
                    while (userInput != "rock" && userInput != "paper" && userInput != "scissors")
                    {
                        Console.Write("Enter Rock, Paper or Scissors: ");
                        userInput = Console.ReadLine();
                        userInput = userInput.ToLower();
                    }

                    // Get random choice
                    switch (random.Next(1, 4))
                    {
                        case 1:
                            computerInput = "rock";
                            break;
                        case 2:
                            computerInput = "paper";
                            break;
                        case 3:
                            computerInput = "scissors";
                            break;
                    }
                    Console.WriteLine($"\nAI: {computerInput}\nYou: {userInput}");

                    // Game logic (decide who wins)
                    switch (userInput)
                    {
                        case "rock":
                            if (computerInput == "rock")
                            {
                                Console.WriteLine("Its a tie!");
                                userTies++;
                            }
                            else if (computerInput == "scissors")
                            {
                                Console.WriteLine($"{userName}, you won!");
                                userWins++;
                            }
                            else
                            {
                                Console.WriteLine($"{userName}, you lost...");
                                userLosses++;
                            }
                            break;
                        case "paper":
                            if (computerInput == "paper")
                            {
                                Console.WriteLine("Its a tie!");
                                userTies++;
                            }
                            else if (computerInput == "rock")
                            {
                                Console.WriteLine($"{userName}, you won!");
                                userWins++;
                            }
                            else
                            {
                                Console.WriteLine($"{userName}, you lost...");
                                userLosses++;
                            }
                            break;
                        case "scissors":
                            if (computerInput == "scissors")
                            {
                                Console.WriteLine("Its a tie!");
                                userTies++;
                            }
                            else if (computerInput == "paper")
                            {
                                Console.WriteLine($"{userName}, you won!");
                                userWins++;
                            }
                            else
                            {
                                Console.WriteLine($"{userName}, you lost...");
                                userLosses++;
                            }
                            break;
                    }

                    // Check if player wants to retry
                    Console.WriteLine($"\nTies: {userTies}\nWins: {userWins}\nLosses: {userLosses}");
                    Console.Write("\nWanna play again? (Y/n): ");
                    playAgainAsk = Console.ReadLine();
                    playAgainAsk = playAgainAsk.ToLower();

                    if (playAgainAsk == "n")
                    {
                        Console.WriteLine("See you next time :3");
                        playAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("Time for another round!\n");
                        playAgain = true;
                    }
                    // Its 6:36 AM at the time of writing this comment. IM DEAD! Havent sleept lol...
                }
            }

            static void Method_20()
            {
                /*
                    --- 20 - Calculator Program! ---
                */

                Console.WriteLine($"------------------\nCalculator Program\n------------------");
                do
                {
                    double num1 = 0;
                    double num2 = 0;
                    string operType = "";
                    double result = 0;

                    Console.Write("\nEnter your first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter your second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Options:");
                    Console.WriteLine("\t+ : Add\n\t- : Subtract\n\t* : Multiply\n\t/ : Divide");
                    Console.Write("Enter: ");
                    operType = Console.ReadLine();

                    switch (operType)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            result = num1 / num2;
                            break;
                        default:
                            Console.WriteLine("An error occured. Did you enter the right operation?");
                            break;
                    }
                    Console.WriteLine($"Result: {num1} {operType} {num2} = {result}");

                    Console.Write("\nWanna make another calculation? (Y/n): ");
                } while (Console.ReadLine().ToLower() == "y");
                Console.WriteLine("See you next time :3");
            }

            static void Method_21()
            {
                /*
                    --- 21 - Arrays! ---
                */
                // array    = a variable that can store multiple values. fixed size.

                // Index starts from zero. So here are values under index 0, 1 and 2
                string[] justCars = { "BMW", "Porsche", "Corvette" };   // Completely fixed size and already asigned values!

                string[] cars = new string[4];  // Declared first to allow empty values while keeping size!
                cars[0] = "BMW";        // Assigning value to array
                cars[1] = "Porsche";
                cars[2] = "Corvette";

                cars[0] = "Tesla";      // Modifying value in array

                for (int i = 0; i < cars.Length; i++)   // i in its first itteration is 0
                {
                    Console.WriteLine(cars[i]);
                }
            }

            static void Method_22()
            {
                /*
                    --- 22 - Foreach Loop! ---
                */
                // foreach loop = a simpler way to iterate over an array, it's less flexible.

                string[] cars = { "BMW", "Porsche", "Corvette" };

                foreach (string car in cars)
                {            // car is like a nickname for cars.
                    Console.WriteLine(car);
                }
            }

            static void Method_23()
            {
                /*
                    --- 23 - Methods! ---
                */
                // method       = performs a section of code, whenever it's called (aka invoked).
                //                benefit: Let's us reuse code w/o writting it multiple times.
                // arguments    = what is sent to methods

                string name = "Akeoott";
                int age = 16;

                //? void in the example method below means that its gonna return nothing
                // static void Method_23_Helper(...)
                Method_23_Helper(name, age); // Sings happybirthday once with the passed in argument.
                Method_23_Helper(name, age); // In method, one can rename them.
                Method_23_Helper(name, age); // Arguemtns must match in caller and method.
            }

            static void Method_24()
            {
                /*
                    --- 24 - Return Keyword! ---
                */
                // return   = returns data back to the place where a method was invoked

                //? void in the example method below means that its gonna return a double
                // static double Method_23_Helper(...)

                double x;
                double y;
                double result;

                Console.WriteLine("Calculating x * y while using a method aka function to do all the work!");

                Console.Write("Enter a decimal number for x: ");
                x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter a decimal number for y: ");
                y = Convert.ToDouble(Console.ReadLine());

                result = Method_24_Helper(x, y);
                Console.Write($"Result: {result}");
            }

            static void Method_25()
            {
                /*
                    --- 25 - Method Overloading! ---
                */
                // method overloading   = methods share same name, but different parameters
                //                        name + parameters = signature
                //                        methods must have a unique signature

                double x = 43;
                double y = 234;
                double z = 2;
                double result1;
                double result2;

                result1 = Method_25_Helper(x, y);
                Console.Write($"Result: {result1}");

                result2 = Method_25_Helper(x, y, z); // Same name, different method, different parameters.
                Console.Write($"Result: {result2}");

                //! NOTE: The next method (26) will cover a BETTER alternative to method overloading. The params keyword.
            }

            static void Method_26()
            {
                /*
                    --- 26 - Params Keyword! ---
                */
                // params keyword  = a method parameter that takes a variable number of arguments.
                //                    the parameter type must be a singe - dimentional array

                //? params allows a variable amount of arguments! (But only one parameter)
                // ... Method_26_Helper(params double[] prices)

                double total = Method_26_Helper(3.99, 5.75, 15);
                Console.Write($"Result: {total}");

            }

            static void Method_27()
            {
                /*
                    --- 27 - Exception Handling! ---
                */
                // try      = try some code that is considered "dangerous"
                // catch    = catches and handles exceptions when they occur
                // finally  = always executes regardless if exception is cought or not

                double x;
                double y;
                double result;

                try
                {
                    Console.WriteLine("Divide first number with second number!");

                    Console.WriteLine("Enter first number: ");
                    x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter second number: ");
                    y = Convert.ToDouble(Console.ReadLine());

                    result = x / y;

                    Console.WriteLine($"Result: {result}");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Enter ONLY numbers you DUMM DUMM!");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("You cant divide by zero you DUMM DUMM!");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Something unexpected went wrong!\n{e}");
                }
                finally
                {
                    Console.WriteLine("Bye bye!");
                }
            }

            static void Method_28()
            {
                /*
                    --- 28 - Conditional Operator! ---
                */
                // conditional operator = used in conditional assignment if a condition is true/false

                // (condition) ? x : y
                // (a == b) ? variable1 : variable2
                // variable1 is used if the condition is true.

                double temp = 20;
                string message;

                /*
                    / //! Either use if else statements

                    if (temp >= 15)
                    {
                        message = "It's warm outside";
                    }
                    else
                    {
                        message = "It's cold outside";
                    }

                    / //! OR use conditional operators!

                    message = (temp >= 15) ? "It's warm outside" : "It's cold outside";
                */

                // One liner for conditional operation and writing to console!
                Console.WriteLine(message = (temp >= 15) ? "It's warm outside" : "It's cold outside");
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
            //Method_16();
            //Method_17();
            //Method_18();
            //Method_19();
            //Method_20();
            //Method_21();
            //Method_22();
            //Method_23();
            //Method_24();
            //Method_25();
            //Method_26();
            //Method_27();
            Method_28();
        }

        static void Method_23_Helper(string birthdayGirl, int age)
        {
            Console.WriteLine($"Happy birthday to {birthdayGirl}!");
            Console.WriteLine($"Happy birthday to {birthdayGirl}!");
            Console.WriteLine($"Happy birthday dear {birthdayGirl.ToUpper()}!");
            Console.WriteLine($"You're {age} years old!");
            Console.WriteLine($"Happy birthday to {birthdayGirl}!");
            Console.WriteLine($"This kinda feels dry...\n");
        }
        static double Method_24_Helper(double x, double y)
        {
            double z = x * y;
            return z;
            /*
            One could also shorten it:
            return x * y;
            */
        }
        static double Method_25_Helper(double x, double y)
        {
            return x * y;
        }
        static double Method_25_Helper(double x, double y, double z)
        {   // Same name, different method, different parameters.
            return x * y * z;
        }
        static double Method_26_Helper(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }
            return total;
        }
    }
}
