// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BitManipulator.cs" company="Ganesh-Narayanan">
//   Copyright (c) 2015 Ganesh Narayanan.  All rights reserved.
// </copyright>
// <summary>
//   The bit manipulator.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GaneshNarayanan.Entrevista.Basic.BitsManipulation
{
    /// <summary>The bit manipulator.</summary>
    public static class BitManipulator
    {
        /// <summary>The min max calculator.</summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="ifXisSmaller">The if x is smaller.</param>
        /// <param name="ifYisSmaller">The if y is smaller.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public static int MinMaxCalculator(int x, int y, int ifXisSmaller, int ifYisSmaller)
        {
            int diff = x - y;

            // sets bit31 to 0xFFFFFFFF if x<y, else 0x00000000
            int bit31 = diff >> 31;

            // return ifXisSmaller if x is smaller than y, else y
            return (bit31 & (ifXisSmaller ^ ifYisSmaller)) ^ ifYisSmaller;
        }

        /// <summary>The power of 2.</summary>
        /// <param name="power">The power.</param>
        /// <returns>The <see cref="ulong"/>.</returns>
        public static ulong PowerOf2(int power)
        {
            return (ulong)1 << power;
        }
    }
}