// See https://aka.ms/new-console-template for more information

using System.Text;

var tests = File.ReadAllLines("./../../../tests.txt").ToList();

Console.WriteLine(Leet.Method());


static class Leet
{
    public static int Method()
    {
        return 1;
    }
}