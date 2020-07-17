using System;

namespace Amazon
{
    class Program
    {
        static void Main(string[] args)
        {
            ////There are two sorted arrays nums1 and nums2 of size m and n respectively.
            ////Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).
            int[] num1 = { 0, 1, 2 };
            int[] num2 = { 3, 4, 5 };
            AmazonSolution amazonSolution = new AmazonSolution();
            double median = amazonSolution.FindMedianSortedArrays(num1, num2);
            Console.WriteLine("Median: {0}", median);



            ////Given a string, find the length of the longest substring without repeating characters.
            //string s = "pwwkew";
            //AmazonSolution amazonSolution = new AmazonSolution();
            //int count = amazonSolution.LengthOfLongestSubstring(s);
            //Console.WriteLine("Count: {0}", count);
        }
    }
}
