// See https://aka.ms/new-console-template for more information

using System.Text;

//var tests = File.ReadAllLines("./tests.txt").ToList();

var s = "PAYPALISHIRING";
var numRows = 3;

Console.WriteLine(Leet.Convert(s, numRows));


static class Leet
{
    public static string Convert(string s, int numRows) {
        if (numRows == 1) return s;
        string zigzag = "";
        int zigSize = numRows * 2 - 2;
        int indexIncrement;
        for (int i = 0; i < numRows; i++)
        {
            indexIncrement = (zigSize - i * 2) % zigSize;
            for (int j = i; j < s.Length;)
            {
                zigzag += s[j];
                indexIncrement = ((indexIncrement * (zigSize - 1)) % zigSize);
                j += zigSize - indexIncrement;
            }
        }
        return zigzag;
    }
}