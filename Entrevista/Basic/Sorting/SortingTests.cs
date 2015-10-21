// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SortingTests.cs" company="">
//   
// </copyright>
// <summary>
//   The sorting tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GaneshNarayanan.Entrevista.Basic.Sorting
{
    using System;
    using System.IO;
    using System.Runtime.Serialization;
    using System.Security;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>The sorting tests.</summary>
    [TestClass]
    public class SortingTests
    {
        /// <summary>The test bubble sort.</summary>
        /// <exception cref="SerializationException">An error has occurred during serialization, such as if an object in the graph parameter is not marked as serializable. </exception>
        /// <exception cref="SecurityException">The caller does not have the required permission. </exception>
        /// <exception cref="IOException">An I/O error occurred. </exception>
        [TestMethod]
        public void TestBubbleSort()
        {
            foreach (int[] integerArray in Helpers<int>.IntegerArrays)
            {
                Console.WriteLine("New Pass");
                int[] integerArrayDeepCopy = GenericCopier<int[]>.DeepCopy(integerArray);
                NonRecursiveSorting<int>.BubbleSort(integerArrayDeepCopy);
                Console.WriteLine(Environment.NewLine);
            }
        }

        /// <summary>The test insertion sort.</summary>
        /// <exception cref="SerializationException">An error has occurred during serialization, such as if an object in the graph parameter is not marked as serializable. </exception>
        /// <exception cref="SecurityException">The caller does not have the required permission. </exception>
        /// <exception cref="IOException">An I/O error occurred. </exception>
        [TestMethod]
        public void TestInsertionSort()
        {
            foreach (int[] integerArray in Helpers<int>.IntegerArrays)
            {
                Console.WriteLine("New Pass");
                int[] integerArrayDeepCopy = GenericCopier<int[]>.DeepCopy(integerArray);
                NonRecursiveSorting<int>.InsertionSort(integerArrayDeepCopy);
                Console.WriteLine(Environment.NewLine);
            }
        }

        /// <summary>The test selection sort.</summary>
        /// <exception cref="SerializationException">An error has occurred during serialization, such as if an object in the graph parameter is not marked as serializable. </exception>
        /// <exception cref="SecurityException">The caller does not have the required permission. </exception>
        /// <exception cref="IOException">An I/O error occurred. </exception>
        [TestMethod]
        public void TestSelectionSort()
        {
            foreach (int[] integerArray in Helpers<int>.IntegerArrays)
            {
                Console.WriteLine("New Pass");
                int[] integerArrayDeepCopy = GenericCopier<int[]>.DeepCopy(integerArray);
                NonRecursiveSorting<int>.SelectionSort(integerArrayDeepCopy);
                Console.WriteLine(Environment.NewLine);
            }
        }

        /// <summary>The test merge sort.</summary>
        /// <exception cref="SerializationException">An error has occurred during serialization, such as if an object in the graph parameter is not marked as serializable. </exception>
        /// <exception cref="SecurityException">The caller does not have the required permission. </exception>
        /// <exception cref="IOException">An I/O error occurred. </exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        [TestMethod]
        public void TestMergeSort()
        {
            foreach (int[] integerArray in Helpers<int>.IntegerArrays)
            {
                Console.WriteLine("New Pass");
                int[] integerArrayDeepCopy = GenericCopier<int[]>.DeepCopy(integerArray);
                NonRecursiveSorting<int>.MergeSort(integerArrayDeepCopy);
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}