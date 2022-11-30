namespace GridTraveler.Memoization;

public class Solution
{
    private Dictionary<string, long> memo = new Dictionary<string, long>();

    private string GetKey(int m, int n)
    {
        return m + "-" + n;
    }

    public long Run(int m, int n)
    {
        var memoKey = GetKey(m, n);
        if (memo.ContainsKey(memoKey))
        {
            return memo[memoKey];
        }
        if (m == 1 && n == 1)
        {
            return 1;
        }
        if (m == 0 || n == 0)
        {
            return 0;
        }
        var result = Run(m - 1, n) + Run(m, n - 1);
        memo[memoKey] = result;
        return result;
    }
}