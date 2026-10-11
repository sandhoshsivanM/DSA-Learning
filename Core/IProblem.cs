/// <summary>
/// Every problem file has a <c>Tests</c> class that implements this,
/// so the runner can find it by its LeetCode number.
/// </summary>
public interface IProblem
{
    int Number { get; }
    string Title { get; }
    string Topic { get; }
    void Run();
}
