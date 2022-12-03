namespace CanConstruct.Recursive;

public class Solution
{
    public bool Run(string target, string[] wordBank)
    {
        if (target.Length == 0)
        {
            return true;
        }

        foreach (var word in wordBank)
        {
            if (target.StartsWith(word))
            {
                var remaining = target.Remove(0, word.Length);
                if (Run(remaining, wordBank))
                {
                    return true;
                }
            }
        }
        return false;
    }
}