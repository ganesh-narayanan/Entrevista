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
            // Sample x = 22, y = 44, ifXisSmaller = 150 (10010110), ifYisSmaller = 101 (1100101)

            int diff = x - y; // -22 = 22 -44

            // Now with any 32 bit number
            // if x < y i.e. x-y is negative then left shift 11111 gets you all 1's on 32 bits = 11111111111111111111111111111111
            //  else x > y you would get all 0's
            // 101100000000000000000000000000000000 = 20 >> 31
            // 101100000000000000000000000000000000 = 20 >> 31
            int bit31 = diff >> 31; 

            // return ifXisSmaller if x is smaller than y, else y
            return (bit31 & (ifXisSmaller ^ ifYisSmaller)) ^ ifYisSmaller;

            // (-101100000000000000000000000000000000 &  (11110011)) ^ 1100101
            // (0) ^ 1010
            // 1010 answer
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