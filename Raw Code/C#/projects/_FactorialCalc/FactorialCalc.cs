// Copyright (c) Akeoott <amejanin00@gmail.com>. Licensed under the LGPL-3.0 License.
// See the LICENSE file in the repository root for full license text.

using System.Numerics;
using System.Diagnostics;
using System.Globalization;

namespace Program;

internal static class FactorialCalc
{
    private const string Header =
        """
        ====================================
        | Projects by Ame (Akeoott/Akeoot) |
        ====================================
        =============| Exact |==============
        ======| Factorial Calculator |======
        ====================================

        """;

    private const string Hello =
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
        BigInteger result;
        string resultNotation;

        var sw = Stopwatch.StartNew();
        long inputTime;
        long factorialTime;
        long notationTime;
        long displayTime;

        input = GetInput.GetInt("Enter a number: ");
        sw.Stop();
        inputTime = sw.ElapsedMilliseconds;

        Console.WriteLine("Starting calculation...");

        sw.Restart();
        result = CalcFactorial(input);
        sw.Stop();
        factorialTime = sw.ElapsedMilliseconds;

        Console.WriteLine("Starting conversion...");

        sw.Restart();
        resultNotation = GetNotation(result);
        sw.Stop();
        notationTime = sw.ElapsedMilliseconds;

        Console.WriteLine("Starting display...");

        sw.Restart();
        Console.WriteLine(
            $"""
            ---- Result ---
            Exponent of Factorial {input}! = {resultNotation}
            """);
        sw.Stop();
        displayTime = sw.ElapsedMilliseconds;

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

    private static BigInteger CalcFactorial(int input)
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

    private static string GetNotation(BigInteger number)
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
}
