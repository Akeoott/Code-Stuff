// Copyright (c) Akeoott <amejanin00@gmail.com>. Licensed under the MIT License.
// See the LICENSE file in the repository root for full license text.

using System.Globalization;

namespace Program;

internal static class FormatStr
{
    internal static string Lower(string input)
    {
        return input.ToLower(CultureInfo.CurrentCulture);
    }
}
