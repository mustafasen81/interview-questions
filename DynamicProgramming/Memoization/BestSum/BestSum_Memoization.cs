namespace BestSum.Memoization;

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

        System.Tuple<int, int[]?> best = new System.Tuple<int, int[]?>(0, null);

        foreach (var num in numbers)
        {
            var result = Run(targetSum - num, numbers);
            if (result != null && (best.Item2 == null || result.Length < best.Item2.Length))
            {
                best = new Tuple<int, int[]?>(num, result);
            }
        }

        if (best.Item2 != null)
        {
            var result = new int[best.Item2.Length + 1];
            result[0] = best.Item1;
            System.Array.Copy(best.Item2, 0, result, 1, best.Item2.Length);
            memo[targetSum] = result;
            return result;
        }

        memo[targetSum] = null;
        return null;
    }
}