using System.Collections;

/// <summary>
/// Tiny test helper. Each check runs your code, compares the result with the
/// expected answer, and prints PASS or FAIL.
///
///   Test.Check("Example 1", true, () => s.ContainsDuplicate([1, 2, 3, 1]));
/// </summary>
public static class Test
{
    public static int Passed { get; private set; }
    public static int Total { get; private set; }

    public static void Reset()
    {
        Passed = 0;
        Total = 0;
    }

    /// <summary>The result must match exactly, including order.</summary>
    public static void Check(string name, object? expected, Func<object?> actual) =>
        Run(name, expected, actual, Format);

    /// <summary>Any order of the elements is accepted (e.g. "return the answer in any order").</summary>
    public static void CheckUnordered(string name, IEnumerable expected, Func<object?> actual) =>
        Run(name, expected, actual, FormatUnordered);

    /// <summary>
    /// A list of groups where neither the group order nor the order inside a group matters
    /// (e.g. Group Anagrams).
    /// </summary>
    public static void CheckGroups(string name, IEnumerable expected, Func<object?> actual) =>
        Run(name, expected, actual, FormatGroups);

    static void Run(string name, object? expected, Func<object?> actual, Func<object?, string> format)
    {
        Total++;
        object? result;
        try
        {
            result = actual();
        }
        catch (NotImplementedException)
        {
            // Let the runner report "not implemented yet" for the whole problem.
            throw;
        }
        catch (Exception ex)
        {
            Fail(name, $"threw {ex.GetType().Name}: {ex.Message}");
            return;
        }

        if (format(expected) == format(result))
        {
            Passed++;
            Write("  PASS ", ConsoleColor.Green);
            Console.WriteLine(name);
        }
        else
        {
            Fail(name, $"expected {Format(expected)}, got {Format(result)}");
        }
    }

    static void Fail(string name, string detail)
    {
        Write("  FAIL ", ConsoleColor.Red);
        Console.WriteLine($"{name}: {detail}");
    }

    public static void Write(string text, ConsoleColor color)
    {
        var old = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.Write(text);
        Console.ForegroundColor = old;
    }

    /// <summary>Turns any value (arrays, lists, nested lists, strings...) into readable text.</summary>
    public static string Format(object? value) => value switch
    {
        null => "null",
        string s => $"\"{s}\"",
        char c => $"'{c}'",
        bool b => b ? "true" : "false",
        IEnumerable items => "[" + string.Join(", ", items.Cast<object?>().Select(Format)) + "]",
        _ => value.ToString() ?? "null",
    };

    static string FormatUnordered(object? value) => value is IEnumerable items and not string
        ? "[" + string.Join(", ", items.Cast<object?>().Select(Format).Order(StringComparer.Ordinal)) + "]"
        : Format(value);

    static string FormatGroups(object? value) => value is IEnumerable groups and not string
        ? "[" + string.Join(", ", groups.Cast<object?>().Select(FormatUnordered).Order(StringComparer.Ordinal)) + "]"
        : Format(value);
}
