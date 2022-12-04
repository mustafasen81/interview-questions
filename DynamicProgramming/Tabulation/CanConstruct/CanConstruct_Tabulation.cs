namespace CanConstruct.Tabulation;

public class Solution
{
    public bool Run(string target, string[] wordBank)
    {
        bool[] table = new bool[target.Length + 1];
        table[0] = true;

        for (int i = 0; i <= target.Length; i++)
        {
            if (!table[i])
            {
                continue;
            }
            foreach (var word in wordBank)
            {
                if (string.Compare(target, i, word, 0, word.Length) == 0)
                {
                    table[i + word.Length] = true;
                }
            }
        }

        return table[target.Length];
    }
}