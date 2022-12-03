namespace CountConstruct.Memoization;

public class Solution
{
    private Dictionary<string, int> memo = new Dictionary<string, int>();

    public int Run(string target, string[] wordBank)
    {
        if (memo.ContainsKey(target))
        {
            return memo[target];
        }
        if (target.Length == 0)
        {
            return 1;
        }

        int count = 0;
        foreach (var word in wordBank)
        {
            if (target.StartsWith(word))
            {
                var remaining = target.Remove(0, word.Length);
                count += Run(remaining, wordBank);
            }
        }
        memo[target] = count;
        return count;
    }
}