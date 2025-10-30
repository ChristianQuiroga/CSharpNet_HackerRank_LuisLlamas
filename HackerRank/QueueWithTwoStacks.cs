using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class QueueWithTwoStacks
    {
        private readonly Stack<int> stackIn = new Stack<int>();
        private readonly Stack<int> stackOut = new Stack<int>();

        // 1 x
        public void Enqueue(int x)
        {
            stackIn.Push(x);
        }

        // 2
        public void Dequeue()
        {
            PrepareStackOut();
            if (stackOut.Count > 0)
                stackOut.Pop();
        }

        // 3
        public int Peek()
        {
            PrepareStackOut();
            return stackOut.Peek();
        }

        // Mueve elementos de stackIn a stackOut solo cuando stackOut esta vacia
        private void PrepareStackOut()
        {
            if (stackOut.Count == 0)
            {
                while (stackIn.Count > 0)
                {
                    stackOut.Push(stackIn.Pop());
                }
            }
        }
    }
    
}
