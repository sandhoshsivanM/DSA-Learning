namespace P0347_TopKFrequent;

/*
 * 347. Top K Frequent Elements (Medium)
 * https://leetcode.com/problems/top-k-frequent-elements/
 *
 * Given an integer array nums and an integer k, return the k most frequent elements.
 * You may return the answer in any order.
 *
 * Example 1:
 *   Input:  nums = [1,1,1,2,2,3], k = 2
 *   Output: [1,2]
 *
 * Example 2:
 *   Input:  nums = [1], k = 1
 *   Output: [1]
 *
 * Constraints:
 *   1 <= nums.length <= 10^5
 *   -10^4 <= nums[i] <= 10^4
 *   k is in the range [1, the number of unique elements in the array].
 *   It is guaranteed that the answer is unique.
 *
 * Follow up: Your algorithm's time complexity must be better than O(n log n),
 * where n is the array's size.
 */

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        // TODO: write your solution here
        throw new NotImplementedException();
    }
}

public class Tests : IProblem
{
    public int Number => 347;
    public string Title => "Top K Frequent Elements";
    public string Topic => "Arrays & Hashing";

    public void Run()
    {
        var s = new Solution();
        Test.CheckUnordered("Example 1", new[] { 1, 2 }, () => s.TopKFrequent([1, 1, 1, 2, 2, 3], 2));
        Test.CheckUnordered("Example 2", new[] { 1 }, () => s.TopKFrequent([1], 1));
        Test.CheckUnordered("Negative numbers", new[] { -1 }, () => s.TopKFrequent([4, -1, -1, 2, -1, 4], 1));
        Test.CheckUnordered("k = all unique", new[] { 1, 2, 3 }, () => s.TopKFrequent([3, 1, 2, 1, 2, 3], 3));
    }
}
