namespace AllConstruct.Memozation;

public class Solution
{
    private Dictionary<string, string[][]> memo = new Dictionary<string, string[][]>();
    public string[][] Run(string target, string[] wordBank)
    {
        if (memo.ContainsKey(target))
        {
            return memo[target];
        }
        if (target.Length == 0)
        {
            return new string[][] { new string[0] };
        }

        List<string[]> constructs = new List<string[]>();
        foreach (var word in wordBank)
        {
            if (target.StartsWith(word))
            {
                var remaining = target.Remove(0, word.Length);
                var currentCosntructs = Run(remaining, wordBank);
                foreach (var c in currentCosntructs)
                {
                    var newConstruct = new string[c.Length + 1];
                    newConstruct[0] = word;
                    Array.Copy(c, 0, newConstruct, 1, c.Length);
                    constructs.Add(newConstruct);
                }
            }
        }
        memo[target] = constructs.ToArray();
        return memo[target];
    }
}