// Copyright (c) Akeoott <amejanin00@gmail.com>. Licensed under the LGPL-3.0 License.
// See the LICENSE file in the repository root for full license text.

//! NOTE: The code below was intentionally made to be simple and possibly insecure for production code.
//!       I'm simply learning syntax here and I am not going to make this code secure or stable.
//!       DON'T take this code and the comments as a reliable source of information about C#.
//!       As stated in the License, its not my fault if you do something bad with this code
//!       or the information obtained thru my comments. Anyway, have fun reading!
//!       (Heh I don't expect anyone to see this file anyway)

// Disabling warnings for practice
#pragma warning disable

/*
    C# compilation
*/

//? --- Basic Development and Testing ---
// `dotnet run`                 //? Run directly (no executable created)
// `dotnet build`               //? Build without publishing (creates DLLs in bin/)
// `dotnet build -c Release`    //? Build optimized but still development-friendly

//? --- Single File Executables ---
// `dotnet publish -c Release -r linux-x64 --self-contained true -p:PublishSingleFile=true -o ./builds/linux/`  //? Linux bin
// `dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -o ./builds/windows/`  //? Windows exe
// `dotnet publish -c Release -r osx-x64 --self-contained true -p:PublishSingleFile=true -o ./builds/macos/`    //? Mac app

//? Don't forget to make the program executable!
// `chmod +x ./program`

// わたしはあめちゃん

using System;
using System.Collections.Generic;

namespace Practice;

internal class Program
{
    internal static void Main(string[] args)
    {
        string startWarning =
            "Warning! It's highly recommended to use the source code as reference.\n" +
            "It's necessary to remove comments from within the source code to enable and disable methods.\n";
        Console.WriteLine(startWarning);

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

        //? NOTE: All method and class helpers are in a dedicated folder called `helper`.

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
            Console.Beep();                    // Makes a BEEP sound on some devices. It depends

            //? NIGERIA IS COOL, I'm a comment btw.

            /*
            I'm a multi fucking line comment
            HELL YEAH
            */

            Console.WriteLine("AKEOOT!\n");

            Console.ReadKey(); // Requires input to continue/exit/finish operation! Kinda like input() from python.
        }

        static void Method_3()
        {
            /*
                --- 3 - Variables! ---
            */
            //  int = integer = a whole number.

            int x;       // declaration
            x = 123;     // initialization
            int y = 321; // declaration + initialization

            int z = x + y; // Adding two integer

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

            Console.WriteLine($"[Type]\t  [Data]\t|  [Description]");
            Console.WriteLine($"int\t= {whole_num}\t\t|  int aka a whole number");
            Console.WriteLine($"double\t= {decimal_num}\t\t|  double aka a decimal number");
            Console.WriteLine($"bool\t= {boolean}\t\t|  bool aka true or false");
            Console.WriteLine($"char\t= {symbol}\t\t|  char aka a single character");
            Console.WriteLine($"string\t= {name}\t|  string aka a series of characters");
            Console.WriteLine($"int\t= {whole_num}\t\t|  int aka a whole number\n");
        }

        static void Method_4()
        {
            /*
                --- 4 - Constants! ---
            */
            //  constants   = immutable values which are known at compile time,
            //                and do not change for the life of the program.

            // The value pi cannot be changed cause its a constant!
            // If it wasn't a constant, then i would be able to change the value.
            const double pi = 3.14159;

            Console.WriteLine($"\npi is a constant so it cant get changed!: {pi}\n");
        }

        static void Method_5()
        {
            /*
                --- 5 - Type Casting! ---
            */
            //  type casting    = Converting a value to a different data type.
            //                    Useful when we accept user input (string).
            //                    Different data types can do different things.

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
            string name = Console.ReadLine(); // Reads input and assigns it to a var

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

                $"Math.Pow(x, y):   {Math.Pow(x, y)}\n" +  // Raise the value to the power of something else.
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
            else if (age < 0) // If the if statement above isn't right, this will be next
            {
                Console.WriteLine("You don't even exist yet ;-;");
            }
            else if (age >= 18)
            {
                Console.WriteLine("Your old enough to visit adult websites!");
            }
            else // If nothing is right, this will always execute
            {
                Console.WriteLine("Your NOT old enough to visit adult websites!");
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
            //  switch  = an efficient alternative to many else if statements

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
                    Console.WriteLine($"I don't know what {day} is...");
                    break;
            }
        }

