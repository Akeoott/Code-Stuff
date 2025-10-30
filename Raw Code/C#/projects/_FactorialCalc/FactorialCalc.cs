// Copyright (c) Akeoott <amejanin00@gmail.com>. Licensed under the LGPL-3.0 License.
// See the LICENSE file in the repository root for full license text.

using System.Numerics;
using System.Diagnostics;
using System.Globalization;

namespace Program;

internal static class FactorialCalc
{
    const string Header =
        """
        ====================================
        | Projects by Ame (Akeoott/Akeoot) |
        ====================================
        =============| Exact |==============
        ======| Factorial Calculator |======
        ====================================

        """;

    const string Hello =
        """
        Hello, World!
        This is a factorial calculator made by Akeoott!
        (Handles the 5 Millionth factorial in around ~94s for my system)

        """;

    internal static void RunFactorialCalc()
    {
        Console.WriteLine(Header);
        Console.WriteLine(Hello);

        int input;
        string resultNotation;
        var sw = Stopwatch.StartNew();

        input = GetInputInt("Enter a number: ");
        sw.Stop();
        long inputTime = sw.ElapsedMilliseconds;

        Console.WriteLine("Starting calculation...");

        sw.Restart();
        BigInteger result = CalcFactorial(input);
        sw.Stop();
        long factorialTime = sw.ElapsedMilliseconds;

        Console.WriteLine("Starting conversion...");

        sw.Restart();
        resultNotation = GetNotation(result);
        sw.Stop();
        long notationTime = sw.ElapsedMilliseconds;

        Console.WriteLine("Starting display...");

        sw.Restart();
        Console.WriteLine(
            $"""
            ---- Result ---
            Exponent of Factorial {input}! = {resultNotation}
            """);
        sw.Stop();
        long displayTime = sw.ElapsedMilliseconds;

        Console.WriteLine(
            $"""
            ---- Time -----
            Time for user input   = {inputTime}ms
            Factorial calculation = {factorialTime}ms
            Notation conversion   = {notationTime}ms
            Display time          = {displayTime}ms
            ---- Total ----
            Total processing time = {factorialTime + notationTime}ms
            Total runtime         = {inputTime + factorialTime + notationTime + displayTime}ms
            """);
    }

    internal static BigInteger CalcFactorial(int input)
    {
        if (input <= 1) return 1;

        List<BigInteger> products = new List<BigInteger>();

        for (int i = 2; i <= input; i += 2)
        {
            if (i + 1 <= input)
                products.Add((BigInteger)i * (i + 1));
            else
                products.Add(i);
        }

        while (products.Count > 1)
        {
            List<BigInteger> newProducts = new List<BigInteger>();
            for (int i = 0; i < products.Count; i += 2)
            {
                if (i + 1 < products.Count)
                    newProducts.Add(products[i] * products[i + 1]);
                else
                    newProducts.Add(products[i]);
            }
            products = newProducts;
        }

        return products[0];
    }

    internal static string GetNotation(BigInteger number)
    {
        if (number == 0) return "0e0";

        bool isNegative = number < 0;
        BigInteger absValue = isNegative ? -number : number;

        int exponent = (int)BigInteger.Log10(absValue);

        BigInteger scale = BigInteger.Pow(10, exponent);
        BigInteger scaledValue = absValue * 1_000_000 / scale;

        string mantissaDigits = scaledValue.ToString(CultureInfo.InvariantCulture);

        if (mantissaDigits.Length > 6)
        {
            mantissaDigits = mantissaDigits.Substring(0, 6);
        }
        else if (mantissaDigits.Length < 6)
        {
            mantissaDigits = mantissaDigits.PadRight(6, '0');
        }

        string mantissa = mantissaDigits.Length > 1
            ? string.Concat(mantissaDigits.AsSpan(0, 1), ".", mantissaDigits.AsSpan(1))
            : mantissaDigits;

        string sign = isNegative ? "-" : "";
        return $"{sign}{mantissa}e{exponent}";
    }

    internal static int GetInputInt(string prompt)
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
