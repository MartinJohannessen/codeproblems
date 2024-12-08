using System.Runtime.CompilerServices;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        return nums.Where(x => x <= target).Select((x,i) => i).ToArray();
    }
}