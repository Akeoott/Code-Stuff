// Copyright (c) Akeoott <amejanin00@gmail.com>. Licensed under the LGPL-3.0 License.
// See the LICENSE file in the repository root for full license text.

using System.Globalization;
using System.Security.Cryptography;

namespace Program;

abstract internal class CryptRNG
{
    const string Header =
        """
        ====================================
        | Projects by Ame (Akeoott/Akeoot) |
        ====================================
        =======| Cryptographically  |=======
        ====| Random Number Generator  |====
        ====================================

        """;

    const string Hello =
        """
        Hello, World!
        This is a cryptographically random number generator made by Akeoott!

        """;

    internal static void RunCryptRNG()
    {
        Console.WriteLine(Header);
        Console.WriteLine(Hello);

        int size;
        long result;

        size = GetInput.GetInt("How large should the number be?: ");
        result = GenRandomNumber(size);

        Console.WriteLine($"Result = {result}");
    }

    private static long GenRandomNumber(int size)
    {
        if (size < 4)
        {
            size = 4;
            Console.WriteLine("Minimum size is 4");
        }
        else if (size > 18)
        {
            size = 18;
            Console.WriteLine("Maximum size is 18");
        }

        long minValue = (long)Math.Pow(10, size - 1);
        long maxValue = (long)Math.Pow(10, size) - 1;

        byte[] randomBytes = new byte[8];
        RandomNumberGenerator.Fill(randomBytes);

        long randomLong = Math.Abs(BitConverter.ToInt64(randomBytes, 0));
        long result = minValue + (randomLong % (maxValue - minValue + 1));

        return result;
    }
}
