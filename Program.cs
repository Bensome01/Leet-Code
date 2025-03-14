// See https://aka.ms/new-console-template for more information

using System.Text;

//var tests = File.ReadAllLines("./tests.txt").ToList();

var nodes = new[] { 1, 2, 3, 4 };

var head = nodes.Reverse().Aggregate(new ListNode(5), (list, node) =>
    {
        return new ListNode(node, list);
    });
var n = 2;

Console.WriteLine(Leet.RemoveNthFromEnd(head, n));


static class Leet
{
    public static ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head.next == null)
        {
            return null;
        }

        ListNode trail = head;
        ListNode end = head.next;
        int listLength = 2;
        while(end.next != null)
        {
            end = end.next;
            if(listLength >= n + 1)
            {
                trail = trail.next;
            }
            listLength++;
        }

        if(listLength == n)
        {
            return trail.next;
        }

        trail.next = trail.next.next;

        return head;
    }
}

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
}
