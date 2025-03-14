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
    public static int UniquePaths(int m, int n) {
        //m => y, n => x
        var grid = Enumerable.Range(0, m)
            .Select(row => new int[n])
            .ToArray();
        grid[0][0] = 1;
        

        var nextSteps = new Queue<Coordinate>();
        
        if (m > 1)
        {
            nextSteps.Enqueue(new Coordinate(0, 1));
        }

        if (n > 1)
        {
            nextSteps.Enqueue(new Coordinate(1, 0));
        }

        while (nextSteps.Count > 0)
        {
            var nextStep = nextSteps.Dequeue();
        
            grid[nextStep.y][nextStep.x] = 0;
            
            if (nextStep.y > 0)
            {
                grid[nextStep.y][nextStep.x] += grid[nextStep.y - 1][nextStep.x];
            }
        
            if (nextStep.x > 0)
            {
                grid[nextStep.y][nextStep.x] += grid[nextStep.y][nextStep.x - 1];
            }
            
            var moveDown = new Coordinate(nextStep.x, nextStep.y + 1);
            var moveRight = new Coordinate(nextStep.x + 1, nextStep.y);
        
            if (moveDown.y < m)
            {
                nextSteps.Enqueue(moveDown);
            }
        
            if (moveRight.x < n)
            {
                nextSteps.Enqueue(moveRight);
            }
        }
        
        return grid[m - 1][n - 1];
    }

    // private static void PrintGrid(int[][] grid)
    // {
    //     foreach(var row in grid)
    //     {
    //         foreach (var column in row)
    //         {
    //             Console.Write(column + " ");
    //         }
    //         Console.WriteLine();
    //     }
    // }
    
    private record Coordinate(int x, int y);
}