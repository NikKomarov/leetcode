public class Solution {
    public int ClimbStairs(int n) {
        var res = new int[n];
              
        for(var i = 0; i < n; i++)
        {
            if(i == 0) 
            {
                res[i]=1;
            }
            else if (i == 1)
            {
                res[i] = 2;
            }
            else
            {
                res[i] = res[i-1] + res[i-2];
            }
            
        }
            
        
        return res[n-1];
    }
}