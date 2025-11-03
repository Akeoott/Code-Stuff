// Copyright (c) Akeoott <amejanin00@gmail.com>. Licensed under the LGPL-3.0 License.
// See the LICENSE file in the repository root for full license text.

using System.Globalization;

namespace Program;

abstract internal class CryptRNG
{
    private const string Header =
        """
        ====================================
        | Projects by Ame (Akeoott/Akeoot) |
        ====================================
        =======| Cryptographically  |=======
        ====| Random Number Generator  |====
        ====================================

        """;

    private const string Hello =
        """
        Hello, World!
        This is a cryptographically random number generator made by Akeoott!

        """;

    internal static void RunCryptRNG()
    {
        Console.WriteLine(Header);
        Console.WriteLine(Hello);

        // TODO: Add password generator

    }
}
