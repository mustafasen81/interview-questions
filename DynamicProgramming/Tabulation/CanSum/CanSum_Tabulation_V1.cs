namespace CanSum.Tabulation;

public class Solution_V1
{
    public bool Run(int targetSum, int[] numbers)
    {
        var table = new bool[targetSum + 1];
        table[0] = true;
        for (int i = 1; i <= targetSum; i++)
        {
            foreach (var num in numbers)
            {
                int remain = i - num;
                if (remain >= 0 && table[remain])
                {
                    table[i] = true;
                    break;
                }
            }
        }
        return table[targetSum];
    }
}