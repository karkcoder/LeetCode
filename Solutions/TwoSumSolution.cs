using System.Collections.Generic;

namespace Solutions
{
    public class TwoSumSolution
    {
        /// <summary>
        /// Input: nums = [2,7,11,15], target = 9
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> keyValues = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if (keyValues.ContainsKey(diff))
                {
                    return new int[] { keyValues[diff], i };
                }
                keyValues[nums[i]] = i;
            }
            return null;
        }
    }
}