using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    public class ListNode
    {
        public int Data;
        public ListNode Next;

        public ListNode(int data)
        {
            this.Data = data;
            this.Next = null;
        }

        public static void PrintNode(ListNode head)
        {
            while(head != null)
            {
                Console.WriteLine(head.Data + " ");
                head = head.Next;
            }
        }

        public static int GetLength(ListNode head)
        {
            int length = 0;
            while (head != null)
            {
                head = head.Next;
                length++;
            }
            return length;
        }

        public static void InsertNode(ListNode head, int data)
        {
            ListNode node = new ListNode(data);
            ListNode currentNode = head;
            while(currentNode.Next != null) 
            { 
                currentNode = currentNode.Next;
            }
            currentNode.Next = node;
        }
    }
}
