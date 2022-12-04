using System;

namespace Solutions
{
	public class TwoSumSolution
	{
		public int[] TwoSum(int[] nums, int target)
		{
			int[] result = new int[2];

			for (int i = 0; i < nums.Length; i++)
			{
				var nextIndex = Array.IndexOf(nums, target - nums[i]);
				if (i != nextIndex){
					if (nextIndex > -1)
					{
						result[0] = i;
						result[1] = nextIndex;
						return result;
					}
				}
			}

			return nums;
		}
	}
}
