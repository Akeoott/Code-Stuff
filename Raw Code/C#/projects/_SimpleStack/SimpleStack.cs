// Copyright (c) Ame (Akeoott) <ame@akeoot.org>. Licensed under the LGPL-3.0 License.
// See the LICENSE file in the repository root for full license text.

using System.Diagnostics;

namespace Program;

// Basic Stack data structure
// Used a list instead of an array,
// while it increases time complexity,
// it allows for much more flexibility and its simpler.

internal static class SimpleStack
{
    #region UX
    private const string Header =
        """
        ====================================
        | Projects by Ame (Akeoott/Akeoot) |
        ====================================
        ==========| Simple Stack |==========
        ====================================

        """;

    private const string Hello =
        """
        Hello, World!
        This is a simple stack made by Akeoott!
        (Uses a list to store data, has a good amount of features)

        """;

    private const string Help = """
        options:
            pu, push     Push a value to the top of the stack
            po, pop      Pop the top value off the stack
            pe, peek     Get the top value of the stack
            ie, isempty  Check if the stack is empty
            co, count    Get the amount of values in the stack
            cl, clear    Clear the stack
            st, string   Get a string representation of the stack
        Enter q or quit to exit.
        """;

    internal static void Run()
    {
        Stack stack = new();
        Stopwatch sw = new();
        string option;
        int value;

        Console.WriteLine(Header);
        Console.WriteLine(Hello);

        Console.WriteLine("Press enter to list all options...\n");

        while (true)
        {
            option = GetInput.GetString("Enter an option: ", Help);

            switch (option)
            {
                case "pu" or "push":
                    value = GetInput.GetInt("Enter an int value: ");
                    sw.Restart();
                    stack.Push(value);
                    sw.Stop();
                    Console.WriteLine($"Time till operation finished: {sw.ElapsedMilliseconds}ms");
                    Console.WriteLine($"Pushed {value} to stack");
                    break;

                case "po" or "pop":
                    try
                    {
                        sw.Restart();
                        value = stack.Pop();
                        sw.Stop();
                        Console.WriteLine($"Time till operation finished: {sw.ElapsedMilliseconds}ms");
                        Console.WriteLine($"Poped {value} from stack");
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case "poo" or "poop":
                    Console.WriteLine($"{option}? Your really asking me to take a shit?\nChoose another option...");
                    break;

                case "pe" or "peek":
                    try
                    {
                        sw.Restart();
                        value = stack.Peek();
                        sw.Stop();
                        Console.WriteLine($"Time till operation finished: {sw.ElapsedMilliseconds}ms");
                        Console.WriteLine($"Top value is {value}");
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case "ie" or "isempty":
                    if (stack.IsEmpty)
                        Console.WriteLine("Stack is empty!");
                    else
                        Console.WriteLine("Stack is not empty!");
                    break;

                case "co" or "count":
                    Console.WriteLine($"Amount of values: {stack.Count}");
                    break;

                case "cl" or "clear":
                    stack.Clear();
                    Console.WriteLine("Cleared stack");
                    break;

                case "st" or "string":
                    sw.Restart();
                    Console.WriteLine(stack.ToString());
                    sw.Stop();
                    Console.WriteLine($"Time till operation finished: {sw.ElapsedMilliseconds}ms");
                    break;

                case "q" or "quit" or "exit":
                    Console.WriteLine("Bye bye!");
                    return;

                default:
                    Console.WriteLine(Help);
                    break;
            }
            Console.WriteLine();
        }
    }
    #endregion
}

#region Stack
internal sealed class Stack
{
    private readonly List<int> data = [];

    public void Push(int value) => data.Add(value);

    public int Pop()
    {
        if (IsEmpty) throw new InvalidOperationException("Stack is empty, cant pop!");
        int lastIndex = data.Count - 1;
        int value = data[lastIndex];
        data.RemoveAt(lastIndex);
        return value;
    }

    public int Peek()
    {
        if (IsEmpty) throw new InvalidOperationException("Stack is empty, cant peek!");
        return data[^1];
    }

    public bool IsEmpty => data.Count == 0;
    public int Count => data.Count;

    public void Clear() => data.Clear();

    public override string ToString()
    {
        if (IsEmpty) return "[]";
        return $"[{string.Join(", ", data)}]";
    }
}
#endregion
