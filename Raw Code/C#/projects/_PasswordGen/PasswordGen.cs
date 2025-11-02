// Copyright (c) Akeoott <amejanin00@gmail.com>. Licensed under the LGPL-3.0 License.
// See the LICENSE file in the repository root for full license text.

using System.Globalization;

namespace Program;

abstract internal class PasswordGen
{
    const string Header =
        """
        ====================================
        | Projects by Ame (Akeoott/Akeoot) |
        ====================================
        =======| Password Generator |=======
        ====================================

        """;

    const string Hello =
        """
        Hello, World!
        This is a password generator made by Akeoott!

        """;

    internal static void RunPasswordGen()
    {
        Console.WriteLine(Header);
        Console.WriteLine(Hello);

        // TODO: Add password generator

    }
}
