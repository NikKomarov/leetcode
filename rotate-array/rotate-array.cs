public class Solution {
    public void Rotate(int[] nums, int k) {
        k %= nums.Length;
        int updated = 0;
        int start = 0;
        while(updated < nums.Length)
        {
            int i = start;
            int prev = nums[i];
           
            do 
            {
                i = (i + k) % nums.Length;
                int temp = nums[i];
                nums[i] = prev;
                prev = temp;
                updated++;
            }
            while(i != start);
            
            start++;
        }
    }
}