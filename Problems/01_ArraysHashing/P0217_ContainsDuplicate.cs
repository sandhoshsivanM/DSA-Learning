namespace P0217_ContainsDuplicate;

/*
 * 217. Contains Duplicate (Easy)
 * https://leetcode.com/problems/contains-duplicate/
 *
 * Given an integer array nums, return true if any value appears at least twice
 * in the array, and return false if every element is distinct.
 *
 * Example 1:
 *   Input:  nums = [1,2,3,1]
 *   Output: true
 *   Explanation: The element 1 occurs at indices 0 and 3.
 *
 * Example 2:
 *   Input:  nums = [1,2,3,4]
 *   Output: false
 *   Explanation: All elements are distinct.
 *
 * Example 3:
 *   Input:  nums = [1,1,1,3,3,4,3,2,4,2]
 *   Output: true
 *
 * Constraints:
 *   1 <= nums.length <= 10^5
 *   -10^9 <= nums[i] <= 10^9
 */

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        // TODO: write your solution here
        throw new NotImplementedException();
    }
}

public class Tests : IProblem
{
    public int Number => 217;
    public string Title => "Contains Duplicate";
    public string Topic => "Arrays & Hashing";

    public void Run()
    {
        var s = new Solution();
        Test.Check("Example 1", true, () => s.ContainsDuplicate([1, 2, 3, 1]));
        Test.Check("Example 2", false, () => s.ContainsDuplicate([1, 2, 3, 4]));
        Test.Check("Example 3", true, () => s.ContainsDuplicate([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]));
        Test.Check("Single element", false, () => s.ContainsDuplicate([7]));
        Test.Check("Negative numbers", true, () => s.ContainsDuplicate([-1, 5, -1]));
    }
}
