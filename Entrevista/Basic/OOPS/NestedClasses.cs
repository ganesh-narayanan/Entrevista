// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NestedClasses.cs" company="Ganesh-Narayanan">
//   Copyright (c) 2015 Ganesh Narayanan.  All rights reserved.
// </copyright>
// <summary>
//   The nested classes.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GaneshNarayanan.Entrevista.Basic.OOPS
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>The nested classes.</summary>
    [TestClass]
    public class NestedClasses
    {
        /// <summary>The test inner normal.</summary>
        [TestMethod]
        public void TestInnerNormal()
        {
            Outer.Inner inner = new Outer.Inner();
        }

        /// <summary>The test inner static.</summary>
        [TestMethod]
        public void TestInnerStatic()
        {
            Outer.InnerStatic.Output();
        }

        /// <summary>The test inner with outer instance.</summary>
        [TestMethod]
        public void TestInnerWithOuterInstance()
        {
            Outer outer = new Outer();
            Outer.Inner inner = new Outer.Inner(outer);
        }
    }

    /// <summary>The outer.</summary>
    public class Outer
    {
        /// <summary>The e.</summary>
        private static int e = 4;

        /// <summary>The d.</summary>
        public int d = 3;

        /// <summary>The c.</summary>
        protected int c = 2;

        /// <summary>The a.</summary>
        private int a = 0;

        /// <summary>The b.</summary>
        private int b = 1;

        /// <summary>Initializes a new instance of the <see cref="Outer"/> class.</summary>
        public Outer()
        {
            Console.WriteLine("Class Outer");
            Console.WriteLine("a " + this.a);
            Console.WriteLine("b " + this.b);
            Console.WriteLine("c " + this.c);
            Console.WriteLine("d " + this.d);
            Console.WriteLine("e " + e);
            StaticMethod();
            this.InstanceMethod();
        }

        /// <summary>The static method.</summary>
        public static void StaticMethod()
        {
            Console.WriteLine("Invoked the Static method");
        }

        /// <summary>The instance method.</summary>
        public void InstanceMethod()
        {
            Console.WriteLine("Invoked the Instance method");
        }

        /// <summary>The inner static.</summary>
        public static class InnerStatic
        {
            /// <summary>The output.</summary>
            public static void Output()
            {
                Console.WriteLine("Class InnerStatic");
                Console.WriteLine("Cant access non-static fields");

                // Cant access non-static fields
                // Console.WriteLine("a " + a);
                // Console.WriteLine("b " + b);
                // Console.WriteLine("c " + c);
                // Console.WriteLine("d " + d);
                Console.WriteLine("e " + e);

                StaticMethod();

                Console.WriteLine("Cant access non-static Methods");

                // InstanceMethod();
            }
        }

        /// <summary>The inner.</summary>
        public class Inner
        {
            /// <summary>Initializes a new instance of the <see cref="Inner"/> class.</summary>
            /// <param name="outer">The outer.</param>
            public Inner(Outer outer)
            {
                Console.WriteLine("Class Inner");
                Console.WriteLine("Can access non-static fields by using Instance object");
                Console.WriteLine("a " + outer.a);
                Console.WriteLine("b " + outer.b);
                Console.WriteLine("c " + outer.c);
                Console.WriteLine("d " + outer.d);
                Console.WriteLine("e " + e);

                StaticMethod();
                Console.WriteLine("Can access non-static fields by using Instance object");
                outer.InstanceMethod();
            }

            /// <summary>Initializes a new instance of the <see cref="Inner"/> class.</summary>
            public Inner()
            {
                Console.WriteLine("Class Inner");
                Console.WriteLine("Cant access non-static fields");

                // Cant access non-static fields
                // Console.WriteLine("a " + a);
                // Console.WriteLine("b " + b);
                // Console.WriteLine("c " + c);
                // Console.WriteLine("d " + d);
                Console.WriteLine("e " + e);

                StaticMethod();
                Console.WriteLine("Cant access non-static fields");

                // InstanceMethod();
            }
        }
    }
}