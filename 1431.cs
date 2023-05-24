public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var result = new List<bool>();
        foreach(var it in candies)
        {
            int temp = it + extraCandies;
            bool r = temp >= candies.Max() ? true : false;
            result.Add(r);
        }
        return result;
    }
}