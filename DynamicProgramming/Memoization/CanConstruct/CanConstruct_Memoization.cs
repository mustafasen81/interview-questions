namespace CanConstruct.Memoization;

public class Solution
{
    private Dictionary<string, bool> memo = new Dictionary<string, bool>();
    public bool Run(string target, string[] wordBank)
    {
        if (memo.ContainsKey(target))
        {
            return memo[target];
        }

        if (target.Length == 0)
        {
            return true;
        }

        foreach (var word in wordBank)
        {
            if (target.StartsWith(word))
            {
                var remaining = target.Remove(0, word.Length);
                if (Run(remaining, wordBank))
                {
                    memo[target] = true;
                    return true;
                }
            }
        }
        memo[target] = false;
        return false;
    }
}