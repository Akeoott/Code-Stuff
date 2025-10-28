// Copyright (c) Akeoott <amejanin00@gmail.com>. Licensed under the MIT License.
// See the LICENSE file in the repository root for full license text.

namespace Program;

internal static class GetInput
{
    internal static string ForceInput(string prompt)
    {
        string? input;

        do
        {
            Console.Write(prompt);
            input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Please enter a non-empty value.");
            }
        } while (string.IsNullOrWhiteSpace(input));
        return input;
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
}
