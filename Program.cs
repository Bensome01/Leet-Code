// See https://aka.ms/new-console-template for more information

using System.Text;

//var tests = File.ReadAllLines("./tests.txt").ToList();

var nums = new[] { -1, 0, 1, 2, -1, -4 };

Console.WriteLine(Leet.ThreeSum(nums));


static class Leet
{
    public static IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> triples = new List<IList<int>>();
        int[] sortedNums = MergeSort(nums, 0, nums.Length);
        int left ;
        int right;

        for(int i = 0; i < sortedNums.Length - 2 && sortedNums[i] <= 0; i++)
        {
            if(i != 0 && sortedNums[i] == sortedNums[i - 1])
            {
                continue;
            }
            left = i + 1;
            right = sortedNums.Length - 1;

            while(left < right)
            {
                if(left != i + 1
                && sortedNums[left - 1] == sortedNums[left])
                {
                    left++;
                    continue;
                }
                if(sortedNums[right] < 0
                || (right != sortedNums.Length - 1
                && sortedNums[right + 1] == sortedNums[right]))
                {
                    right--;
                    continue;
                }

                if(sortedNums[i] + sortedNums[left] + sortedNums[right] == 0)
                {
                    List<int> triple = new List<int>{sortedNums[i], sortedNums[left], sortedNums[right]};
                    triples.Add(triple);
                    left++;
                }
                else if(sortedNums[i] + sortedNums[left] + sortedNums[right] < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return triples;
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