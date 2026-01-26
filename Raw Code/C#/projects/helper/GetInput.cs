// Copyright (c) Ame (Akeoott) <ame@akeoot.org>. Licensed under the LGPL-3.0 License.
// See the LICENSE file in the repository root for full license text.

using System.Numerics;

namespace Program;

internal static class GetInput
{
    internal static string GetString(string prompt, string help = "")
    {
        string? value = "";

        while (true)
        {
            Console.Write(prompt);
            value = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(value))
                Console.WriteLine($"{help}\n");
            else
                return value;
        }
    }

    internal static double GetDouble(string prompt, bool allowZero = false)
    {
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out double value))
                if (1 <= value)
                    return value;
                else if (allowZero)
                    return value;
                else
                    Console.WriteLine("Value can't be 0 or below.\n");
            else
                Console.WriteLine("Invalid number, try again.\n");
        }
    }

    internal static int GetInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int value))
                if (1 <= value)
                    return value;
                else
                    Console.WriteLine("Value can't be 0 or below.\n");
            else
                Console.WriteLine("Invalid number, try again.\n");
        }
    }

    internal static ulong GetULong(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (ulong.TryParse(Console.ReadLine(), out ulong value))
                if (1 <= value)
                    return value;
                else
                    Console.WriteLine("Value can't be 0 or below.\n");
            else
                Console.WriteLine("Invalid number, try again.\n");
        }
    }

    internal static bool GetBool(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (bool.TryParse(Console.ReadLine(), out bool value))
                return value;
            Console.WriteLine("Invalid boolean, try again.\n");
        }
    }
}
