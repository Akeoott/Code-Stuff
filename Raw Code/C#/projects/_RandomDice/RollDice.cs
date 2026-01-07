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

        int diceAmount = GetInput.GetInt("How many dice should be rolled?: ");
        int sideAmount = GetInput.GetInt("How many sides should all dice have?: ");

        int maxAmount = diceAmount * sideAmount;
        double probability = Math.Pow(1.0 / sideAmount, diceAmount);
        BigInteger possibleOutcomes = BigInteger.Pow(sideAmount, diceAmount);

        Console.WriteLine($"Highest possible number is {maxAmount}");
        Console.WriteLine();
        Console.WriteLine($"=== Probability of rolling {maxAmount} with {diceAmount}d{sideAmount} ===");
        Console.WriteLine();
        Console.WriteLine($"Mathematical Percentage: ");
        Console.WriteLine($"{probability * 100:E}%");
        Console.WriteLine();
        Console.WriteLine($"Chance to get {maxAmount}: ");
        Console.WriteLine($"1 out of {possibleOutcomes}");
        Console.WriteLine();
        if (!GetInput.GetBool("Continue? (true/false): "))
            return;

        Console.WriteLine("...");
        Thread.Sleep(1000);

        if (maxAmount >= 400)
            Console.WriteLine($"Luck wont help you from here on out...");
        else if (maxAmount >= 200)
            Console.WriteLine($"Good luck... >:)");
        else if (maxAmount >= 50)
            Console.WriteLine($"Good luck! :)");
        else
            Console.WriteLine($"This is gonna be easy! :)");

        Thread.Sleep(3000);

        Console.WriteLine("OOPS! Looks like this is not finished yet. Check me out another time!");

        // TODO: Add functionality
    }
}
