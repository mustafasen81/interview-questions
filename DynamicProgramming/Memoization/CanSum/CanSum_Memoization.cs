namespace CanSum.Memoization;

public class Solution
{

    private Dictionary<int, bool> memo = new Dictionary<int, bool>();

    public bool Run(int targetSum, int[] numbers)
    {
        if (memo.ContainsKey(targetSum))
        {
            return memo[targetSum];
        }

        if (targetSum == 0)
        {
            return true;

        }
        if (targetSum < 0)
        {
            return false;
        }

        foreach (var num in numbers)
        {
            if (Run(targetSum - num, numbers))
            {
                memo[targetSum] = true;
                return true;
            }
        }

        memo[targetSum] = false;
        return false;
    }
}