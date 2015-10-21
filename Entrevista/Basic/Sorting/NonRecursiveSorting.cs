// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sorting.cs" company="">
//   
// </copyright>
// <summary>
//   The sorting.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GaneshNarayanan.Entrevista.Basic.Sorting
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>The sorting.</summary>
    /// <typeparam name="T">Any type of object</typeparam>
    public static class NonRecursiveSorting<T>
        where T : IEquatable<T>
    {
        /// <summary>The bubble sort.</summary>
        /// <param name="arrayToSort">The array to sort.</param>
        /// <param name="comparer">The comparer.</param>
        /// <exception cref="IOException">An I/O error occurred. </exception>
        public static void BubbleSort(T[] arrayToSort, Comparer<T> comparer = null)
        {
            Comparer<T> equalityComparer = comparer ?? Comparer<T>.Default;

            int pass = 0, swap = 0;

            Helpers<T>.WriteArray(arrayToSort);

            for (int i = 0; i < arrayToSort.Length - 1; i++)
            {
                pass++;
                Helpers<T>.WriteArray(arrayToSort);
                for (int j = 0; j < arrayToSort.Length - 1; j++)
                {
                    if (equalityComparer.Compare(arrayToSort[j], arrayToSort[j + 1]) > 0)
                    {
                        Helpers<T>.Swap(ref arrayToSort[j], ref arrayToSort[j + 1]);
                        swap++;
                    }
                }
            }

            Console.WriteLine("Pass = " + pass);
            Console.WriteLine("Swap = " + swap);
        }

        /// <summary>The insertion sort.</summary>
        /// <param name="arrayToSort">The array To Sort.</param>
        /// <param name="comparer">The comparer.</param>
        /// <exception cref="IOException">An I/O error occurred. </exception>
        public static void InsertionSort(T[] arrayToSort, Comparer<T> comparer = null)
        {
            Comparer<T> equalityComparer = comparer ?? Comparer<T>.Default;
            int pass = 0, swap = 0;
            Helpers<T>.WriteArray(arrayToSort);
            for (int i = 0; i < arrayToSort.Length - 1; i++)
            {
                pass++;
                int j = i + 1;
                while (j > 0)
                {
                    if (equalityComparer.Compare(arrayToSort[j - 1], arrayToSort[j]) > 0)
                    {
                        Helpers<T>.Swap(ref arrayToSort[j - 1], ref arrayToSort[j]);
                        swap++;
                        Helpers<T>.WriteArray(arrayToSort);
                    }

                    j--;
                }
            }

            Console.WriteLine("Pass = " + pass);
            Console.WriteLine("Swap = " + swap);
        }

        /// <summary>The merge sort.</summary>
        /// <param name="arrayToSort">The array to sort.</param>
        /// <param name="comparer">The comparer.</param>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        /// <exception cref="IOException">An I/O error occurred. </exception>
        public static void MergeSort(T[] arrayToSort, Comparer<T> comparer = null)
        {
            Comparer<T> equalityComparer = comparer ?? Comparer<T>.Default;
            for (int i = 1; i <= (arrayToSort.Length / 2) + 1; i *= 2)
            {
                for (int j = i; j < arrayToSort.Length; j += 2 * i)
                {
                    Merge(arrayToSort, j - i, j, Math.Min(j + i, arrayToSort.Length), equalityComparer);
                    Helpers<T>.WriteArray(arrayToSort);
                }
            }
        }

        /// <summary>The selection sort.</summary>
        /// <param name="arrayToSort">The array to sort.</param>
        /// <param name="comparer">The comparer.</param>
        /// <exception cref="IOException">An I/O error occurred. </exception>
        public static void SelectionSort(T[] arrayToSort, Comparer<T> comparer = null)
        {
            Comparer<T> equalityComparer = comparer ?? Comparer<T>.Default;
            int pass = 0, swap = 0;

            Helpers<T>.WriteArray(arrayToSort);
            for (int i = 0; i < arrayToSort.Length - 1; i++)
            {
                pass++;
                var positionMin = i;
                for (int j = i + 1; j < arrayToSort.Length; j++)
                {
                    if (equalityComparer.Compare(arrayToSort[j], arrayToSort[positionMin]) > 0)
                    {
                        positionMin = j;
                    }
                }

                if (positionMin != i)
                {
                    Helpers<T>.Swap(ref arrayToSort[i], ref arrayToSort[positionMin]);
                    swap++;
                }

                Helpers<T>.WriteArray(arrayToSort);
            }

            Console.WriteLine("Pass = " + pass);
            Console.WriteLine("Swap = " + swap);
        }

        /// <summary>The merge.</summary>
        /// <param name="arrayToSort">The array to sort.</param>
        /// <param name="start">The start.</param>
        /// <param name="middle">The middle.</param>
        /// <param name="end">The end.</param>
        /// <param name="comparer">The comparer.</param>
        private static void Merge(T[] arrayToSort, int start, int middle, int end, IComparer<T> comparer)
        {
            T[] merge = new T[end - start];
            int l = 0, r = 0, i = 0;
            while (l < middle - start && r < end - middle)
            {
                merge[i++] = comparer.Compare(arrayToSort[start + l], arrayToSort[middle + r]) < 0
                    ? arrayToSort[start + l++]
                    : arrayToSort[middle + r++];
            }

            while (r < end - middle)
            {
                merge[i++] = arrayToSort[middle + r++];
            }

            while (l < middle - start)
            {
                merge[i++] = arrayToSort[start + l++];
            }

            Array.Copy(merge, 0, arrayToSort, start, merge.Length);
        }
    }
}