public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if(flowerbed.Length == 0)
        {
            return false;
        }
        else if(flowerbed.Length == 1)
        {
            if(flowerbed[0] == 1 && n == 0) return true;
            else if(flowerbed[0] == 0 && n <= 1) return true;
            return false;
        }
        else if(flowerbed.Length >= 2)
        {
            if(flowerbed[0] == 0 && flowerbed[1] == 0)
            {
                flowerbed[0] = 1;
                n--;
            }
        }


        for(int i = 1; i < flowerbed.Length; i++)
        {
            if(flowerbed[i-1] == 0 && flowerbed[i] == 0)
            {
                if(i == flowerbed.Length - 1)
                {
                    flowerbed[i] = 1;
                    n--;
                }
                else if(flowerbed[i+1] == 0)
                {
                    flowerbed[i] = 1;
                    n--;
                }
            }
        }

        return n <= 0;
    }
}