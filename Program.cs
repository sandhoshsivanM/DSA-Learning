// DSA runner
//   dotnet run -- list     show all problems
//   dotnet run -- 217      run the tests for problem 217

using System.Reflection;

var problems = Assembly.GetExecutingAssembly()
    .GetTypes()
    .Where(t => typeof(IProblem).IsAssignableFrom(t) && t is { IsInterface: false, IsAbstract: false })
    .Select(t => (IProblem)Activator.CreateInstance(t)!)
    .ToDictionary(p => p.Number);

if (args.Length == 0 || args[0] is "list" or "-l")
{
    PrintList();
    return;
}

if (!int.TryParse(args[0], out var number) || !problems.TryGetValue(number, out var problem))
{
    Test.Write($"No problem with number '{args[0]}'.\n\n", ConsoleColor.Red);
    PrintList();
    return;
}

Console.WriteLine($"\n#{problem.Number} {problem.Title}  ({problem.Topic})\n");
Test.Reset();
try
{
    problem.Run();
    Console.WriteLine();
    var color = Test.Passed == Test.Total ? ConsoleColor.Green : ConsoleColor.Yellow;
    Test.Write($"{Test.Passed}/{Test.Total} passed\n", color);
}
catch (NotImplementedException)
{
    Test.Write("Not implemented yet. ", ConsoleColor.Yellow);
    Console.WriteLine($"Write your solution in the {problem.GetType().Namespace} file and run again.");
}

void PrintList()
{
    Console.WriteLine("Usage: dotnet run -- <number>\n");
    string[] topicOrder =
    [
        "Arrays & Hashing", "Two Pointers", "Sliding Window", "Stack", "Binary Search",
        "Linked List", "Trees", "Tries", "Heap / Priority Queue", "Backtracking", "Graphs",
        "Advanced Graphs", "1-D Dynamic Programming", "2-D Dynamic Programming", "Greedy",
        "Intervals", "Math & Geometry", "Bit Manipulation",
    ];
    int Rank(string topic) => Array.IndexOf(topicOrder, topic) is var i and >= 0 ? i : int.MaxValue;

    foreach (var group in problems.Values.GroupBy(p => p.Topic).OrderBy(g => Rank(g.Key)))
    {
        Console.WriteLine(group.Key);
        foreach (var p in group.OrderBy(p => p.Number))
            Console.WriteLine($"  {p.Number,5}  {p.Title}");
        Console.WriteLine();
    }
}
