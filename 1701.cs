public class Solution
{
    public void swap(ref string str1, ref string str2)
    {
        if(str2.Length > str1.Length)
        {
            string temp = str1;
            str1 = str2;
            str2 = temp;
        }
    }

    public string GcdOfStrings(string str1, string str2)
    {
        swap(ref str1, ref str2);

        while(str2.Length != 0)
        {
            Console.WriteLine(str1 + " : " + str2);
            string temp = str1.Substring(0, str2.Length);
            if(temp == str2)
            {
                str1 = str1.Substring(str2.Length);
            }
            else
            {
                return "";
            }
            swap(ref str1, ref str2);
        }
        return str1;
    }
}