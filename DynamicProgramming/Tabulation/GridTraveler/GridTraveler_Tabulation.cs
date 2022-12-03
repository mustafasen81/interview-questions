namespace GridTraveler.Tabulation;

public class Solution
{
    public long Run(int m, int n)
    {
        var table = new long[m + 1, n + 1];
        table[1, 1] = 1;

        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if ((i + 1) <= m)
                {
                    table[i + 1, j] += table[i, j];
                }
                if ((j + 1) <= n)
                {
                    table[i, j + 1] += table[i, j];
                }
            }
        }

        return table[m, n];
    }
}