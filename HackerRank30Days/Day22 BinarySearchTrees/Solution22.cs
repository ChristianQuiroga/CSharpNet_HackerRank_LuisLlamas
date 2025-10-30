using HackerRank30Days.Day15LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Days.Day22_BinarySearchTrees
{
    class Solution22
    {
        
        
        //método ejercicio 23 Level-Order traveral (BFS)
        public static void LevelOrder(Node22 root)
        {
            if (root != null)
            {
                Queue<Node22> breath = new Queue<Node22>();
                breath.Enqueue(root);

                while (breath.Count > 0)
                {
                    var tmpNode = breath.Dequeue();
                    //if (tmpNode == null)
                    //{
                    //    continue;
                    //}
                    breath.Enqueue(tmpNode.left);
                    breath.Enqueue(tmpNode.right);
                    Console.Write(tmpNode.data + " ");
                }
            }
        }
        public static int getHeight(Node22 root)
        {
            if (root == null)
            {
                return -1; // height of empty tree is -1
            }
            //int left = getHeight(root.left);
            //int right = getHeight(root.right);

            //return Math.Max(left,right) + 1;
            return 1 + Math.Max(getHeight(root.left), getHeight(root.right));
        }
        public static Node22 Insert(Node22 root, int data) //day22 BST
        {
            if (root == null)  // si root es nulo ingresa y crea el objeto Node22
            {
                return new Node22(data);
            }
            else
            {
                Node22 cur;     // se crea otro cursor, para poder ir trabajando con el Root (raiz) como un temporal o cursor.
                if (data <= root.data)
                {
                    cur = Insert(root.left, data); //Método Recursivo
                    root.left = cur;        //pasamos en nuevo valor de cur a root.left.
                }
                else
                {
                    cur = Insert(root.right, data); //Método recursivo, en nuevo valor lo ingresa en CUR, antes va al constructor Node22
                    root.right = cur;
                }
                return root;
            }
        }
    }
}
