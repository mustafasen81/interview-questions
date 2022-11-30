namespace CanSum.Recursive;

public class Solution
{

    public bool Run(int targetSum, int[] numbers)
    {
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
                return true;
            }
        }

        return false;
    }
}