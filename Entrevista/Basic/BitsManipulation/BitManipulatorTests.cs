// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BitManipulatorTests.cs" company="Ganesh-Narayanan">
//   Copyright (c) 2015 Ganesh Narayanan.  All rights reserved.
// </copyright>
// <summary>
//   The unit test 1.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GaneshNarayanan.Entrevista.Basic.BitsManipulation
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>The unit test 1.</summary>
    [TestClass]
    public class BitManipulatorTests
    {
        /// <summary>The test add numbers 14454 and 14413.</summary>
        [TestMethod]
        public void TestMinMaxCalculator14454And14413()
        {
            int response = BitManipulator.MinMaxCalculator(14454, 14413, 5, 10);
            Console.WriteLine(response);
            Assert.AreEqual(10, response);
        }

        /// <summary>The test add numbers 144 and 144.</summary>
        [TestMethod]
        public void TestMinMaxCalculator144And144()
        {
            int response = BitManipulator.MinMaxCalculator(144, 144, 5, 10);
            Console.WriteLine(response);
            Assert.AreEqual(10, response);
        }

        /// <summary>The test power of 2 for 10.</summary>
        [TestMethod]
        public void TestPowerOf2For10()
        {
            ulong response = BitManipulator.PowerOf2(10);
            Console.WriteLine(response);
            Assert.AreEqual(Math.Pow(2, 10), response);
        }
    }
}