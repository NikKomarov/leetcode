public class Solution {
    public int MaxSubArray(int[] nums) {
        var maximum = int.MinValue;
        var current = 0;
        for(var i = 0; i < nums.Length; i++)
        {
            current = Math.Max(nums[i],current+nums[i]);
            if (current > maximum)
            {
                maximum = current;
            }
        }
        
        
        return maximum;
    }
}