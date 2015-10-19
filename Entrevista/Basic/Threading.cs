using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Basic
{
    [TestClass]
    public class Threading
    {
        [TestMethod]
        public void TestThreadExceute()
        {
            Thread thread = new Thread(WriteY);
            thread.Start();

            // Simultaneously, do something on the main thread.
            for (int i = 0; i < 100000; i++) Console.Write("x");

        }

        void WriteY()
        {
            for (int i = 0; i < 10000; i++) Console.Write("y");
        }

    }
}
