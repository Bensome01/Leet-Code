// See https://aka.ms/new-console-template for more information

using System.Text;

var tests = File.ReadAllLines("./../../../tests.txt")
    .Select(test => test.Split(' '))
    .ToList();


foreach (var test in tests)
{
    Console.WriteLine(Leet.LongestCommonSubsequence(test[0], test[1]));
}

static class Leet
{
    public static int LongestCommonSubsequence(string text1, string text2)
    {
        var grid = new int[text1.Length + 1, text2.Length + 1];
        var lengthX = text1.Length + 1;
        var lengthY = text2.Length + 1;

        for (int x = 1; x < lengthX; x++)
        {
            for (int y = 1; y < lengthY; y++)
            {
                if (text1[x - 1] == text2[y - 1])
                {
                    grid[x, y] = grid[x - 1, y - 1] + 1;
                }
                else
                {
                    grid[x, y] = Math.Max(grid[x - 1, y], grid[x, y - 1]);
                }
            }
        }
        
        return grid[text1.Length, text2.Length];
    }
    
    private static void PrintGrid(int[][] grid)
    {
        for (int row = 0; row < grid.Length; row++)
        {
            for (int col = 0; col < grid[row].Length; col++)
            {
                Console.Write(grid[row][col] + " ");
            }
            Console.WriteLine();
        }
    }
}