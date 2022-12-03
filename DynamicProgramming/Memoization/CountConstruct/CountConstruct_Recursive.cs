namespace CountConstruct.Recursive;

public class Solution
{
    public int Run(string target, string[] wordBank)
    {
        if (target.Length == 0)
        {
            return 1;
        }

        int count = 0;
        foreach (var word in wordBank)
        {
            if (target.StartsWith(word))
            {
                var remaining = target.Remove(0, word.Length);
                count += Run(remaining, wordBank);
            }
        }
        return count;
    }
}