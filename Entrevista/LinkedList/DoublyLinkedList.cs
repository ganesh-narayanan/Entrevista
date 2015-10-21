// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DoublyLinkedList.cs" company="">
//   
// </copyright>
// <summary>
//   The doubly linked list.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GaneshNarayanan.Entrevista.LinkedList
{
    /// <summary>The doubly linked list.</summary>
    /// <typeparam name="T">Any type of Object</typeparam>
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedList()
        {
        }
        /// <summary>The doubly linked list node.</summary>
        /// <typeparam name="TU">Any type of Object</typeparam>
        private class DoublyLinkedListNode<TU> : LinkedListNode<TU>
        {
            /// <summary>Initializes a new instance of the <see cref="DoublyLinkedListNode{TU}"/> class.</summary>
            /// <param name="data">The data.</param>
            /// <param name="next">The next.</param>
            /// <param name="previous">The previous</param>
            public DoublyLinkedListNode(TU data, LinkedListNode<TU> next, LinkedListNode<TU> previous)
                : base(data, next)
            {
                this.Previous = previous;
            }

            /// <summary>Gets or sets the previous.</summary>
            public LinkedListNode<TU> Previous { get; set; }

        }
    }
}