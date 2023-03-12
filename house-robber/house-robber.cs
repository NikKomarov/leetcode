public class Solution {
    public int Rob(int[] nums) {
        var n = nums.Length;
        if(n == 0) return 0;
        int[] interm = new int[n];
        
        for(var i=0;i < n;i++)
        {
            if(i == 0)
            {
                 interm[i] = nums[i];
            }
            else if (i == 1)
            {
                 interm[i] = Math.Max(nums[i-1],nums[i]);
            }
            else
            {
                interm[i] = Math.Max(interm[i-2]+nums[i],interm[i-1]);
            }
                       
        }
        return interm[n-1];
    }
}