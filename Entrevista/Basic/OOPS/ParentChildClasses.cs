// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ParentChildClasses.cs" company="Ganesh-Narayanan">
//   Copyright (c) 2015 Ganesh Narayanan.  All rights reserved.
// </copyright>
// <summary>
//   The parent child classes.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GaneshNarayanan.Entrevista.Basic.OOPS
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>The parent child classes.</summary>
    [TestClass]
    public class ParentChildClasses
    {
        /// <summary>The check field and method access.</summary>
        [TestMethod]
        public void CheckFieldAndMethodAccess()
        {
            Child child = new Child();
            child.InvokeChild();
        }

        /// <summary>The constructor invocation order.</summary>
        [TestMethod]
        public void ConstructorInvocationOrder()
        {
            Child child = new Child();
        }
    }

    /// <summary>The parent.</summary>
    public class Parent
    {
        /// <summary>The f.</summary>
        protected static int f = 5;

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

        /// <summary>Initializes a new instance of the <see cref="Parent"/> class.</summary>
        public Parent()
        {
            Console.WriteLine("Invoked Parent");
        }

        /// <summary>The static method.</summary>
        public static void StaticMethod()
        {
            Console.WriteLine("Invoked the Static method");
        }

        /// <summary>The invoke parent.</summary>
        public void InvokeParent()
        {
            Console.WriteLine("Class Parent");
            Console.WriteLine("a " + this.a);
            Console.WriteLine("b " + this.b);
            Console.WriteLine("c " + this.c);
            Console.WriteLine("d " + this.d);
            Console.WriteLine("e " + e);
            Console.WriteLine("f " + f);

            StaticMethod();
            this.PublicInstanceMethod();
            this.ProtectedInstanceMethod();
            this.PrivateInstanceMethod();
        }

        /// <summary>The public instance method.</summary>
        public void PublicInstanceMethod()
        {
            Console.WriteLine("Invoked the public Instance method");
        }

        /// <summary>The protected instance method.</summary>
        protected void ProtectedInstanceMethod()
        {
            Console.WriteLine("Invoked the protected Instance method");
        }

        /// <summary>The private instance method.</summary>
        private void PrivateInstanceMethod()
        {
            Console.WriteLine("Invoked the protected Instance method");
        }
    }

    /// <summary>The child.</summary>
    public class Child : Parent
    {
        /// <summary>Initializes a new instance of the <see cref="Child"/> class.</summary>
        public Child()
        {
            Console.WriteLine("Invoked Child");
        }

        /// <summary>The invoke child.</summary>
        public void InvokeChild()
        {
            Console.WriteLine("Class Child");

            Console.WriteLine("Cant access private fields");

            // Console.WriteLine("a " + a);
            // Console.WriteLine("b " + b);
            // Console.WriteLine("e " + e);
            Console.WriteLine("c " + this.c);
            Console.WriteLine("d " + this.d);
            Console.WriteLine("f " + f);
            StaticMethod();
            this.PublicInstanceMethod();
            this.ProtectedInstanceMethod();

            Console.WriteLine("Cant access private Methods");

            // PrivateInstanceMethod();
        }
    }
}