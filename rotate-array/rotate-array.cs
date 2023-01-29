public class Solution {
    public void Rotate(int[] nums, int k) {
        var steps = k % nums.Length;
        var result = new int[nums.Length];
        for(var i = 0; i < nums.Length; i++)
        {
            var newIndex = i + steps;
            if(newIndex > nums.Length - 1)
            {
                newIndex = newIndex - nums.Length;
            }
            result[newIndex] = nums[i];
        }
        
        for(var i = 0; i < nums.Length; i++)
        {
            nums[i] = result[i];
        }
    }
}