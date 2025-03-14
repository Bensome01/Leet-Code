// See https://aka.ms/new-console-template for more information

using System.Text;

//var tests = File.ReadAllLines("./tests.txt").ToList();

var s = "()[]{}";

Console.WriteLine(Leet.IsValid(s));


static class Leet
{
    public static bool IsValid(string s) {
        Dictionary<char, char> pairs = new Dictionary<char, char>(){
            {'(', ')'},
            {'[', ']'},
            {'{', '}'}
        };
        HashSet<char> leftPara = new HashSet<char>() {
            ')',
            ']',
            '}'
        };
        List<char> checker = new List<char>();

        for(int i = 0; i < s.Length; i++)
        {
            if(leftPara.Contains(s[i]))
            {
                if(checker.Count == 0 || pairs[checker[checker.Count - 1]] != s[i])
                {
                    return false;
                }
                else
                {
                    checker.RemoveAt(checker.Count - 1);
                }
            }
            else
            {
                checker.Add(s[i]);
            }
        }

        return checker.Count == 0;
    }
}