// See https://aka.ms/new-console-template for more information

using System.Text;

//var tests = File.ReadAllLines("./tests.txt").ToList();

var s = "abcabcbb";

Console.WriteLine(Leet.LengthOfLongestSubstring(s));


static class Leet
{
    public static int LengthOfLongestSubstring(string s) {
        int length = 0;
        int windowStart = 0;
        int windowEnd = 0;
        Dictionary<char, int> CurSubStr = new Dictionary<char, int>();

        while(windowEnd < s.Length)
        {
            if(!CurSubStr.ContainsKey(s[windowEnd]))
            {
                CurSubStr.Add(s[windowEnd], windowEnd);
                length = Math.Max(length, CurSubStr.Count);
                windowEnd++;
            }
            else
            {
                CurSubStr.Remove(s[windowStart]);
                windowStart++;
            }
        }


        return length;
    }
}