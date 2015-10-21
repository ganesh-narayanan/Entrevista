// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedListNode.cs" company="">
//   
// </copyright>
// <summary>
//   The linked list node.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GaneshNarayanan.Entrevista.LinkedList
{
    /// <summary>The linked list node.</summary>
    /// <typeparam name="T">Any type of Object</typeparam>
    public class LinkedListNode<T>
    {
        /// <summary>Initializes a new instance of the <see cref="LinkedListNode{T}"/> class.</summary>
        /// <param name="data">The data.</param>
        /// <param name="next">The next.</param>
        public LinkedListNode(T data, LinkedListNode<T> next)
        {
            this.Data = data;
            this.Next = next;
        }

        /// <summary>Gets or sets the data.</summary>
        public T Data { get; set; }

        /// <summary>Gets or sets the next.</summary>
        public LinkedListNode<T> Next { get; set; }

    }
}