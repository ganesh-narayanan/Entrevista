// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedListTests.cs" company="">
//   
// </copyright>
// <summary>
//   The linked list tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GaneshNarayanan.Entrevista.LinkedList
{
    using System.IO;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>The linked list tests.</summary>
    [TestClass]
    public class LinkedListTests
    {
        /// <summary>The test singly linked list.</summary>
        /// <exception cref="IOException">An I/O error occurred. </exception>
        [TestMethod]
        public void TestSinglyLinkedList()
        {
            SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();
            singlyLinkedList.AddAtEnd(5);
            singlyLinkedList.AddAtEnd(6);
            singlyLinkedList.AddAtEnd(7);
            singlyLinkedList.AddAtEnd(8);
            singlyLinkedList.AddAtStart(4);
            singlyLinkedList.AddAtStart(3);
            singlyLinkedList.AddAtStart(2);
            singlyLinkedList.AddAtStart(1);
            singlyLinkedList.Add(9, 10);
            singlyLinkedList.Add(11, 9, true);
            singlyLinkedList.Add(10, 11);
        }
    }
}