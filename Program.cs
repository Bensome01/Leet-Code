// See https://aka.ms/new-console-template for more information

using System.Text;

//var tests = File.ReadAllLines("./tests.txt").ToList();

var digits = "23";

Console.WriteLine(Leet.LetterCombinations(digits));


static class Leet
{
    public static IList<string> LetterCombinations(string digits) {
        return digits.Aggregate(Enumerable.Empty<string>(),
                (combinations, digit) => GenerateLetterCombinations(digit, combinations))
            .ToList();
    }

    private static IEnumerable<string> GenerateLetterCombinations(
        char num,
        IEnumerable<string> currentCombinations)
    {
        var numToCharConverter = new Dictionary<char, char[]>
        {
            {'2', ['a', 'b', 'c']},
            {'3', ['d', 'e', 'f']},
            {'4', ['g', 'h', 'i']},
            {'5', ['j', 'k', 'l']},
            {'6', ['m', 'n', 'o']},
            {'7', ['p', 'q', 'r', 's']},
            {'8', ['t', 'u', 'v']},
            {'9', ['w', 'x', 'y', 'z']},
        };
        
        return numToCharConverter[num].Aggregate(Enumerable.Empty<string>(),
            (current, numToChar) => current
                .Concat(currentCombinations.Any()
                    ? currentCombinations.Select(combination => combination + numToChar)
                    : ["" + numToChar]));
    }
}