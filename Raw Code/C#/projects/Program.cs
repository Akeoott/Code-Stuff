// Copyright (c) Akeoott <amejanin00@gmail.com>. Licensed under the MIT License.
// See the LICENSE file in the repository root for full license text.

using System.Globalization;

namespace Program;

internal sealed class RunProgram
{
    private const string Header =
        """
        ====================================
        = Projects by Ame (Akeoott/Akeoot) =
        ====================================

        """;

    private const string Options =
        """
        Options:
            Enter 'exit' to exit application
        Run my projects:
            Enter '1' for UnitConverter
            Enter '2' for PasswordGen   (Not added yet)
            Enter '3' for TextAnalyzer  (Not added yet)

        """;

    private const string ByeBye =
        """
        Thanks for visiting! Byebye >.<
        """;

    private static void Main(string[] args)
    {
        Run();
        Console.WriteLine(ByeBye);
    }

    private static void Run()
    {
        Console.WriteLine(Header);
        Console.WriteLine(Options);

        while (true)
        {
            string input = GetInput.ForceInput("Enter an option: ").ToLower(CultureInfo.CurrentCulture).Trim();

            switch (input)
            {
                case "exit":
                    return;

                case "1":
                    Console.Clear();
                    UnitConverter.RunUnitConverter();
                    return;

                case "2":
                    Console.Clear();
                    //PasswordGen.RunPasswordGen();
                    return;

                case "3":
                    Console.Clear();
                    //TextAnalyzer.RunTextAnalyzer();
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}

