// Copyright (c) Ame aka Akeoott <ame@akeoot.org>. Licensed under the LGPL-3.0 License.
// See the LICENSE file in the repository root for full license text.

using System.Globalization;

namespace Program;

internal static class RunProgram
{
    private const string Header =
        """
        ====================================
        | Projects by Ame (Akeoott/Akeoot) |
        ====================================

        """;

    private const string Options =
        """
        Options:
            Enter 'exit' to exit application (Get outta here)
            Enter '1'    for FactorialCalc   (Calculate factorials)
            Enter '2'    for RollDice        (Rolles a dice till it gets the best result)
            Enter '3'    for CryptRNG        (Generates random numbers)

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
            string input = GetInput.GetString("Enter an option: ").ToLower(CultureInfo.CurrentCulture).Trim();

            switch (input)
            {
                case "exit":
                    return;

                case "1":
                    Console.Clear();
                    FactorialCalc.RunFactorialCalc();
                    return;

                case "2":
                    Console.Clear();
                    RollDice.RunRollDice();
                    return;

                case "3":
                    Console.Clear();
                    CryptRNG.RunCryptRNG();
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    Console.WriteLine(Options);
                    break;
            }
        }
    }
}
