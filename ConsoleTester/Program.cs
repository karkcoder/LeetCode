using Solutions;

namespace ConsoleTester
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Solution s = new Solution();
            LNode l = new LNode(1, null);
            l.next = new LNode(2, null);
            l.next.next = new LNode(3, null);

            s.ReverseList(l);
        }
    }
}