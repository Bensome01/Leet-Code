// See https://aka.ms/new-console-template for more information

using System.Text;

//var tests = File.ReadAllLines("./tests.txt").ToList();

var num = 3749;

Console.WriteLine(Leet.IntToRoman(num));


static class Leet
{
    public static string IntToRoman(int num) {
        string romanNum = "";
        int curNum = num;
        
        while(curNum >= 1000)
        {
            romanNum += 'M';
            curNum -= 1000;
        }

        if(curNum - 900 >= 0)
        {
            romanNum += "CM";
            curNum -= 900;
        }

        if(curNum - 500 >= 0)
        {
            romanNum += 'D';
            curNum -= 500;
        }

        if(curNum - 400 >= 0)
        {
            romanNum += "CD";
            curNum -= 400;
        }

        while(curNum >= 100)
        {
            romanNum += "C";
            curNum -= 100;
        }

        if(curNum - 90 >= 0)
        {
            romanNum += "XC";
            curNum -= 90;
        }

        if(curNum - 50 >= 0)
        {
            romanNum += "L";
            curNum -= 50;
        }

        if(curNum - 40 >= 0)
        {
            romanNum += "XL";
            curNum -= 40;
        }

        while(curNum >= 10)
        {
            romanNum += 'X';
            curNum -= 10;
        }

        if(curNum >= 9)
        {
            romanNum += "IX";
            curNum -= 9;
        }

        if(curNum >= 5)
        {
            romanNum += "V";
            curNum -= 5;
        }

        if(curNum >= 4)
        {
            romanNum += "IV";
            curNum -= 4;
        }

        while(curNum >= 1)
        {
            romanNum += 'I';
            curNum--;
        }

        return romanNum;
    }
}