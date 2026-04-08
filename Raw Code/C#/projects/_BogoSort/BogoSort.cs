// Copyright (c) Ame (Akeoott) <ame@akeoot.org>. Licensed under the LGPL-3.0 License.
// See the LICENSE file in the repository root for full license text.

using System.Diagnostics;
using System.Numerics;

using Program;

namespace sorting;

internal sealed class BogoSort
{
    private readonly List<int> data = [];

    private const string Header =
        """
        ====================================
        | Projects by Ame (Akeoott/Akeoot) |
        ====================================
        ===========| Bogo Sort |============
        ====================================

        """;

    private const string Hello =
        """
        Hello, World!
        If the array is sorted, Good!
        If not, shuffle it and pray its sorted.

        """;

    internal static void Run()
    {
        Console.WriteLine(Header);
        Console.WriteLine(Hello);

        int input = GetInput.GetInt("How long should the array be?: ");

        string estimatedTries = FactorialCalc.GetNotation(
            FactorialCalc.CalcFactorial(input) // high performance calculator used from an existing project
        );

        Console.WriteLine($"Will take around {estimatedTries} tries! Good luck :3");
        Console.WriteLine("Warning, it will eat up all your cpu threads, can lead to overheating!");
        Console.Write("press a key to continue...");
        Console.ReadKey();
        Console.WriteLine("\n");

        BogoSort program = new();
        Random random = new();

        for (int i = 0; i < input; i++)
        {
#pragma warning disable CA5394 // Do not use insecure randomness
            program.data.Add(random.Next(1, 100));
#pragma warning restore CA5394 // Do not use insecure randomness
        }

        long tries = 0;
        bool found = false;
        object lockObj = new();

        var cts = new CancellationTokenSource();
        var options = new ParallelOptions
        {
            CancellationToken = cts.Token,
            MaxDegreeOfParallelism = Environment.ProcessorCount
        };

        List<int>? result = null;

        var sw = Stopwatch.StartNew();

        try
        {
            Parallel.For(0, int.MaxValue, options, (i, state) =>
            {
                Random localRandom = new(Guid.NewGuid().GetHashCode());

                List<int> localData = [.. program.data];

                while (!options.CancellationToken.IsCancellationRequested)
                {
                    Shuffle(localData, localRandom);

                    long currentTry = Interlocked.Increment(ref tries);

                    if (currentTry % 10_000_000 == 0)
                    {
                        bool sortedCheck = IsSortedList(localData);
                        Console.WriteLine($"Try {currentTry}, {sortedCheck}, [{string.Join(", ", localData)}]");
                    }

                    if (IsSortedList(localData))
                    {
                        lock (lockObj)
                        {
                            if (!found)
                            {
                                sw.Stop();
                                found = true;
                                result = [.. localData];
                                Console.WriteLine($"Try {currentTry}, True, Total Elapsed Time {sw.ElapsedMilliseconds}ms, [{string.Join(", ", result)}]");
                                cts.Cancel();
                            }
                        }
                        state.Stop();
                        break;
                    }
                }
            });
        }
        catch (OperationCanceledException)
        {

        }
    }

    private static bool IsSortedList(List<int> data)
    {
        for (int i = 1; i < data.Count; i++)
        {
            if (data[i - 1] > data[i])
                return false;
        }
        return true;
    }

    private static void Shuffle<T>(List<T> list, Random random)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
#pragma warning disable CA5394 // Do not use insecure randomness
            int j = random.Next(i + 1);
#pragma warning restore CA5394 // Do not use insecure randomness
            (list[i], list[j]) = (list[j], list[i]);
        }
    }
}
