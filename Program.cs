// See https://aka.ms/new-console-template for more information

using System.Text;

//var tests = File.ReadAllLines("./tests.txt").ToList();

var x = 121;

Console.WriteLine(Leet.IsPalindrome(x));


static class Leet
{
    public static bool IsPalindrome(int x) {
        string numString = x.ToString();

        for(int i = 0; i < numString.Length / 2; i++)
        {
            if(numString[i] != numString[numString.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}