// Copyright (c) Akeoott <ame@akeoot.org>. Licensed under the LGPL-3.0 License.
// See the LICENSE file in the repository root for full license text.

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

            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Please enter a non-empty value.");
            }
        } while (string.IsNullOrWhiteSpace(value));
        return value;
    }

    internal static float GetFloat(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (float.TryParse(Console.ReadLine(), out float value))
                return value;
            Console.WriteLine("Invalid number, try again.");
        }
    }

    internal static int GetInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int value))
                return value;
            Console.WriteLine("Invalid number, try again.");
        }
    }
}
