using System.Collections.Generic;

namespace GaneshNarayanan.Entrevista.Basic.Sorting
{
    public abstract class AbstractSort<T>
    {
        public abstract void SelectionSort(T[] arrayToSort, Comparer<T> comparer = null);

        /// <summary>The swap.</summary>
        /// <param name="a">The a.</param>
        /// <param name="b">The b.</param>
        public static void Swap(ref T a, ref T b)
        {
            var t = b;
            b = a;
            a = t;
        }
    }
}