        static void Method_14()
        {
            /*
                --- 14 - Logical Operators! ---
            */
            //  logical operators   = Can be used to check if more than 1 condition is true/false

            //  && (AND)
            //  || (OR)

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
            Console.WriteLine($"YO WHATS UP {name.ToUpper()} MA NIGGA!");
        }

        static void Method_16()
        {
            /*
                --- 16 - For Loops! ---
            */
            //  for loop    = repeats some code a finite amount of time.

            // First one    (int i = 1) is a way to keep track of which iteration this loop is on!
            // Second one   (i < 10)    tells us when to stop the loop (If index hits a certain value).
            // Third one    (i += 1)    says how much should be added/removed to "i" after every loop.

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
            //  nested loops    = loops inside of other loops.
            //                    Uses vary. Used a lot in sorting algorithms.

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

            int range;      // Set range for random
            int rand;       // Generated random number
            int input;      // User input
            int attempt;    // Amount of guesses
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
                // Reset inputs
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
                // Its 6:36 AM at the time of writing this comment. IM DEAD! haven't slept lol...
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
                string oprType = "";
                double result = 0;

                Console.Write("\nEnter your first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter your second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Options:");
                Console.WriteLine("\t+ : Add\n\t- : Subtract\n\t* : Multiply\n\t/ : Divide");
                Console.Write("Enter: ");
                oprType = Console.ReadLine();

                switch (oprType)
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
                        Console.WriteLine("An error occurred. Did you enter the right operation?");
                        break;
                }
                Console.WriteLine($"Result: {num1} {oprType} {num2} = {result}");

