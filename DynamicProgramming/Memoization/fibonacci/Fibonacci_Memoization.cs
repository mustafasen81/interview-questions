namespace Fibonacci.Memoization;

public class Solution
{
    private Dictionary<int, long> memo = new Dictionary<int, long>();
    public long Run(int n)
    {
        if (memo.ContainsKey(n))
        {
            return memo[n];
        }
        if (n <= 2)
        {
            return 1;
        }
        var result = Run(n - 1) + Run(n - 2);
        memo[n] = result;
        return result;
    }
}
