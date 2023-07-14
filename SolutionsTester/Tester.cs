using Solutions;
using Xunit;

namespace SolutionsTester
{
    public class Tester
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 4)]
        public void LengthOfLongestSubstringSolutionTest(string input, int result)
        {
            var sut = new LengthOfLongestSubstringSolution().LengthOfLongestSubstring(input);
            Assert.Equal(result, sut);
        }


        [Fact]
        public void _3sumtester()
        {
            var nums = new int[3] { 0, 0, 0 };

            var sut = new _3sum().ThreeSum(nums);

        }

        [Fact]
        public void AddTwoNumberTest()
        {
            ListNode listNode = new ListNode(2);
            listNode.next = new ListNode(3);
            listNode.next.next = new ListNode(4);
        }

        [Fact]
        public void StrStrTest()
        {
            StrStrSolution strtest = new StrStrSolution();
            strtest.StrStr("aaaaabba", "bba");
        }

        [Fact]
        public void ContainsDuplicateTest()
        {
            ContainsDuplicateSolution containsDuplicateTest = new ContainsDuplicateSolution();
            int[] theArray = { 1, 3, 5, 7, 9 };
            var result = containsDuplicateTest.ContainsDuplicate(theArray);
            Assert.False(result);

        }
    }
}