                Console.Write("\nWanna make another calculation? (Y/n): ");
            } while (Console.ReadLine().ToLower() == "y");
            Console.WriteLine("See you next time :3");
        }

        static void Method_21()
        {
            /*
                --- 21 - Arrays! ---
            */
            //  array   = a variable that can store multiple values. fixed size.

            // Index starts from zero. So here are values under index 0, 1 and 2
            string[] justCars = { "BMW", "Porsche", "Corvette" };   // Completely fixed size and already assigned values!

            string[] cars = new string[4];  // Declared first to allow empty values while keeping size!
            cars[0] = "BMW";        // Assigning value to array
            cars[1] = "Porsche";
            cars[2] = "Corvette";

            cars[0] = "Tesla";      // Modifying value in array

            for (int i = 0; i < cars.Length; i++)   // i in its first iteration is 0
            {
                Console.WriteLine(cars[i]);
            }
        }

        static void Method_22()
        {
            /*
                --- 22 - Foreach Loop! ---
            */
            //  foreach loop    = a simpler way to iterate over an array, it's less flexible.

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
            //  method      = performs a section of code, whenever it's called (aka invoked).
            //                benefit: Let's us reuse code w/o writing it multiple times.
            //  arguments   = what is sent to methods

            //  Helper:
            //      Method_23_Helper

            string name = "Akeoott";
            int age = 16;

            //? void in the example method below means that its gonna return nothing
            // static void Method_23_Helper(...)
            Methods.Method_23_Helper(name, age); // Sings happy birthday once with the passed in argument.
            Methods.Method_23_Helper(name, age); // In method, one can rename them.
            Methods.Method_23_Helper(name, age); // Arguments must match in caller and method.
        }

        static void Method_24()
        {
            /*
                --- 24 - Return Keyword! ---
            */
            //  return  = returns data back to the place where a method was invoked

            //  Helper:
            //      Method_24_Helper

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

            result = Methods.Method_24_Helper(x, y);
            Console.Write($"Result: {result}");
        }

        static void Method_25()
        {
            /*
                --- 25 - Method Overloading! ---
            */
            //  method overloading  = methods share same name, but different parameters
            //                        name + parameters = signature
            //                        methods must have a unique signature

            //  Helper:
            //      Method_25_Helper (two)

            double x = 43;
            double y = 234;
            double z = 2;
            double result1;
            double result2;

            result1 = Methods.Method_25_Helper(x, y);
            Console.Write($"Result: {result1}");

            result2 = Methods.Method_25_Helper(x, y, z); // Same name, different method, different parameters.
            Console.Write($"Result: {result2}");

            //! NOTE: The next method (26) will cover a BETTER alternative to method overloading. The params keyword.
        }

        static void Method_26()
        {
            /*
                --- 26 - Params Keyword! ---
            */
            //  params keyword  = a method parameter that takes a variable number of arguments.
            //                    the parameter type must be a singe - dimensional array

            //  Helper:
            //      Method_26_Helper

            //? params allows a variable amount of arguments! (But only one parameter)
            // ... Method_26_Helper(params double[] prices)

            double total = Methods.Method_26_Helper(3.99, 5.75, 15);
            Console.Write($"Result: {total}");

        }

        static void Method_27()
        {
            /*
                --- 27 - Exception Handling! ---
            */
            //  try     = try some code that is considered "dangerous"
            //  catch   = catches and handles exceptions when they occur
            //  finally = always executes regardless if exception is caught or not

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
            // Pretty self explanatory so not many comments i guess.
        }

        static void Method_28()
        {
            /*
                --- 28 - Conditional Operator! ---
            */
            //  conditional operator    = used in conditional assignment if a condition is true/false

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

        static void Method_29()
        {
            /*
                --- 29 - String Interpolation! ---
            */
            //  string interpolation    = allows us to insert variables into a string literal
            //                            precede a string literal with $
            //                            { } are placeholders
            //?                           This has been used around the entire file already!
            //?                           Now its simply getting its own method for explanation.

            string firstName = "Ame";
            string lastName = "Janin";
            int age = 16;

            // Bad slow way:
            Console.WriteLine("Hello " + firstName + " " + lastName + ".");
            Console.WriteLine("You are " + age + " years old.");

            // GOOD fast way:
            Console.WriteLine($"Hello {firstName} {lastName}.");
            Console.WriteLine($"You are {age} years old.");
        }

        static void Method_30()
        {
            /*
                --- 30 - Multidimensional Arrays! ---
            */

            // This may be a difficult to understand topic,
            // so its okay if you skip this and tackle it later!

            string[] ford = { "Mustang", "F-150", "Explorer" };
            string[] chevy = { "Corvette", "Camaro", "Silverado" };
            string[] toyota = { "Corolla", "Camry", "Rav4" };
            // The arrays above are basically the multidimensional array below
            string[,] parkingLot = {
                { "Mustang", "F-150", "Explorer" },
                { "Corvette", "Camaro", "Silverado" },
                { "Corolla", "Camry", "Rav4" }
            };

            // Basically [row 0, column 2] which targets the "Explorer"
            // Remember, arrays start at 0!
            parkingLot[0, 2] = "Fusion";

            foreach (string cars in parkingLot)
            {
                Console.WriteLine(cars);
            }

            Console.WriteLine();

            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write($"{parkingLot[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static void Method_31()
        {
            /*
                --- 31 - Classes! ---
            */
            //  class   = a bundle of related code.
            //            can be used as a blueprint to create objects (OOP)

            //  Helper:
            //      Class_31

            // For example, the math class contains a bunch of code relating to math!
            Math.Round(3.14);
            Math.Abs(-3.14);
            Math.Pow(2, 3);

            //? An example class is below the practice function aka everything here!

            Classes.Class_31.Hello();
            Classes.Class_31.Waiting();
            Classes.Class_31.Bye();
            // NOTE: Class_31 is in a separate file.
            //       More to it below in the class section of this file.
        }

        static void Method_32()
        {
            /*
                --- 32 - Objects! ---
            */
            //  object  = An instance of a class
            //            A class can be used as a blueprint to create objects (OOP)
            //            objects can have fields & methods (characteristics & actions)

            //  Helper:
            //      Class_32

            // We now created a "Class_32" object called "human1"
            Classes.Class_32 human1 = new Classes.Class_32(); // Would call the class "Human" if it wasn't for practice.
            // We now created another "Class_32" object called "human2" so we can reuse this class!
            Classes.Class_32 human2 = new Classes.Class_32();

            // Manually assigning variables
            human1.name = "Ame";
            human1.age = 16;

            human2.name = "The DARK Banana";
            human2.age = 666666;

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();
        }

        static void Method_33()
        {
            /*
                --- 33 - Constructors! ---
            */
            //  constructor = A special method in a class
            //                Same name as the class name
            //                Can be used to assign arguments to fields when creating an object

            //  Helper:
            //      Class_33

            // Pre constructed assignment of variables allows us to just pass them thru as arguments,
            // Without having to do it manually (As displayed in the pervious method.)
            Classes.Class_33 car1 = new Classes.Class_33("Ford", "Mustang", "red", 2022);
            Classes.Class_33 car2 = new Classes.Class_33("Chevy", "Corvette", "blue", 2021);

            car1.Drive();
            car2.Drive();
        }

        static void Method_34()
        {
            /*
                --- 34 - Static! ---
            */
            //  Static  = modifier to declare a static member, which belongs to the class itself
            //            rather than to any specific object

            //  Helper:
            //      Class_34

            // Note: if the class is static, one cant make objects out of it. Like the Math class.
            //       the class we are using tho isn't static.
            Classes.Class_34 car1 = new Classes.Class_34("Mustang");
            Classes.Class_34 car2 = new Classes.Class_34("Corvette");
            Classes.Class_34 car3 = new Classes.Class_34("Lambo");

            // Both will print out the number 1 because they are copies of the class aka they are objects and therefore independent.
            Console.WriteLine(car1.numberOfCars);
            Console.WriteLine(car2.numberOfCars);
            Console.WriteLine(car3.numberOfCars);

            // We have to do that in a static way. We do this by making the variable in the class static,
            // and by calling the class itself rather than the object of it.
            Console.WriteLine(Classes.Class_34.staticNumberOfCars);
            Console.WriteLine(Classes.Class_34.staticNumberOfCars);

            // A static method. All the objects share it instead of each one having its own method.
            Classes.Class_34.StartRace();
        }

        static void Method_35()
        {
            /*
                --- 35 - Overloaded Constructors! ---
            */
            //  overloaded constructors = technique to create multiple constructors,
            //                            with a different set of parameters.
            //                            name + parameters = signature

            //  Helper:
            //      Class_35

            Classes.Class_35 pizza = new Classes.Class_35("stuffed crust", "red sauce", "mozzarella", "pepperoni"); // 4 arguments
            Classes.Class_35 pizzaMozzarella = new Classes.Class_35("stuffed crust", "red sauce", "mozzarella"); // 3 arguments
        }

        static void Method_36()
        {
            /*
                --- 36 - Inheritance! ---
            */
            //  inheritance = 1 or more child classes receiving fields, methods, etc, from a common parent!

            //  Helper:
            //      Class_36
            //      Class_36_Helper1
            //      Class_36_Helper2
            //      Class_36_Helper3

            Classes.Class_36_Helper1 car = new Classes.Class_36_Helper1();
            Classes.Class_36_Helper2 bike = new Classes.Class_36_Helper2();
            Classes.Class_36_Helper3 boat = new Classes.Class_36_Helper3();

            Console.WriteLine(car.speed); // Speed is 0 cause we stated that in the class Class_36
            Console.WriteLine(car.wheels); // Wheels is 4 cause we stated that in the class Class_36_helper1
            car.go();

            Console.WriteLine(bike.speed);
            Console.WriteLine(bike.wheels);
            bike.go();

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.go();
        }

        static void Method_37()
        {
            /*
                --- 37 - Abstract Classes! ---
            */
            //  abstract classes    = modifier that indicates missing components or incomplete implementation

            //  Helper:
            //      Class_37
            //      Class_37_Helper1
            //      Class_37_Helper2
            //      Class_37_Helper3

            Classes.Class_37_Helper1 car = new Classes.Class_37_Helper1();
            Classes.Class_37_Helper2 bike = new Classes.Class_37_Helper2();
            Classes.Class_37_Helper3 boat = new Classes.Class_37_Helper3();

            // Lets say someone picks a method aka car to play in a race.
            // We wouldn't want a player picking a method that doesn't provide everything needed.
            // The abstract modifier prevents one from even making an object out of the abstract class.
            // This below doesn't work cause its trying to access an abstract class,
            // that isn't complete or missing components to perform the expected task.
            // This can be on purpose or simply cause it hasn't been completed yet.

            //? "Class_37 vehicle = new Class_37();" doesn't work on abstract classes.
        }

        static void Method_38()
        {
            /*
                --- 38 - Array Of Objects! ---
            */

            //  Helper:
            //      Class_38

            Classes.Class_38[] garage = new Classes.Class_38[3]; // The array containing the objects.

            Classes.Class_38 car1 = new Classes.Class_38("Mustang"); // An object
            Classes.Class_38 car2 = new Classes.Class_38("Corvette");
            Classes.Class_38 car3 = new Classes.Class_38("Lambo");

            garage[0] = car1; // Assigning the objects to the array
            garage[1] = car2;
            garage[2] = car3;

            Console.WriteLine(garage[0]); // Displaying what this object represents.
            Console.WriteLine(garage[1]);
            Console.WriteLine(garage[2]);

            Console.WriteLine();

            Console.WriteLine(garage[0].model); // Displaying what "model" represents in this object.
            Console.WriteLine(garage[1].model);
            Console.WriteLine(garage[2].model);

            Console.WriteLine();

            foreach (Classes.Class_38 car in garage)
            {
                Console.WriteLine(car.model); // Now iterating thru the array to display all models.
            }

            //  Optionally, we can make this a one liner as we learned before.
            //! NOTE: These are anonymous objects.
            //?       I wont cover them, but you gotta remember that there is some
            //?       difference between normal objects.

            Classes.Class_38[] anotherGarage = { new Classes.Class_38("Mustang"), new Classes.Class_38("Corvette"), new Classes.Class_38("Lambo") };
        }

        static void Method_39()
        {
            /*
                --- 39 - Objects As Arguments! ---
            */

            //  Helper:
            //      Method_39_Helper
            //      Method_39_Helper1
            //      Class_39

            // Passing in red mustang
            Classes.Class_39 car1 = new Classes.Class_39("Mustang", "red");

            // Changing color of mustang to silver without needing to re-assign it from within the class.
            // Makes things simpler, separate and reusable!
            Methods.Method_39_Helper(car1, "silver");

            // Here we copy car1 and make car2 with the same properties as car 1
            Classes.Class_39 car2 = Methods.Method_39_Helper1(car1);

            Console.WriteLine($"car1 {car1} {car1.color} {car1.model}");
            Console.WriteLine($"car2 {car2} {car2.color} {car2.model}");
        }

        static void Method_40()
        {
            /*
                --- 40 - Method Overriding! ---
            */
            //  method overriding   = provides a new version of a method inherited from a parent class
            //                        inherited method must be: abstract, virtual, or already overridden
            //                        Used with ToString(), polymorphism

            //  Helper:
            //      Class_40
            //      Class_40_Helper1
            //      Class_40_Helper2

            Classes.Class_40_Helper1 dog = new Classes.Class_40_Helper1();
            Classes.Class_40_Helper2 cat = new Classes.Class_40_Helper2();

            dog.Speak();
            cat.Speak();
        }

        static void Method_41()
        {
            /*
                --- 41 - ToString()! ---
            */
            //  ToString()  = converts an object to its string representation so that it is suitable for display

            //  Helper:
            //      Class_41

            // Less modern:
            Classes.Class_41 carExample = new Classes.Class_41("Chevy", "Corvette", "blue", 2022);
            // More modern:
            Classes.Class_41 car1 = new("Chevy", "Corvette", "blue", 2022);

            //? Look in Class_41 for more info.
            Console.WriteLine(car1.ToString());
            Console.WriteLine(car1);
        }

        static void Method_42()
        {
            /*
                --- 42 - Polymorphism! ---
            */
            //  polymorphism    = Greek word that means to "have many forms”
            //                    Objects can be identified by more than one type
            //                    Ex. A Dog is also: Canine, Animal, Organism

            //  Helper:
            //      Class_42
            //      Class_42_Helper1
            //      Class_42_Helper2
            //      Class_42_Helper3

            // All Class_Helper's inherit from Class_42
            Classes.Class_42_Helper1 car = new();
            Classes.Class_42_Helper2 bicycle = new();
            Classes.Class_42_Helper3 boat = new();

            // Only cause all of these classes inherit from Class_42,
            // can I put all these objects in one array.
            Classes.Class_42[] vehicles = { car, bicycle, boat };

            // Call the `Go` method on each object in the `vehicles` array.
            // The objects in this array are subclasses of `Class_42` and have overridden the `Go` method defined in the `Class_42` base class.

            vehicles[0].Go();
            vehicles[1].Go();
            vehicles[2].Go();

            Console.WriteLine();

            foreach (Classes.Class_42 vehicle in vehicles)
            {
                vehicle.Go();
            }
        }

        static void Method_43()
        {
            /*
                --- 43 - Interface! ---
            */
            //  interface   = defines a “contract” that all the classes inheriting from should follow

            //                An interface declares "what a class should have"
            //                An inheriting class defines "how it should do it"

            //                Benefit = security + multiple inheritance + "plug-and-play"

            //  Helper:
            //      Interfaces:
            //          IClass_43_1
            //          IClass_43_2
            //      Classes:
            //          Class_43_1
            //          Class_43_2
            //          Class_43_3

            // from IClass_43_1 interface representing prey
            Classes.Class_43_1 rabbit = new();

            // from IClass_43_2 interface representing predator
            Classes.Class_43_2 hawk = new();

            // from IClass_43_1 and IClass_43_2 interface representing prey and predator
            Classes.Class_43_3 fish = new();

            rabbit.Flee();
            hawk.Hunt();

            fish.Flee();
            fish.Hunt();
        }

        static void Method_44()
        {
            /*
                --- 44 - Lists! ---
            */
            //  lists   = data structure that represents a list of objects that can be accessed by index.
            //            Similar to array, but can dynamically increase/decrease in size
            //            using System.Collections.Generic;

            //  note    : a list uses more memory than an array

            List<string> foodList = new List<string>();

            foodList.Add("pizza");
            foodList.Add("hamburger");
            foodList.Add("hotdog");
            foodList.Add("sushi");

            // Can dynamically add things to a list.
            foodList.Add("fries");

            // Can dynamically remove things from a list.
            foodList.Remove("fries");

            // Can dynamically insert things to a list.
            foodList.Insert(0, "sushi");

            // Get the size of a list.
            Console.WriteLine(foodList.Count);

            // Get the index of an item.
            Console.WriteLine(foodList.IndexOf("pizza"));

            // Get the last index of an item.
            Console.WriteLine(foodList.LastIndexOf("sushi"));

            // Check if a list contains a specific item.
            Console.WriteLine(foodList.Contains("pizza"));

            // Alphabetically sort a list (from A to Z).
            foodList.Sort();

            // Reverse Alphabetically sort a list (from Z to A).
            foodList.Reverse();

            // Clears entire list.
            foodList.Clear();

            // Convert list to array.
            string[] foodArray = foodList.ToArray();

            // Display the content of the list and array.
            foreach (string food in foodList)
            {
                Console.WriteLine(food);
            }

            foreach (string food in foodArray)
            {
                Console.WriteLine(food);
            }
        }

        static void Method_45()
        {
            /*
                --- 45 - List Of Objects! ---
            */

            //  Helper:
            //      Class_45

            // make a list
            List<Classes.Class_45> players = new();

            // make objects
            Classes.Class_45 player1 = new("Bob");
            Classes.Class_45 player2 = new("Chad");
            Classes.Class_45 player3 = new("Steve");

            // add objects to list
            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

            foreach (Classes.Class_45 player in players)
            {
                Console.WriteLine(player.userName);
            }

            // or make anonymous list

            // make a list
            List<Classes.Class_45> hidplayers = new();

            // make and add objects to list with no name
            hidplayers.Add(new("Bob"));
            hidplayers.Add(new("Chad"));
            hidplayers.Add(new("Steve"));

            foreach (Classes.Class_45 player in hidplayers)
            {
                Console.WriteLine(player.userName);
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
        //Method_28();
        //Method_29();
        //Method_30();
        //Method_31();
        //Method_32();
        //Method_33();
        //Method_34();
        //Method_35();
        //Method_36();
        //Method_37();
        //Method_38();
        //Method_39();
        //Method_40();
        //Method_41();
        //Method_42();
        //Method_43();
        //Method_44();
        Method_45();
    }
}
