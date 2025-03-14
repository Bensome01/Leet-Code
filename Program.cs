// See https://aka.ms/new-console-template for more information

using System.Text;

//var tests = File.ReadAllLines("./tests.txt").ToList();

var nums1 = new[] { 1, 3 };
var nums2 = new[] { 2 };

Console.WriteLine(Leet.FindMedianSortedArrays(nums1, nums2));


static class Leet
{
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int middle = (nums1.Length + nums2.Length) / 2;
        if((nums1.Length + nums2.Length) % 2 == 0)
        {
            return ((double) findNumAtIndex(nums1, nums2, middle)
                    + findNumAtIndex(nums1, nums2, middle - 1))
                   / 2;
        }
        return (double) findNumAtIndex(nums1, nums2, middle);
    }

    private static int findNumAtIndex(int[] nums1, int[] nums2, int index)
    {
        if(nums1.Length == 0)
        {
            return nums2[0];
        }
        else if(nums2.Length == 0)
        {
            return nums1[0];
        }

        int nums1Middle = nums1.Length / 2;
        int nums2Middle = nums2.Length / 2;
        if(nums1Middle + nums2Middle < index)
        {
            if(nums1[nums1Middle] < nums2[nums2Middle])
            {
                return findNumAtIndex(nums1.Skip(nums1Middle + 1).ToArray(),
                    nums2,
                    index - nums1Middle - 1);
            }
            else
            {
                return findNumAtIndex(nums1,
                    nums2.Skip(nums2Middle + 1).ToArray(),
                    index - nums2Middle - 1);
            }
        }
        else
        {
            if(nums1[nums1Middle] < nums2[nums2Middle])
            {
                return findNumAtIndex(nums1,
                    nums2.SkipLast(nums2Middle).ToArray(),
                    index);
            }
            else
            {
                return findNumAtIndex(nums1.SkipLast(nums1Middle).ToArray(),
                    nums2,
                    index);
            }
        }
    }
}