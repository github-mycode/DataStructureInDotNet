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

        public static void InsertNode(ListNode head, int data, int location)
        {
            int count = 0;
            ListNode node = new ListNode(data);
            ListNode currentNode = head;
            while (currentNode.Next != null )
            {
                count++;
                if(count == location)
                {
                    node.Next = currentNode.Next;
                    currentNode.Next = node;
                    break;
                }
                currentNode = currentNode.Next;
            }  
        }

        public static void InsertNodeAtEnd(ListNode head, int data)
        {
            ListNode node = new ListNode(data);
            ListNode currentNode = head;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Next = node;
        }

        public static ListNode DeleteNodeAtFront(ListNode head)
        {
            return head.Next;
        }

        public static ListNode DeleteNode(ListNode head, int location)
        {
            int count = 1;
            ListNode currentNode = head;
            while(currentNode != null)
            {

                if(count == location)
                {
                    if(currentNode !=null)
                        currentNode = currentNode.Next;
                        return head;
                }

                count++;
                currentNode = currentNode.Next;
            }
            return head;
        }
    }
}
