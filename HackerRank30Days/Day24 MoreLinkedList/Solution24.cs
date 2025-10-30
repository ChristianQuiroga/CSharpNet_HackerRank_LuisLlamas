using HackerRank30Days.Day15LinkedList;
using HackerRank30Days.Day24_MoreLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Days.Day24_MoreLinkedList
{
    internal class Solution24
    {

        // Methods
        public static Node24 RemoveDuplicates(Node24 head)
        {
            //Write your code here
            var current = head;  // la cabezera la pasamos a un VAR (current valor actual) Current es un Nodo que arranca en 1.
            while (current.next != null)  // si No es nulo ingresa
            {
                if (current.data == current.next.data) // toma el primer valor 1 es igual a next.data 2, es false.
                {
                    current.next = current.next.next;
                } 
                else current = current.next;    // asigna el siguiente Nodo 2, a current y vuelve al While
            }
            return head;

        }
        public static Node24 Insert(Node24 head, int data)
        {
            Node24 p = new Node24(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node24 start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }
        public static void Display(Node24 head)
        {
            Node24 start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
    }
}
