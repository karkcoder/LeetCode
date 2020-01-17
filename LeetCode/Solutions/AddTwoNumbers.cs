namespace Solutions
{

	//Input: (2 -> 4 -> 3) 342
	//     + (5 -> 6 -> 4) 465
	//Output: 7 -> 0 -> 8
	//Explanation: 342 + 465 = 807.

	public class ListNode
	{
		public int val;
		public ListNode next;

		public ListNode(int x)
		{
			val = x;
		}


		public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			var sum = l1.val + l2.val;
			int coef = 0;
			if (sum > 9)
			{
				coef = sum % 10;
			}
			ListNode result = new ListNode();

			SumRecur(l1.next, l2.next, coef, );
		}

		public ListNode SumRecur(ListNode l1, ListNode l2, int coef)
		{
			if (l1 != null && l1 != null)
			{
			}

		}
	}
}