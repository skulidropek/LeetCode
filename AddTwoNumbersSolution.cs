using Newtonsoft.Json.Linq;
using System.Numerics;

namespace LeetCode
{
    public class AddTwoNumbersSolution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var value = GetNumber(l1) + GetNumber(l2);

            var result = CreateListNode(value);

            return result;
        }

        public static ListNode CreateListNode(BigInteger number)
        {
            var remainder = (int)(number % 10);
            ListNode result = new ListNode(remainder);

            number /= 10;

            if(number == 0)
                return result;

            result.next = CreateListNode(number);
            return result;
        }

        public static BigInteger GetNumber(ListNode listNode)
        {
            if (listNode.next == null)
                return listNode.val;

            var next = GetNumber(listNode.next) * 10;
            return listNode.val + next;
        }
    }
}
