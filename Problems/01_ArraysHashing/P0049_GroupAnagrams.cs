namespace P0049_GroupAnagrams;

/*
 * 49. Group Anagrams (Medium)
 * https://leetcode.com/problems/group-anagrams/
 *
 * Given an array of strings strs, group the anagrams together.
 * You can return the answer in any order.
 *
 * Example 1:
 *   Input:  strs = ["eat","tea","tan","ate","nat","bat"]
 *   Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
 *   Explanation:
 *     There is no string in strs that can be rearranged to form "bat".
 *     The strings "nat" and "tan" are anagrams as they can be rearranged to form each other.
 *     The strings "ate", "eat", and "tea" are anagrams as they can be rearranged to form each other.
 *
 * Example 2:
 *   Input:  strs = [""]
 *   Output: [[""]]
 *
 * Example 3:
 *   Input:  strs = ["a"]
 *   Output: [["a"]]
 *
 * Constraints:
 *   1 <= strs.length <= 10^4
 *   0 <= strs[i].length <= 100
 *   strs[i] consists of lowercase English letters.
 */

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        // TODO: write your solution here
        throw new NotImplementedException();
    }
}

public class Tests : IProblem
{
    public int Number => 49;
    public string Title => "Group Anagrams";
    public string Topic => "Arrays & Hashing";

    public void Run()
    {
        var s = new Solution();
        Test.CheckGroups("Example 1",
            new[] { new[] { "bat" }, new[] { "nat", "tan" }, new[] { "ate", "eat", "tea" } },
            () => s.GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]));
        Test.CheckGroups("Example 2", new[] { new[] { "" } }, () => s.GroupAnagrams([""]));
        Test.CheckGroups("Example 3", new[] { new[] { "a" } }, () => s.GroupAnagrams(["a"]));
        Test.CheckGroups("Same letters, different counts",
            new[] { new[] { "ab" }, new[] { "aab" } },
            () => s.GroupAnagrams(["ab", "aab"]));
    }
}
