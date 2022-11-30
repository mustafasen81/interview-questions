namespace GridTraveler.Recursive;

public class Solution
{
    public long Run(int m, int n)
    {
        if (m == 1 && n == 1)
        {
            return 1;
        }
        if (m == 0 || n == 0)
        {
            return 0;
        }
        return Run(m - 1, n) + Run(m, n - 1);
    }
}