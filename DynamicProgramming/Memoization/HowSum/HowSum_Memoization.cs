namespace HowSum.Memoization;

public class Solution
{

    private Dictionary<int, int[]?> memo = new Dictionary<int, int[]?>();

    public int[]? Run(int targetSum, int[] numbers)
    {
        if (memo.ContainsKey(targetSum))
        {
            return memo[targetSum];
        }

        if (targetSum == 0)
        {
            return new int[0];
        }
        if (targetSum < 0)
        {
            return null;
        }

        foreach (var num in numbers)
        {
            var result = Run(targetSum - num, numbers);
            if (result != null)
            {
                var newResult = new int[result.Length + 1];
                newResult[0] = num;
                System.Array.Copy(result, 0, newResult, 1, result.Length);

                memo[targetSum] = newResult;
                return newResult;
            }
        }

        memo[targetSum] = null;
        return null;

    }
}