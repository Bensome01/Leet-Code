// See https://aka.ms/new-console-template for more information

using System.Text;

//var tests = File.ReadAllLines("./tests.txt").ToList();

var x = 123;

Console.WriteLine(Leet.Reverse(1));


static class Leet
{
    public static int Reverse(int x) {
        string s = x.ToString();
        string reverse = "";
        for(int i = s.Length - 1; i >= 0; i--)
        {
            reverse += s[i];
        }
        if(s[0] == '-')
        {
            reverse = '-' + reverse.Substring(0, reverse.Length - 1);
        }
        int num;
        int.TryParse(reverse, out num);
        return num;
    }
}