namespace Solutions
{
    public class LNode //rename this to ListNode in leetcode since I already have ListNode under this namespace from other problem.
    {
        public int val;
        public LNode next;

        public LNode(int val = 0, LNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public partial class Solution
    {
        public LNode ReverseList(LNode head)
        {
            var x = RecursiveDescent(head, null);
            var y = SlidingWindow(head);
            return y;
        }

        //solving by recurvsive descent
        private LNode RecursiveDescent(LNode current, LNode result)
        {
            if (current == null) // Will only hit at the end of the node, that is when we return the result
            {
                return result;
            }

            LNode nextNode = current.next;
            current.next = result;

            return RecursiveDescent(nextNode, current);
        }

        //solving by sliding window
        private LNode SlidingWindow(LNode head)
        {
            LNode result = null;
            LNode current = head;

            while (current != null)
            {
                var nextNode = current.next;
                current.next = result;
                result = current;
                current = nextNode;
            }
            return result;
        }
    }
}