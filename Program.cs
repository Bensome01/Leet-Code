// See https://aka.ms/new-console-template for more information

using System.Text;

//var tests = File.ReadAllLines("./tests.txt").ToList();

var nums = new [] { 2, 7, 11, 15 };
var target = 9;

Console.WriteLine(Leet.TwoSum(nums, target));


static class Leet
{
    public static int[] TwoSum(int[] nums, int target) {
        int[] arr = new int[2];
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                if(nums[i] + nums[j] == target)
                {
                    arr[0] = i;
                    arr[1] = j;
                    return arr;
                }
            }
        }

        return arr;
    }
}