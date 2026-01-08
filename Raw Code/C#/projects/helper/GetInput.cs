// Copyright (c) Ame aka Akeoott <ame@akeoot.org>. Licensed under the LGPL-3.0 License.
// See the LICENSE file in the repository root for full license text.

using System.Numerics;

namespace Program;

internal static class GetInput
{
    internal static string GetString(string prompt)
    {
        string? value;
        do
        {
            Console.Write(prompt);
            value = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(value));
        return value;
    }

    internal static double GetDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out double value))
                if (0 != value)
                    return value;
                else
                    Console.WriteLine("Value can't be 0.");
            else
                Console.WriteLine("Invalid number, try again.");
        }
    }

    internal static int GetInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int value))
                if (0 != value)
                    return value;
                else
                    Console.WriteLine("Value can't be 0.");
            else
                Console.WriteLine("Invalid number, try again.");
        }
    }

    internal static bool GetBool(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (bool.TryParse(Console.ReadLine(), out bool value))
                return value;
            Console.WriteLine("Invalid boolean, try again.");
        }
    }
}
