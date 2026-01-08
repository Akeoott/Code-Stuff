// Copyright (c) Ame aka Akeoott <ame@akeoot.org>. Licensed under the LGPL-3.0 License.
// See the LICENSE file in the repository root for full license text.

using System.Numerics;
using System.Security.Cryptography;

namespace Program;

internal static class RollDice
{
    const string Header =
        """
        ====================================
        | Projects by Ame (Akeoott/Akeoot) |
        ====================================
        =========| Cryptographic  |=========
        =======| Random Dice Roller |=======
        ====================================

        """;

    const string Hello =
        """
        Hello, World!
        This is a cryptographically random dice roller made by Akeoott!

        """;

    internal static void RunRollDice()
    {
        Console.WriteLine(Header);
        Console.WriteLine(Hello);

        Console.WriteLine("=== 32-bit range only ===");
        int diceAmount = GetInput.GetInt("How many dice should be rolled?: ");
        int sideAmount = GetInput.GetInt("How many sides should all dice have?: ");

        int maxAmount = diceAmount * sideAmount;
        double probability = Math.Pow(1.0 / sideAmount, diceAmount);
        BigInteger possibleOutcomes = BigInteger.Pow(sideAmount, diceAmount);


        Console.WriteLine($"\n=== Probability of rolling {maxAmount} with {diceAmount}d{sideAmount} ===");
        Console.WriteLine($"Mathematical Percentage: ");
        Console.WriteLine($"{probability * 100:E}%\n");

        Console.WriteLine($"Highest possible number is {maxAmount}");
        Console.WriteLine($"Chance to get {maxAmount}: ");
        Console.WriteLine($"1 out of {possibleOutcomes}\n");

        if (!GetInput.GetBool("Continue? (true/false): "))
            return;

        Console.WriteLine("...");
        Thread.Sleep(1000);

        if (maxAmount >= 1000)
        {
            TextBgColor(ConsoleColor.Red);
            Console.WriteLine($"Luck wont help you from here on out...");
        }
        else if (maxAmount >= 500)
        {
            TextFgColor(ConsoleColor.Red);
            Console.WriteLine($"Good luck... >:)");
        }
        else if (maxAmount >= 100)
        {
            TextFgColor(ConsoleColor.Yellow);
            Console.WriteLine($"Good luck! :)");
        }
        else
        {
            TextFgColor(ConsoleColor.Green);
            Console.WriteLine($"This is gonna be easy! :)");
        }

        Console.ResetColor();
        Console.WriteLine();
        Thread.Sleep(3000);

        RollDiceRuntime rdr = new(diceAmount, sideAmount);
        Thread diceThread = new(() => rdr.Init());

        diceThread.Start();
    }

    private static void TextBgColor(ConsoleColor color)
    {
        Console.BackgroundColor = color;
    }

    private static void TextFgColor(ConsoleColor color)
    {
        Console.ForegroundColor = color;
    }
}

internal class RollDiceRuntime
{
    readonly int diceAmount;
    readonly int sideAmount;
    readonly int[] result;

    internal RollDiceRuntime(int diceAmount, int sideAmount)
    {
        this.diceAmount = diceAmount;
        this.sideAmount = sideAmount;
        result = new int[diceAmount];
    }

    internal void Init()
    {
        Console.WriteLine(diceAmount);
        Console.WriteLine(sideAmount);
        Console.WriteLine(result);
        Console.WriteLine("Section is WIP. Come back later!");
    }
}
