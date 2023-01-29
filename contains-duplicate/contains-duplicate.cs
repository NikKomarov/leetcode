public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var map = new Dictionary<int, bool>();
        
        foreach(var num in nums)
        {
            if(map.ContainsKey(num))
            {
                return true;
            }
            
            map[num] = true;
        }
        
        return false;
    }
}