// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Threading.cs" company="Ganesh-Narayanan">
//   Copyright (c) 2015 Ganesh Narayanan.  All rights reserved.
// </copyright>
// <summary>
//   The threading.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GaneshNarayanan.Entrevista.Basic.OOPS
{
    using System;
    using System.Threading;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>The threading.</summary>
    [TestClass]
    public class Threading
    {
        /// <summary>The test thread exceute.</summary>
        [TestMethod]
        public void TestThreadExceute()
        {
            Thread thread = new Thread(this.WriteY);
            thread.Start();

            // Simultaneously, do something on the main thread.
            for (int i = 0; i < 100000; i++)
            {
                Console.Write("x");
            }
        }

        /// <summary>The write y.</summary>
        private void WriteY()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.Write("y");
            }
        }
    }
}