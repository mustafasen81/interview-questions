namespace Fibonacci.Tabulation;

public class Solution
{
    public long Run(int n)
    {
        long[] table = new long[n + 1];
        table[0] = 0;
        table[1] = 1;

        for (int i = 1; i < n; i++)
        {
            table[i + 1] += table[i];
            if ((i + 2) <= n)
            {
                table[i + 2] += table[i];
            }
        }
        return table[n];
    }
}