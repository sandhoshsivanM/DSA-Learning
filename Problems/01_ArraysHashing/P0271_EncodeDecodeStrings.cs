namespace P0271_EncodeDecodeStrings;

/*
 * 271. Encode and Decode Strings (Medium)
 * LeetCode Premium: https://leetcode.com/problems/encode-and-decode-strings/
 * Free version:     https://neetcode.io/problems/string-encode-and-decode
 *
 * Design an algorithm to encode a list of strings to a single string.
 * The encoded string is then decoded back to the original list of strings.
 *
 * Example 1:
 *   Input:  ["neet","code","love","you"]
 *   Output: ["neet","code","love","you"]
 *
 * Example 2:
 *   Input:  ["we","say",":","yes"]
 *   Output: ["we","say",":","yes"]
 *
 * Constraints:
 *   0 <= strs.length < 100
 *   0 <= strs[i].length < 200
 *   strs[i] may contain any of the 256 valid ASCII characters
 *   (so any separator character you pick could also appear inside a string!).
 */

public class Solution
{
    public string Encode(IList<string> strs)
    {
        // TODO: write your solution here
        throw new NotImplementedException();
    }

    public List<string> Decode(string s)
    {
        // TODO: write your solution here
        throw new NotImplementedException();
    }
}

public class Tests : IProblem
{
    public int Number => 271;
    public string Title => "Encode and Decode Strings";
    public string Topic => "Arrays & Hashing";

    public void Run()
    {
        var s = new Solution();
        // Each test encodes the list, decodes it again, and checks you got the original back.
        RoundTrip(s, "Example 1", ["neet", "code", "love", "you"]);
        RoundTrip(s, "Example 2", ["we", "say", ":", "yes"]);
        RoundTrip(s, "Empty list", []);
        RoundTrip(s, "Empty string", [""]);
        RoundTrip(s, "Tricky characters", ["4#ab", "#", "12#", "a,b;c", " "]);
    }

    static void RoundTrip(Solution s, string name, string[] input) =>
        Test.Check(name, input, () => s.Decode(s.Encode(input)));
}
