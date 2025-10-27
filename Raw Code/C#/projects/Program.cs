// Copyright (c) Akeoott <amejanin00@gmail.com>. Licensed under the MIT License.
// See the LICENSE file in the repository root for full license text.

namespace Program;

internal sealed class RunProgram
{
    private const string Header =
        """
        ====================================
        | Projects by Ame (Akeoott/Akeoot) |
        ====================================

        """;

    private const string Help =
        """

        (Commands are not case sensitive)
           Utils
              Enter: 'help' | Displays all commands.
              Enter: 'quit' | Exits application.
           Projects
              Enter: '1'    | Runs UnitConverter     (Not added yet)
              Enter: '2'    | Runs SimplePasswordGen (Not added yet)
              Enter: '3'    | Runs TextAnalyzer      (Not added yet)

        """;

    private static void Main(string[] args)
    {
        Run();
    }

    private static void Run()
    {
        string Seperator = $"\n {new string('-', 40)} \n";

        Console.WriteLine(Header);
        Console.WriteLine("(enter 'help' to list all commands)");

        while (true)
        {
            string input = GetInput.ForceInput("What project do you want to enter?: ");
            input = FormatStr.Lower(input).Trim();

            switch (input)
            {
                case "help":
                    Console.WriteLine(Help);
                    break;

                case "1":
                    Console.WriteLine(Seperator);
                    UnitConverter.RunUnitConverter();
                    Console.WriteLine(Seperator);
                    break;

                case "2":
                    Console.WriteLine(Seperator);
                    PasswordGen.RunPasswordGen();
                    Console.WriteLine(Seperator);
                    break;

                case "3":
                    Console.WriteLine(Seperator);
                    TextAnalyzer.RunTextAnalyzer();
                    Console.WriteLine(Seperator);
                    break;

                case "quit" or "exit":
                    Console.WriteLine("\nThanks for visiting! BYE BYE >.<");
                    return;

                default:
                    Console.WriteLine("Invalid command. Type 'help' for available commands.");
                    break;
            }
        }
    }
}
