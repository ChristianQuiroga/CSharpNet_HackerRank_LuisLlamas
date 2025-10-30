using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Days.Day22_BinarySearchTrees
{
    class Node22
    {
        public Node22 left, right;
        public int data;

        public Node22(int data) //Constructor
        {
            this.data = data;
            left = right = null;
        }
    }
}
