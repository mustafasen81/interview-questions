namespace Fibonacci.Recursive;

public class Solution
{
    public long Run(int n)
    {
        if (n <= 2)
        {
            return 1;
        }
        return Run(n - 1) + Run(n - 2);
    }
}
