# DSA Learning (C#)

LeetCode practice following the NeetCode 150 roadmap. Each problem has a statement, an empty method for you to fill in, and tests that print PASS or FAIL.

## Run a problem

```bash
dotnet run -- list      # show all problems that have been added
dotnet run -- 217       # run the tests for problem 217
```

Example output:

```
#217 Contains Duplicate  (Arrays & Hashing)

  PASS Example 1
  FAIL Example 2: expected false, got true
  ...
3/5 passed
```

## Debug with breakpoints (VS Code)

1. Install the **C# Dev Kit** extension if you don't have it.
2. Click in the margin next to a line in your `Solution` to set a breakpoint.
3. Press **F5**, choose **Run problem**, and type the problem number.
4. Step through with F10 (over) or F11 (into) and watch variables in the left panel.

## Daily workflow

1. Open [PROGRESS.md](PROGRESS.md) and pick the next unchecked problem.
2. Open its file in `Problems/` and read the statement at the top.
3. Think about the approach first: brute force, then something better. Write down the time and space complexity in a comment.
4. Write your code inside `public class Solution`.
5. Run `dotnet run -- <number>` until everything passes.
6. Optional: paste the `Solution` class into LeetCode and submit. The method signatures match LeetCode's C# editor.
7. Tick it off in PROGRESS.md.

## Adding problems

- **Next topic:** ask Claude something like "add the Two Pointers problems". You get files in the same format, without solutions.
- **Yourself:** copy `Templates/ProblemTemplate.cs.txt` into `Problems/<topic folder>/PXXXX_Name.cs` and follow the steps at the top of the file.

## Test helpers

| Helper | Use when |
|---|---|
| `Test.Check(name, expected, () => ...)` | the answer must match exactly |
| `Test.CheckUnordered(name, expected, () => ...)` | "return the answer in any order" |
| `Test.CheckGroups(name, expected, () => ...)` | a list of groups where order doesn't matter at either level |

You can add your own test cases to any `Tests.Run()` method. Tricky edge cases are good practice.
