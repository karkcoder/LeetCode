using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;
using System.Collections.Generic;

namespace SolutionsTester
{
    [TestClass]
    public class Tester
    {
        [DataTestMethod]
        [DataRow("abcabcbb", 3)]
        [DataRow("bbbbb", 1)]
        [DataRow("pwwkew", 4)]
        public void LengthOfLongestSubstringSolutionTest(string input, int result)
        {
            var sut = new LengthOfLongestSubstringSolution().LengthOfLongestSubstring(input);
            Assert.AreEqual(result, sut, "Incorrect for" + input + result);
        }


        [TestMethod]
        public void _3sumtester()
        {
            var nums = new int[6] { -1, 0, 1, 2, -1, -4 };

            var sut = new _3sum().ThreeSum(nums);

        }
    }
}
