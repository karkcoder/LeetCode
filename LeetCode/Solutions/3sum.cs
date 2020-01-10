using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public class _3sum
    {
        //Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.

        //Note:

        //The solution set must not contain duplicate triplets.

        //Example:

        //Given array nums = [-1, 0, 1, 2, -1, -4],

        //A solution set is:
        //[
        //  [-1, 0, 1],
        //  [-1, -1, 2]
        //]

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            var lists = new List<List<int>>();


            for (int i = 0; i < nums.Length; i++)
            {
                int right1 = i + 1;
                if (right1 < nums.Length - 1)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        int right2 = j + 2;
                        if (right2 <= nums.Length - 1)
                        {
                            if (nums[i] + nums[right1] + nums[right2] == 0)
                            {
                                var list = new List<int>();
                                list.Add(nums[i]);
                                list.Add(nums[right1]);
                                list.Add(nums[right2]);
                                lists.Add(list);
                            }
                        }
                    }
                }
            }
            return (IList<IList<int>>)lists;
        }
    }
}
