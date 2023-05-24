public class Solution {
    public string MergeAlternately(string word1, string word2)
    {
        int len = word1.Length > word2.Length ? word1.Length : word2.Length;

        string res = "";
        int i = 0;
        while(i < word1.Length || i < word2.Length)
        {
            if(i < word1.Length)
                res += word1[i];
            if(i < word2.Length)
                res += word2[i];

            i++;
        }
        return res;
    }
}