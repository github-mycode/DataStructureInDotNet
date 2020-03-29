using System;

namespace LinkedListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(3);
            head.Next.Next.Next = new ListNode(4);
            head.Next.Next.Next.Next = new ListNode(5);

            ListNode.PrintNode(head);
            head = ListNode.DeleteNode(head,3);
            ListNode.PrintNode(head);
            //Console.WriteLine("Length = " + ListNode.GetLength(head));
            //ListNode.InsertNode(head, 10);
            //ListNode.InsertNode(head, 11);
            //ListNode.InsertNode(head, 12);
            //ListNode.InsertNode(head, 13);
            //ListNode.InsertNode(head, 10, 2);
            //ListNode.InsertNodeAtEnd(head, 100);
            //ListNode.PrintNode(head);
        }
    }
}
