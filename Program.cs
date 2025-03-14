// See https://aka.ms/new-console-template for more information

using System.Text;

//var tests = File.ReadAllLines("./tests.txt").ToList();

var l1 = new ListNode(2,
    new ListNode(4,
        new ListNode(3)));
var l2 = new ListNode(52,
    new ListNode(6,
        new ListNode(4)));

Console.WriteLine(Leet.AddTwoNumbers(l1, l2));


static class Leet
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode ret = new ListNode();
        ListNode walker = ret;
        int carry = 0;
        while(l1.next != null && l2.next != null)
        {
            walker.val = l1.val + l2.val + carry;
            carry = walker.val / 10;
            walker.val = walker.val % 10;
            l1 = l1.next;
            l2 = l2.next;
            walker.next = new ListNode();
            walker = walker.next;
        }
        walker.val = l1.val + l2.val + carry;
        carry = walker.val / 10;
        walker.val = walker.val % 10;
        if(l1.next == null && l2.next == null);
        else if(l1.next == null)
        {
            do
            {
                l2 = l2.next;
                walker.next = new ListNode();
                walker = walker.next;
                walker.val = l2.val + carry;
                carry = walker.val / 10;
                walker.val = walker.val % 10;
            }
            while(l2.next != null);
        }
        else
        {
            do
            {
                l1 = l1.next;
                walker.next = new ListNode();
                walker = walker.next;
                walker.val = l1.val + carry;
                carry = walker.val / 10;
                walker.val = walker.val % 10;
            }
            while(l1.next != null);
        }

        if(carry == 1)
        {
            walker.next = new ListNode();
            walker = walker.next;
            walker.val = 1;
        }

        return ret;
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