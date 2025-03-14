// See https://aka.ms/new-console-template for more information

using System.Text;

//var tests = File.ReadAllLines("./tests.txt").ToList();

var height = new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

Console.WriteLine(Leet.MaxArea(height));


static class Leet
{
    public static int MaxArea(int[] height) {
        int maxArea = 0;
        int i = 0;
        int j = height.Length - 1;

        while(i < j)
        {
            int h;
            int l = j - i;

            if(height[i] > height[j])
            {
                h = height[j];
                j--;
            }
            else
            {
                h = height[i];
                i++;
            }

            maxArea = Math.Max(maxArea, l * h);
        }

        return maxArea;
    }
}