// See https://aka.ms/new-console-template for more information

using System.Text;

//var tests = File.ReadAllLines("./tests.txt").ToList();

var s = "aa";
var p = "a";

Console.WriteLine(Leet.IsMatch(s, p));


static class Leet
{
    public static bool IsMatch(string s, string p) {
        // a.a == aba aca aaa ...
        if(s == "" && p == "")
        {
            return true;
        }

        if(s == "")
        {
            if(p[0] == '*')
            {
                return IsMatch(s, p.Substring(1));
            }
            if(p.Length == 1)
            {
                return false;
            }
            if(p[1] == '*')
            {
                return IsMatch(s, p.Substring(2));
            }
            return false;
        }

        if(p == "")
        {
            return false;
        }

        if(s[0] == p[0] || p[0] == '.')
        {
            if(p.Length > 1 && p[1] == '*')
            {
                return IsMatch(s.Substring(1), p)
                       || IsMatch(s, p.Substring(2));
            }
            return IsMatch(s.Substring(1), p.Substring(1));
        }
        if(p.Length > 1 && p[1] == '*')
        {
            return IsMatch(s, p.Substring(2));
        }
        return false;
    }
}