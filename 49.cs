public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var list = new List<IList<string>>();
        string[] strs_sorted = new string[strs.Length];

        for(int i = 0; i < strs.Length; i++)
            strs_sorted[i] = String.Concat(strs[i].OrderBy(c => c));

        var dict = new Dictionary<string, List<int>>();
        for(int i = 0; i < strs_sorted.Length; i++)
        {
            if(dict.ContainsKey(strs_sorted[i]))
                dict[strs_sorted[i]].Add(i);
            else
                dict.Add(strs_sorted[i], new List<int>() { i });
        }

        foreach(var it in dict)
        {
            var strings = new List<string>();
            foreach(var st in it.Value)
                strings.Add(strs[st]);
            list.Add(strings);
        }

        return list;
    }
}