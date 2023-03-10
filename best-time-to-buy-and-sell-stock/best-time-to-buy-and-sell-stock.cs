public class Solution {
    public int MaxProfit(int[] prices) {
        var maxProfit = int.MinValue;
        var minValue = int.MaxValue;
        for(var i = 0; i < prices.Length; i++)
        {
            var item = prices[i];
            if(item < minValue)
            {
                minValue = item;
            }
            
            maxProfit = Math.Max(maxProfit, item - minValue);
        }
        
        return maxProfit;
    }
}