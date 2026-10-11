namespace P0001_TwoSum;

/*
 * 1. Two Sum (Easy)
 * https://leetcode.com/problems/two-sum/
 *
 * Given an array of integers nums and an integer target, return the indices of
 * the two numbers such that they add up to target.
 *
 * You may assume that each input has exactly one solution, and you may not use
 * the same element twice. You can return the answer in any order.
 *
 * Example 1:
 *   Input:  nums = [2,7,11,15], target = 9
 *   Output: [0,1]
 *   Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
 *
 * Example 2:
 *   Input:  nums = [3,2,4], target = 6
 *   Output: [1,2]
 *
 * Example 3:
 *   Input:  nums = [3,3], target = 6
 *   Output: [0,1]
 *
 * Constraints:
 *   2 <= nums.length <= 10^4
 *   -10^9 <= nums[i] <= 10^9
 *   -10^9 <= target <= 10^9
 *   Only one valid answer exists.
 *
 * Follow up: Can you come up with an algorithm that is less than O(n^2) time?
 */

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // TODO: write your solution here
        throw new NotImplementedException();
    }
}

public class Tests : IProblem
{
    public int Number => 1;
    public string Title => "Two Sum";
    public string Topic => "Arrays & Hashing";

    public void Run()
    {
        var s = new Solution();
        Test.CheckUnordered("Example 1", new[] { 0, 1 }, () => s.TwoSum([2, 7, 11, 15], 9));
        Test.CheckUnordered("Example 2", new[] { 1, 2 }, () => s.TwoSum([3, 2, 4], 6));
        Test.CheckUnordered("Example 3", new[] { 0, 1 }, () => s.TwoSum([3, 3], 6));
        Test.CheckUnordered("Negative numbers", new[] { 0, 2 }, () => s.TwoSum([-3, 4, 3, 90], 0));
    }
}
