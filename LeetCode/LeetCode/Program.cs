using Solutions;
using System;

namespace LeetCode
{
	class Program
	{
		static void Main(string[] args)
		{
			var twoSum = new TwoSumSolution();
			int[] nums = { 3,2,4 };
			var target = 6;

			var x = twoSum.TwoSum(nums, target);

			foreach (var y in x)
			{
				Console.WriteLine(y.ToString());
			}

			Console.ReadKey();
		}
	}
}
