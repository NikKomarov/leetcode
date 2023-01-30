public class Solution {
    public void MoveZeroes(int[] nums) {
        var nonZeroIndex = -1;
        for(var i=0;i<nums.Length;i++)
        {
            if(nums[i] != 0)
            {
                nonZeroIndex++;
                nums[nonZeroIndex] = nums[i];
            }
        }
        
        if(nonZeroIndex > -1)
        {
            for(var i=nonZeroIndex+1;i<nums.Length;i++)
            {
                nums[i] = 0;
            }
        }
    }
}