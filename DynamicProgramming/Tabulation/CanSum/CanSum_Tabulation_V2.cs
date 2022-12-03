namespace CanSum.Tabulation;

public class Solution_V2
{
    public bool Run(int targetSum, int[] numbers)
    {
        var table = new bool[targetSum + 1];
        table[0] = true;
        for (int i = 0; i <= targetSum; i++)
        {
            if (table[i])
            {
                foreach (var num in numbers)
                {
                    int next = i + num;
                    if (next <= targetSum)
                    {
                        table[next] = true;
                    }
                }
            }
        }
        return table[targetSum];
    }
}