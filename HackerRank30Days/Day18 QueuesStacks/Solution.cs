using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HackerRank30Days.Day18_QueuesStacks
{
    internal class SolutionQue
    {
        /// <summary>
        /// como trabajamos con char se declar Queue<char>
        /// </summary>
        Queue<char> queue;  //cola
        Stack<char> stack;  //pila


        //Constructores
        /// <summary>
        /// Se inicializa las variables en el constructor, siempre con un tipo char o el tipo de dato con el 
        /// que se trabaje.
        /// </summary>
        public SolutionQue()
        {
            queue = new Queue<char>();
            stack = new Stack<char>();
        }

        //Method stacks (pilas/lifo)
        /// <summary>
        /// Métodos principales:
        /// 
        // push(T item) : Agrega un elemento item al tope de la pila.
        // pop(): Elimina y devuelve el elemento que está en la cima de la pila.
        // peek(): Devuelve el elemento superior de la pila sin quitarlo.
        // empty(): Devuelve true si la pila está vacía; de lo contrario, false. 
        // size() : Devuelve el número de elementos en la pila.
        /// </summary>
        /// <param name="ch"></param>
        public void pushCharacter(char ch)
        {
            stack.Push(ch);
        }
        public char popCharacter()
        {
            return stack.Pop();
        }


        //Method Queue (Colas/fifo)
        /// <summary>
        /// Métodos principales de la clase Queue<T>:
        /// 
        // Enqueue(T item): Agrega un elemento al final de la cola. 
        // Dequeue() : Elimina y devuelve el elemento del frente de la cola.
        // Peek(): Devuelve el elemento del frente de la cola sin eliminarlo.
        // Count: Obtiene el número de elementos en la cola. 
        // Clear(): Elimina todos los elementos de la cola.
        // Contains(T item): Determina si un elemento específico está en la cola.
        /// </summary>
        /// <param name="ch"></param>
        public void enqueueCharacter(char ch)
        {
            queue.Enqueue(ch);
        }
        public char dequeueCharacter()
        {
            return queue.Dequeue();
        }


    }
}
