using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GaneshNarayanan.Entrevista.Basic.NumberSystem
{
    [TestClass]
    public class NumberSystemTests
    {
        /// <summary>The test add numbers 12 and 13.</summary>
        [TestMethod]
        public void TestAddNumbers12And13()
        {
            string response = NumberSystem.AddTwoNumbers("12", "13");
            Console.WriteLine(response);
            Assert.AreEqual("25", response);
        }

        /// <summary>The test add numbers 12 and 13.</summary>
        [TestMethod]
        public void TestAddNumbersHuge()
        {
            string response = NumberSystem.AddTwoNumbers("1223423234234234234234234234", "133264564564567567567567");
            Console.WriteLine(response);
            Assert.AreEqual("25551068879879810981098109810", response);
        }

        /// <summary>The test convert to binary 0.</summary>
        [TestMethod]
        public void TestConvertToBinary0()
        {
            string response = NumberSystem.ConvertToBinary(0);
            Console.WriteLine(response);
            Assert.AreEqual("0", response);
        }

        /// <summary>The test convert to binary 783.</summary>
        [TestMethod]
        public void TestConvertToBinary783()
        {
            string response = NumberSystem.ConvertToBinary(783);
            Console.WriteLine(response);
            Assert.AreEqual("1100001111", response);
        }

        /// <summary>The test convert to binary 783.</summary>
        [TestMethod]
        public void TestConvertToBinary9223372036854775807()
        {
            string response = NumberSystem.ConvertToBinary(9223372036854775807);
            Console.WriteLine(response);
            Assert.AreEqual("111111111111111111111111111111111111111111111111111111111111111", response);
        }

        /// <summary>The test convert to decimal 4294967295.</summary>
        [TestMethod]
        public void TestConvertToDecimal4294967295()
        {
            string response = NumberSystem.ConvertToDecimal("11111111111111111111111111111111");
            Console.WriteLine(response);
            Assert.AreEqual("4294967295", response);
        }

        /// <summary>The test convert to decimal 783.</summary>
        [TestMethod]
        public void TestConvertToDecimal783()
        {
            string response = NumberSystem.ConvertToDecimal("1100001111");
            Console.WriteLine(response);
            Assert.AreEqual("783", response);
        }

        /// <summary>The test convert to decimal 4294967295.</summary>
        [TestMethod]
        public void TestConvertToDecimalHuge()
        {
            string response =
                NumberSystem.ConvertToDecimal("111111111111111111111111111111111111111111111111111111111111111");
            Console.WriteLine(response);
            Assert.AreEqual("9223372036854775807", response);
        }

    }
}
