namespace P0036_ValidSudoku;

/*
 * 36. Valid Sudoku (Medium)
 * https://leetcode.com/problems/valid-sudoku/
 *
 * Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be
 * validated according to the following rules:
 *   1. Each row must contain the digits 1-9 without repetition.
 *   2. Each column must contain the digits 1-9 without repetition.
 *   3. Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9
 *      without repetition.
 *
 * Note:
 *   A Sudoku board (partially filled) could be valid but is not necessarily solvable.
 *   Only the filled cells need to be validated according to the mentioned rules.
 *   Empty cells are '.'.
 *
 * Example 1:
 *   5 3 . | . 7 . | . . .
 *   6 . . | 1 9 5 | . . .
 *   . 9 8 | . . . | . 6 .
 *   ------+-------+------
 *   8 . . | . 6 . | . . 3
 *   4 . . | 8 . 3 | . . 1
 *   7 . . | . 2 . | . . 6
 *   ------+-------+------
 *   . 6 . | . . . | 2 8 .
 *   . . . | 4 1 9 | . . 5
 *   . . . | . 8 . | . 7 9
 *   Output: true
 *
 * Example 2:
 *   Same as Example 1, except the 5 in the top left corner is changed to 8.
 *   Output: false
 *   Explanation: There are two 8's in the top left 3x3 sub-box, so it is invalid.
 *
 * Constraints:
 *   board.length == 9
 *   board[i].length == 9
 *   board[i][j] is a digit 1-9 or '.'.
 */

public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        // TODO: write your solution here
        throw new NotImplementedException();
    }
}

public class Tests : IProblem
{
    public int Number => 36;
    public string Title => "Valid Sudoku";
    public string Topic => "Arrays & Hashing";

    public void Run()
    {
        var s = new Solution();
        Test.Check("Example 1", true, () => s.IsValidSudoku(Board(
            "53..7....",
            "6..195...",
            ".98....6.",
            "8...6...3",
            "4..8.3..1",
            "7...2...6",
            ".6....28.",
            "...419..5",
            "....8..79")));
        Test.Check("Example 2 (two 8s in a box)", false, () => s.IsValidSudoku(Board(
            "83..7....",
            "6..195...",
            ".98....6.",
            "8...6...3",
            "4..8.3..1",
            "7...2...6",
            ".6....28.",
            "...419..5",
            "....8..79")));
        Test.Check("Duplicate in a row", false, () => s.IsValidSudoku(Board(
            "1.......1",
            ".........",
            ".........",
            ".........",
            ".........",
            ".........",
            ".........",
            ".........",
            ".........")));
        Test.Check("Duplicate in a column", false, () => s.IsValidSudoku(Board(
            "....5....",
            ".........",
            ".........",
            ".........",
            ".........",
            ".........",
            ".........",
            ".........",
            "....5....")));
        Test.Check("Empty board", true, () => s.IsValidSudoku(Board(
            ".........",
            ".........",
            ".........",
            ".........",
            ".........",
            ".........",
            ".........",
            ".........",
            ".........")));
    }

    static char[][] Board(params string[] rows) => rows.Select(r => r.ToCharArray()).ToArray();
}
