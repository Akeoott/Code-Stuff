// Copyright (c) Ame aka Akeoott <ame@akeoot.org>. Licensed under the LGPL-3.0 License.
// See the LICENSE file in the repository root for full license text.

namespace Practice;

//! --- Helper methods (Use these as reference!) --- :
#pragma warning disable

internal static class Methods
{
    internal static void Method_23_Helper(string birthdayGirl, int age)
    {
        Console.WriteLine($"Happy birthday to {birthdayGirl}!");
        Console.WriteLine($"Happy birthday to {birthdayGirl}!");
        Console.WriteLine($"Happy birthday dear {birthdayGirl.ToUpper()}!");
        Console.WriteLine($"You're {age} years old!");
        Console.WriteLine($"Happy birthday to {birthdayGirl}!");
        Console.WriteLine($"This kinda feels dry...\n");
    }

    internal static double Method_24_Helper(double x, double y)
    {
        double z = x * y;
        return z;
        /*
        One could also shorten it:
        return x * y;
        */
    }

    internal static double Method_25_Helper(double x, double y)
    {
        return x * y;
    }
    internal static double Method_25_Helper(double x, double y, double z)
    {   // Same name, different method, different parameters.
        return x * y * z;
    }

    internal static double Method_26_Helper(params double[] prices)
    {
        double total = 0;

        foreach (double price in prices)
        {
            total += price;
        }
        return total;
    }

    internal static void Method_39_Helper(Classes.Class_39 car, string color)  // Would call this method "ChangeColor" if it wasn't for practice.
    {   // Changes color of an existing object
        car.color = color;
    }
    internal static Classes.Class_39 Method_39_Helper1(Classes.Class_39 car)  // Would call this method "Copy" if it wasn't for practice.
    {   // Copies an object and makes a new one
        return new Classes.Class_39(car.model, car.color);
    }

    internal static double Method_48_Helper(double radius) // Would call this method "Volume" if it wasn't for practice.
    {
        double volume;
        // calculate volume of sphere
        return volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
    }

    // Generic method. Uses type parameter <Thing>.
    // Generic parameter can have any name, but by convention it's usually T or something descriptive.
    // This method works with arrays of any type which is great for code reusability.
    internal static void Method_48_Helper<Thing>(Thing[] array)
    {
        foreach (Thing item in array)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }

    internal static void Method_50_Helper(string name) // Would call this method "CountDown" if it wasn't for practice.
    {
        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine($"Thread '{name}': {i}");
            Thread.Sleep(1000); // Pause for 1 second
        }
        Console.WriteLine($"Timer 1# '{name}' finished!");
    }
    internal static void Method_50_Helper1(string name) // Would call this method "CountUp" if it wasn't for practice.
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"Thread '{name}': {i}");
            Thread.Sleep(1000); // Pause for 1 second
        }
        Console.WriteLine($"Timer 2# '{name}' finished!");
    }
}
