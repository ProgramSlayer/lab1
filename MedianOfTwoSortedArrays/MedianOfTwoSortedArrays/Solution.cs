namespace MedianOfTwoSortedArrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            // Соединить 2 массива в 1, отсортировать его по возрастанию.
			var merged = nums1.Concat(nums2).OrderBy(n => n);
            int mergedLength = merged.Count();
            if (mergedLength % 2 == 0)
            {
                int half = mergedLength / 2;
                int a = half - 1;
                return (double)(merged.ElementAt(half) + merged.ElementAt(a)) / 2;
            }
            else
            {
                return merged.ElementAt(mergedLength / 2);
            }
        }

        public static void Main()
        {
            Solution s = new();
            int[] n1 = { 1, 2 };
            int[] n2 = { 3, 4 };
            double median = s.FindMedianSortedArrays(n1, n2);
            Console.WriteLine(median);
        }
    }
}
