namespace Tasks.LeetCode;

public static class AddTwoNumbersTask
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var sum = (l1.val + l2.val) % 10;
        var overflow = (l1.val + l2.val) / 10;
        var result = new ListNode(sum);
        var cur = result;
        while (l1.next != null && l2.next != null)
        {
            l1 = l1.next;
            l2 = l2.next;
            sum = (l1.val + l2.val + overflow) % 10;
            overflow = (l1.val + l2.val + overflow) / 10;
            cur.next = new ListNode(sum);
            cur = cur.next;
        }

        while (l1.next != null)
        {
            l1 = l1.next;
            sum = (l1.val + overflow) % 10;
            overflow = (l1.val + overflow) / 10;
            cur.next = new ListNode(sum);
            cur = cur.next;
        }

        while (l2.next != null)
        {
            l2 = l2.next;
            sum = (l2.val + overflow) % 10;
            overflow = (l2.val + overflow) / 10;
            cur.next = new ListNode(sum);
            cur = cur.next;
        }

        if (overflow > 0)
        {
            cur.next = new ListNode(overflow);
        }

        return result;
    }
}