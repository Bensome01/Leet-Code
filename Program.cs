// See https://aka.ms/new-console-template for more information

using System.Text;

//var tests = File.ReadAllLines("./tests.txt").ToList();

var strs = new [] { "flower", "flow", "flight" };

Console.WriteLine(Leet.LongestCommonPrefix(strs));


static class Leet
{
    public static string LongestCommonPrefix(string[] strs) {
        string longestPrefix = strs[0];

        for(int i = 1; i < strs.Length; i++)
        {
            for(int j = longestPrefix.Length; j >= 0; j--)
            {
                if(strs[i].Length >= j && strs[i].Substring(0, j) == longestPrefix)
                {
                    //longestPrefix = strs[i].Substring(0, j);
                    break;
                }
                else
                {
                    longestPrefix = longestPrefix.Substring(0, j - 1);
                }
            }
        }

        return longestPrefix;
    }
}