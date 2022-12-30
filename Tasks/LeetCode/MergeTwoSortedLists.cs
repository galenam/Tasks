namespace Tasks.LeetCode;

  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
 /*
  * You are given the heads of two sorted linked lists list1 and list2.
Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.
Return the head of the merged linked list.
Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]
Example 2:
Input: list1 = [], list2 = []
Output: []
Example 3:
Input: list1 = [], list2 = [0]
Output: [0]
Constraints:
The number of nodes in both lists is in the range [0, 50].
-100 <= Node.val <= 100
Both list1 and list2 are sorted in non-decreasing order.
  */
public static class MergeTwoSortedLists
{
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode head = null;
        var curr1 = list1;
        var curr2 = list2;
        ListNode list = null;
        while (curr1!=null || curr2!= null )
        {
            ListNode merged;
            if (curr1 != null && curr2 == null)
            {
                merged = new ListNode(curr1.val);
                curr1 = curr1.next;
            }
            else if (curr1 == null && curr2 != null)
            {
                merged = new ListNode(curr2.val);
                curr2 = curr2.next;
            }
            else
            {
                var val = 0;
                if (curr1.val > curr2.val)
                {
                    val = curr2.val;
                    curr2 = curr2.next;
                }
                else
                {
                    val = curr1.val;
                    curr1 = curr1.next;
                }
                merged = new ListNode(val);
            }

            if (head == null)
            {
                head = merged;
            }

            if (list == null)
            {
                list = merged;
            }
            else
            {
                list.next = merged;
                list = list.next;
            }
        }

        return head;
    } 
}