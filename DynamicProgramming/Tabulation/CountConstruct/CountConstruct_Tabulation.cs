namespace CountConstruct.Tabulation;

public class Solution
{
    public int Run(string target, string[] wordBank)
    {

        int[] table = new int[target.Length + 1];
        table[0] = 1;

        for (int i = 0; i <= target.Length; i++)
        {
            foreach (var word in wordBank)
            {
                if (string.Compare(target, i, word, 0, word.Length) == 0)
                {
                    table[i + word.Length] += table[i];
                }
            }
        }

        return table[target.Length];
    }
}