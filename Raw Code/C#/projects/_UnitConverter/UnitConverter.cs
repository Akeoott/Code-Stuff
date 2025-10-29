// Copyright (c) Akeoott <amejanin00@gmail.com>. Licensed under the MIT License.
// See the LICENSE file in the repository root for full license text.

using System.Globalization;

namespace Program;

internal static class UnitConverter
{
    const string Header =
        """
        ====================================
        | Projects by Ame (Akeoott/Akeoot) |
        ====================================
        =========| Unit Converter |=========
        ====================================

        """;

    const string Options =
        """
        Options:
            Enter 'exit' to Exit Application.
            Enter '1'    to Convert Storage Unit   (Byte)
            Enter '2'    to Convert Internet Speed (Bit)

        """;

    internal static void RunUnitConverter()
    {
        Console.WriteLine(Header);
        Console.WriteLine(Options);

        while (true)
        {
            string input = GetInput.ForceInput("Enter a command: ").ToLower(CultureInfo.CurrentCulture).Trim();

            switch (input)
            {
                case "1":
                    ConvByte();
                    return;

                case "2":
                    ConvBit();
                    return;

                case "exit":
                    return;

                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }

    internal static void ConvByte()
    {
        const string Options =
            """
            Convert:
                From/To:
                    byte       (B)
                    kilobyte   (kB)
                    megabyte   (MB)
                    gigabyte   (GB)
                    terabyte   (TB)
                    petabyte   (PB)
                    exabyte    (EB)
                    zettabyte  (ZB)
                    yottabyte  (YB)
                    ronnabyte  (RB)
                    quettabyte (QB)
            """;

        while (true)
        {
            Console.WriteLine(Options);
            string from = GetInput.ForceInput("Convert from : ").ToLower(CultureInfo.CurrentCulture).Trim();
            string to = GetInput.ForceInput("Convert to   : ").ToLower(CultureInfo.CurrentCulture).Trim();
            float value = GetInput.GetFloat("Value        : ");

            int GetPower(string unit) => unit switch
            {
                "byte" or "b" => 0,
                "kilobyte" or "kb" => 1,
                "megabyte" or "mb" => 2,
                "gigabyte" or "gb" => 3,
                "terabyte" or "tb" => 4,
                "petabyte" or "pb" => 5,
                "exabyte" or "eb" => 6,
                "zettabyte" or "zb" => 7,
                "yottabyte" or "yb" => 8,
                "ronnabyte" or "rb" => 9,
                "quettabyte" or "qb" => 10,
                _ => -1
            };

            int fromPow = GetPower(from);
            int toPow = GetPower(to);

            if (fromPow == -1 || toPow == -1)
            {
                Console.WriteLine("Invalid unit. Please try again.");
                continue;
            }

            float result = fromPow < toPow
                ? value / MathF.Pow(1024f, toPow - fromPow)
                : value * MathF.Pow(1024f, fromPow - toPow);

            Console.WriteLine($"Result: {result:F10} {to}");
            break;
        }
    }

    internal static void ConvBit()
    {
        const string Options =
            """
            Convert:
                From/To:
                    bit       (b)
                    kilobit   (kb)
                    megabit   (Mb)
                    gigabit   (Gb)
                    terabit   (Tb)
                    petabit   (Pb)
                    exabit    (Eb)
                    zettabit  (Zb)
                    yottabit  (Yb)
                    ronnabit  (Rb)
                    quettabit (Qb)
            """;

        while (true)
        {
            Console.WriteLine(Options);
            string from = GetInput.ForceInput("Convert from : ").ToLower(CultureInfo.CurrentCulture).Trim();
            string to = GetInput.ForceInput("Convert to   : ").ToLower(CultureInfo.CurrentCulture).Trim();
            float value = GetInput.GetFloat("Value        : ");

            int GetPower(string unit) => unit switch
            {
                "bit" or "b" => 0,
                "kilobit" or "kb" => 1,
                "megabit" or "mb" => 2,
                "gigabit" or "gb" => 3,
                "terabit" or "tb" => 4,
                "petabit" or "pb" => 5,
                "exabit" or "eb" => 6,
                "zettabit" or "zb" => 7,
                "yottabit" or "yb" => 8,
                "ronnabit" or "rb" => 9,
                "quettabit" or "qb" => 10,
                _ => -1
            };

            int fromPow = GetPower(from);
            int toPow = GetPower(to);

            if (fromPow == -1 || toPow == -1)
            {
                Console.WriteLine("Invalid unit. Please try again.");
                continue;
            }

            float result = fromPow > toPow
                ? value / MathF.Pow(1000f, toPow - fromPow)
                : value * MathF.Pow(1000f, fromPow - toPow);

            Console.WriteLine($"Result: {result:F10} {to}");
            break;
        }
    }
}
