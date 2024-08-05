
public class LongestSubstringWithoutRepeatingCharacters
{
    //Longest Substring Without Repeating Characters
    public static int LengthOfLongestSubstring(string s)
    {
        int left = 0, right = 0, maxLength = 0;
        var list = new HashSet<char>();
        while(right < s.Length)
        {
            if (!list.Contains(s[right]))
            {
                list.Add(s[right]);
                right++;
                maxLength = Math.Max(maxLength, list.Count);
            }
            else
            {
                list.Remove(s[right]);
                left++;
            }
        }
        Console.WriteLine($"List: {string.Join(" ", list)}");
        Console.WriteLine($"Output: {maxLength}");
        return maxLength;
    }

    public static void Main(string[] args)
    {
        string s1 = "abcabcassd";
        LengthOfLongestSubstring(s1);
        string s2 = "assdsads";
        LengthOfLongestSubstring(s2);
    }
}