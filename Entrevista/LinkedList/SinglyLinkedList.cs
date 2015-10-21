// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SinglyLinkedList.cs" company="">
//   
// </copyright>
// <summary>
//   The singly linked list.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GaneshNarayanan.Entrevista.LinkedList
{
    using System;
    using System.IO;

    /// <summary>The singly linked list.</summary>
    /// <typeparam name="T">Any type of Object</typeparam>
    public class SinglyLinkedList<T>
    {
        private Action<LinkedListNode<T>> actionToExecute;

        /// <summary>Initializes a new instance of the <see cref="SinglyLinkedList{T}"/> class.</summary>
        public SinglyLinkedList(Action<LinkedListNode<T>> actionToExecute = null)
        {
            this.actionToExecute = actionToExecute ?? this.Dump;
            this.Head = this.Tail = null;
        }

        /// <summary>Gets or sets the head.</summary>
        public LinkedListNode<T> Head { get; set; }

        /// <summary>Gets or sets the tail.</summary>
        private LinkedListNode<T> Tail { get; set; }

        /// <summary>The add.</summary>
        /// <param name="data">The data.</param>
        /// <param name="nodeValueToSearch">The node value to search.</param>
        /// <param name="afterNode">The after node.</param>
        public void Add(T data, T nodeValueToSearch, bool afterNode = false)
        {
            LinkedListNode<T> foundNode = afterNode
                                              ? this.FindNode(nodeValueToSearch, this.Head)
                                              : this.FindNodeBefore(nodeValueToSearch, this.Head);
            if (foundNode == null)
            {
                this.AddAtEnd(data);
            }
            else
            {
                LinkedListNode<T> newNode = new LinkedListNode<T>(data, null);
                var tempNode = foundNode.Next;
                foundNode.Next = newNode;
                newNode.Next = tempNode;
            }

            this.actionToExecute.Invoke(null);
        }

        /// <summary>The add at the end.</summary>
        /// <param name="data">The data.</param>
        public void AddAtEnd(T data)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(data, null);
            if (this.Head == null)
            {
                this.Head = newNode;
            }
            else
            {
                this.Tail.Next = newNode;
            }

            this.Tail = newNode;

            this.actionToExecute.Invoke(null);
        }

        /// <summary>The add at start.</summary>
        /// <param name="data">The data.</param>
        public void AddAtStart(T data)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(data, this.Head);
            this.Head = newNode;

            this.actionToExecute.Invoke(null);
        }

        /// <summary>The find node.</summary>
        /// <param name="nodeValueToSearch">The node value to search.</param>
        /// <param name="start">The start.</param>
        /// <returns>The <see cref="LinkedListNode"/>.</returns>
        public LinkedListNode<T> FindNode(T nodeValueToSearch, LinkedListNode<T> start)
        {
            LinkedListNode<T> iterator = start;
            while (iterator != null)
            {
                if (iterator.Data.Equals(nodeValueToSearch))
                {
                    return iterator;
                }

                iterator = iterator.Next;
            }

            return null;
        }

        /// <summary>The find node before.</summary>
        /// <param name="nodeValueToSearch">The node value to search.</param>
        /// <param name="start">The start.</param>
        /// <returns>The <see cref="LinkedListNode"/>.</returns>
        public LinkedListNode<T> FindNodeBefore(T nodeValueToSearch, LinkedListNode<T> start)
        {
            LinkedListNode<T> iterator = start;
            while (iterator.Next != null)
            {
                if (iterator.Next.Data.Equals(nodeValueToSearch))
                {
                    return iterator;
                }

                iterator = iterator.Next;
            }

            return null;
        }

        /// <exception cref="IOException">An I/O error occurred. </exception>
        public void Dump(LinkedListNode<T> start = null)
        {
            LinkedListNode<T> iterator = start ?? this.Head;
            while (iterator != null)
            {
                Console.Write(iterator.Data + " [" + iterator.Next?.Data.ToString() + "]  -> ");
                iterator = iterator.Next;
            }

            Console.WriteLine();
        }
    }
}