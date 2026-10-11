namespace P0242_ValidAnagram;

/*
 * 242. Valid Anagram (Easy)
 * https://leetcode.com/problems/valid-anagram/
 *
 * Given two strings s and t, return true if t is an anagram of s, and false otherwise.
 *
 * An anagram is a word formed by rearranging the letters of another word,
 * using all the original letters exactly once.
 *
 * Example 1:
 *   Input:  s = "anagram", t = "nagaram"
 *   Output: true
 *
 * Example 2:
 *   Input:  s = "rat", t = "car"
 *   Output: false
 *
 * Constraints:
 *   1 <= s.length, t.length <= 5 * 10^4
 *   s and t consist of lowercase English letters.
 *
 * Follow up: What if the inputs contain Unicode characters? How would you adapt your solution?
 */

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        // TODO: write your solution here
        throw new NotImplementedException();
    }
}

public class Tests : IProblem
{
    public int Number => 242;
    public string Title => "Valid Anagram";
    public string Topic => "Arrays & Hashing";

    public void Run()
    {
        var s = new Solution();
        Test.Check("Example 1", true, () => s.IsAnagram("anagram", "nagaram"));
        Test.Check("Example 2", false, () => s.IsAnagram("rat", "car"));
        Test.Check("Different lengths", false, () => s.IsAnagram("a", "ab"));
        Test.Check("Same letters, different counts", false, () => s.IsAnagram("aacc", "ccac"));
        Test.Check("Identical", true, () => s.IsAnagram("x", "x"));
    }
}
