// See https://aka.ms/new-console-template for more information

var tests = File.ReadAllLines("C:\\Users\\Ben W\\Desktop\\Code\\LeetCode\\tests.txt")
    .Select(test => test.Split(' '))
    .Select(test => (m: int.Parse(test[0]), n: int.Parse(test[1])))
    .ToList();

foreach (var test in tests)
{
    Console.WriteLine(Leet.UniquePaths(test.m, test.n));
}


static class Leet
{
    public static int UniquePaths(int m, int n)
    {
        /*
         * nCr = (m + n - 2)! / ((m - 1)! (n - 1)!)
         * T-Complexity = O(m * n)
         *
         * Could simplify to
         * nCr = (m + n - 2) * (m + n - 3) * ... * (m + n - n) / (n - 1)!
         * or
         * nCr = (m + n - 2) * (m + n - 3) * ... * (n + m - m) / (m - 1)!
         * and optimize off of these to obtain O(min(m, n))
         * Note: this also keeps the numbers small when implemented properly
         */
        
        var calculation = 1l;
        var multiple = m + n - 2;
        
        for (var div = 1; multiple >= Math.Max(m, n); div++)
        {
            calculation = (calculation * multiple) / div;
            multiple--;
        }
        
        return (int) calculation;
    }

    private static long Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        
        return Enumerable.Range(1, n).Aggregate(1l, (x, y) => x * y);
    }
}