// See https://aka.ms/new-console-template for more information

using System.Text;

//var tests = File.ReadAllLines("./tests.txt").ToList();

var s = "III";

Console.WriteLine(Leet.RomanToInt(s));


static class Leet
{
    public static int RomanToInt(string s) {
        int num = 0;

        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == 'M')
            {
                num += 1000;
            }
            else if(s[i] == 'D')
            {
                num += 500;
            }
            else if(s[i] == 'C')
            {
                if(s.Length >= i + 2 && s[i + 1] == 'M')
                {
                    num += 900;
                    i++;
                }
                else if(s.Length >= i + 2 && s[i + 1] == 'D')
                {
                    num += 400;
                    i++;
                }
                else
                {
                    num += 100;
                }
            }
            else if(s[i] == 'L')
            {
                num += 50;
            }
            else if(s[i] == 'X')
            {
                if(s.Length >= i + 2 && s[i + 1] == 'C')
                {
                    num += 90;
                    i++;
                }
                else if(s.Length >= i + 2 && s[i + 1] == 'L')
                {
                    num += 40;
                    i++;
                }
                else
                {
                    num += 10;
                }
            }
            else if(s[i] == 'V')
            {
                num += 5;
            }
            else
            {
                if(s.Length >= i + 2 && s[i + 1] == 'X')
                {
                    num += 9;
                    i++;
                }
                else if(s.Length >= i + 2 && s[i + 1] == 'V')
                {
                    num += 4;
                    i++;
                }
                else
                {
                    num++;
                }
            }
        }

        return num;
    }
}