using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

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
            var nums = new int[3] { 0, 0, 0 };

            var sut = new _3sum().ThreeSum(nums);

        }

        [TestMethod]
        public void AddTwoNumberTest()
        {
            ListNode listNode = new ListNode(2);
            listNode.next = new ListNode(3);
            listNode.next.next = new ListNode(4);
        }

        [TestMethod]
        public void StrStrTest()
		{
            StrStrSolution strtest = new StrStrSolution();
            strtest.StrStr("aaaaabba", "bba");
        }
    }
}
