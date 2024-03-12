using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class AddTwoNumbers
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
        public ListNode AddTwoNumbersMethod(ListNode l1, ListNode l2)
        {
            var res = new ListNode();
            while (l1 != null)
            {
                var temp = l1.val + l1.val;
                if (temp <= 9)
                {
                    res.val = temp;
                }
                else
                {
                    res.val = temp - 9;
                    temp -= 9;
                    res.next 
                    res.val = temp;
                }
                l1 = l1.next;
                l2 = l2.next;
            }
            return res;
        }
    }
}
