public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();
        for(var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            if(map.ContainsKey(target - num))
            {
                return new int[2]{map[target - num], i };
            }
            map[num] = i;
        }
        
        return new int[0];
    }
}