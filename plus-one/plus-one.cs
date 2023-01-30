public class Solution {
    public int[] PlusOne(int[] digits) {
        var result = new Stack<int>();
        
        var saved = 1;
        for(var i=digits.Length-1;i>=0; i--)
        {
            var inc = digits[i] + saved;
            if(inc == 10)
            {
                saved = 1;
                result.Push(0);
            }
            else
            {
                saved = 0;
                result.Push(inc);
            }
        }
        
        if(saved > 0)
        {
            result.Push(saved);
        }
        
        return result.ToArray();
    }
}