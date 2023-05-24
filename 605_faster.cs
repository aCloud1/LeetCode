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
        else if(flowerbed.Length > 1)
        {
            if(flowerbed[0] == 0 && flowerbed[1] == 0)
            {
                flowerbed[0] = 1;
                n--;
            }
        }

        int i = flowerbed[0] == 0 ? 0 : 2;
        for(; i < flowerbed.Length;)
        {
            if(flowerbed[i] == 1)
            {
                i += 2;
                continue;
            }

            bool left0 = true;
            if(i > 0)
                if(flowerbed[i-1] == 1)
                    left0 = false;

            if(!left0)
            {
                i += 1;
                continue;
            }

            bool right0 = true;
            if(i < flowerbed.Length - 1)
                if(flowerbed[i + 1] == 1)
                    right0 = false;

            if(!right0)
            {
                i += 3;
                continue;
            }

            flowerbed[i] = 1;
            n--;
            i += 2;

        }

        return n <= 0;
    }
}