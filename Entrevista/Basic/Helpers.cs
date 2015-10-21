// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Helpers.cs" company="">
//   
// </copyright>
// <summary>
//   The helpers.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GaneshNarayanan.Entrevista.Basic
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    /// <summary>The helpers.</summary>
    /// <typeparam name="T">Any type of Object</typeparam>
    public static class Helpers<T>
    {
        /// <summary>Initializes static members of the <see cref="Helpers"/> class.</summary>
        static Helpers()
        {
            IntegerArrays = new List<T[]>();
            for (int i = 0; i < 10; i++)
            {
                IntegerArrays.Add(GenerateArrays(i, i * 101, i * 2563));
            }
        }

        /// <summary>Gets or sets the integer arrays.</summary>
        public static List<T[]> IntegerArrays { get; set; }

        /// <summary>The generate arrays.</summary>
        /// <param name="count">The count.</param>
        /// <param name="min">The min.</param>
        /// <param name="max">The max.</param>
        /// <returns>The <see cref="T[]"/>.</returns>
        public static T[] GenerateArrays(int count = 5, int min = 0, int max = int.MaxValue)
        {
            Random randNum = new Random();
            int[] arrayOfInts = Enumerable.Repeat(default(T), count).Select(i => randNum.Next(min, max)).ToArray();
            return arrayOfInts as T[];
        }

        /// <summary>The swap.</summary>
        /// <param name="a">The a.</param>
        /// <param name="b">The b.</param>
        public static void Swap(ref T a, ref T b)
        {
            T t = b;
            b = a;
            a = t;
        }

        /// <summary>The write array.</summary>
        /// <param name="arrayToWrite">The array to write.</param>
        /// <exception cref="IOException">An I/O error occurred. </exception>
        public static void WriteArray(T[] arrayToWrite)
        {
            foreach (T i in arrayToWrite)
            {
                Console.Write(i + "->");
            }

            Console.WriteLine(Environment.NewLine);
        }
    }
}