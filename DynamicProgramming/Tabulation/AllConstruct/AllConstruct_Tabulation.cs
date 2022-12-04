namespace AllConstruct.Tabulation;

public class Solution
{
    public string[][] Run(string target, string[] wordBank)
    {

        List<string[]>[] table = new List<string[]>[target.Length + 1];
        for (int i = 0; i < table.Length; i++)
        {
            table[i] = new List<string[]>();
        }
        table[0].Add(new string[] { });

        for (int i = 0; i <= target.Length; i++)
        {
            List<string[]> currenctConstructs = table[i];
            if (!currenctConstructs.Any())
            {
                continue;
            }

            foreach (var word in wordBank)
            {
                if (string.Compare(target, i, word, 0, word.Length) == 0)
                {
                    List<string[]> nextConstructs = table[i + word.Length];
                    foreach (var construct in currenctConstructs)
                    {
                        string[] nextConstruct = new string[construct.Length + 1];
                        Array.Copy(construct, nextConstruct, construct.Length);
                        nextConstruct[nextConstruct.Length - 1] = word;
                        nextConstructs.Add(nextConstruct);
                    }
                }
            }
        }

        return table[target.Length].ToArray();
    }
}