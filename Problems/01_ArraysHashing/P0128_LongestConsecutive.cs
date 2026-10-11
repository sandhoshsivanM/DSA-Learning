namespace P0128_LongestConsecutive;

/*
 * 128. Longest Consecutive Sequence (Medium)
 * https://leetcode.com/problems/longest-consecutive-sequence/
 *
 * Given an unsorted array of integers nums, return the length of the longest
 * consecutive elements sequence.
 *
 * You must write an algorithm that runs in O(n) time.
 *
 * Example 1:
 *   Input:  nums = [100,4,200,1,3,2]
 *   Output: 4
 *   Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Its length is 4.
 *
 * Example 2:
 *   Input:  nums = [0,3,7,2,5,8,4,6,0,1]
 *   Output: 9
 *
 * Example 3:
 *   Input:  nums = [1,0,1,2]
 *   Output: 3
 *
 * Constraints:
 *   0 <= nums.length <= 10^5
 *   -10^9 <= nums[i] <= 10^9
 */

public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        // TODO: write your solution here
        throw new NotImplementedException();
    }
}

public class Tests : IProblem
{
    public int Number => 128;
    public string Title => "Longest Consecutive Sequence";
    public string Topic => "Arrays & Hashing";

    public void Run()
    {
        var s = new Solution();
        Test.Check("Example 1", 4, () => s.LongestConsecutive([100, 4, 200, 1, 3, 2]));
        Test.Check("Example 2", 9, () => s.LongestConsecutive([0, 3, 7, 2, 5, 8, 4, 6, 0, 1]));
        Test.Check("Example 3 (duplicates)", 3, () => s.LongestConsecutive([1, 0, 1, 2]));
        Test.Check("Empty array", 0, () => s.LongestConsecutive([]));
        Test.Check("Negative numbers", 4, () => s.LongestConsecutive([-1, -3, -2, 0, 10]));
    }
}
