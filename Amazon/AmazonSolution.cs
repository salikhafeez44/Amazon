using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Amazon
{
    public class AmazonSolution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {


            return 0;
        }

        public int LengthOfLongestSubstring(string s)
        {
            //Going to use sliding Window technique
            var a_pointer = 0;
            var b_pointer = 0;
            var max = 0;

            HashSet<char> hashSet = new HashSet<char>();
            if (s.Length == 1) { return 1; };

            while (b_pointer < s.Length)
            {
                if (!hashSet.Contains(s[b_pointer]))
                {
                    hashSet.Add(s[b_pointer]);
                    b_pointer++;

                    max = Math.Max(hashSet.Count, max);
                }
                else
                {
                    hashSet.Remove(s[a_pointer]);
                    a_pointer++;
                }
            }
            return max;

        }
    }
}
