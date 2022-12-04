namespace BestSum.Tabulation;

public class Solution
{

    public int[]? Run(int targetSum, int[] numbers)
    {
        int[]?[] table = new int[]?[targetSum + 1];
        table[0] = new int[] { };

        for (int i = 0; i < targetSum; i++)
        {
            int[]? currentSum = table[i];
            if (currentSum == null)
            {
                continue;
            }
            foreach (var num in numbers)
            {
                int next = i + num;
                if (next > targetSum)
                {
                    continue;
                }
                int[]? previousNextSum = table[next];
                if (previousNextSum == null || (currentSum.Length + 1) < previousNextSum.Length)
                {
                    int[] sum = new int[currentSum.Length + 1];
                    sum[0] = num;
                    Array.Copy(currentSum, 0, sum, 1, currentSum.Length);
                    table[next] = sum;
                }
            }
        }
        return table[targetSum];
    }
}