// See https://aka.ms/new-console-template for more information

using System.Text;

//var tests = File.ReadAllLines("./tests.txt").ToList();

var nums = new[] { -1, 2, 1, -4 };
var target = 1;

Console.WriteLine(Leet.ThreeSumClosest(nums, target));


static class Leet
{
    public static int ThreeSumClosest(int[] nums, int target) {
        int[] sortedNums = MergeSort(nums, 0, nums.Length);

        int distance = int.MaxValue;
        int newDistance;
        int left;
        int right;

        for(int i = 0; i < sortedNums.Length - 2; i++)
        {
            left = i + 1;
            right = nums.Length - 1;
            while(left < right)
            {
                newDistance = sortedNums[i] + sortedNums[left] + sortedNums[right] - target;
                if(Math.Abs(distance) > Math.Abs(newDistance))
                {
                    distance = newDistance;
                    if(distance == 0) return target + distance;
                }

                if(newDistance > 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
        }
        return target + distance;
    }

    private static int[] MergeSort(int[] arr, int start, int length)
    {
        if(length <= 1)
        {
            if(length == 1)
            {
                return new int[1]{arr[start]};
            }
            else
            {
                return new int[0]{};
            }
        }

        int[] left = MergeSort(arr, start, length / 2);
        int[] right = MergeSort(arr, length / 2 + start, (length / 2) + (length % 2));
        int[] merge = new int[left.Length + right.Length];

        int i = 0;
        int j = 0;
        while(i < left.Length && j < right.Length)
        {
            if(left[i] < right[j])
            {
                merge[i + j] = left[i];
                i++;
            }
            else
            {
                merge[i + j] = right[j];
                j++;
            }
        }
        for(; i < left.Length; i++)
        {
            merge[i + j] = left[i];
        }
        for(; j < right.Length; j++)
        {
            merge[i + j] = right[j];
        }

        return merge;
    }
}