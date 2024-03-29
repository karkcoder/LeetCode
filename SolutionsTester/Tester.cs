using Solutions;
using Xunit;

namespace SolutionsTester
{
    public class Tester
    {
        private Solution _sut;

        public Tester()
        {
            _sut = new Solution();
        }

        [Fact]
        public void ReverseLinkedList()
        {
            LNode l = new LNode(1, null);
            l.next = new LNode(2, null);
            l.next.next = new LNode(3, null);

            var result = _sut.ReverseList(l);
        }

        [Fact]
        public void ValidParentheses()
        {
            var result = _sut.IsValid("()[]{}");
            Assert.True(result);
        }

        [Fact]
        public void BestTimeToBuySellStock()
        {
            var result = _sut.MaxProfit(new int[] { 7, 2, 5, 1, 6, 4 });
            Assert.Equal(5, result);
        }

        [Fact]
        public void ValidatePalindome()
        {
            var result = _sut.IsPalindrome("A man, a plan, a canal: Panama");
            Assert.True(result);
        }

        [Fact]
        public void AnagramTest()
        {
            var result = _sut.IsAnagram("anagram", "nagaram");
            Assert.True(result);
        }

        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 4)]
        public void LengthOfLongestSubstringSolutionTest(string input, int result)
        {
            var value = _sut.LengthOfLongestSubstring(input);
            Assert.Equal(result, value);
        }

        [Fact]
        public void _3sumtester()
        {
            var nums = new int[3] { 0, 0, 0 };

            _sut.ThreeSum(nums);
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
            _sut.StrStr("aaaaabba", "bba");
        }

        [Fact]
        public void ContainsDuplicateTest()
        {
            int[] theArray = { 1, 3, 5, 7, 9 };
            var result = _sut.ContainsDuplicate(theArray);
            Assert.False(result);
        }

        [Fact]
        public void ImplementTrieTest()
        {
            Trie trie = new Trie();
            trie.Insert("hello");
            var exactWordTest = trie.Search("hel");
            var prefixWordTest = trie.StartsWith("hel");

            Assert.False(exactWordTest);
            Assert.True(prefixWordTest);
        }
    }
}