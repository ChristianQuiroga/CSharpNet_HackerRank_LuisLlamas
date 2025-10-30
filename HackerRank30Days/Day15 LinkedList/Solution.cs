using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Days.Day15LinkedList
{
    class Solution
    {
        public static Node insert(Node head, int data)
        {
            //Complete this method
            Node newNode = new Node(data);

            if (head == null)
            {
                return newNode;
            }

            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }

            current.next = newNode;
            return head;

        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.WriteLine(start.data + " ");
                start = start.next;
            }
        }
    }
}
