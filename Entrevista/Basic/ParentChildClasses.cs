using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Basic
{
    [TestClass]
    public class ParentChildClasses
    {
        [TestMethod]
        public void ConstructorInvocationOrder()
        {
            Child child =  new Child();
        }

        [TestMethod]
        public void CheckFieldAndMethodAccess()
        {
            Child child = new Child();
            child.InvokeChild();
        }
    }
        
    public class Parent
    {
        private int a = 0;
        private int b = 1;
        protected int c = 2;
        public int d = 3;
        private static int e = 4;
        protected static int f = 5;

        public Parent()
        {
            Console.WriteLine("Invoked Parent");
        }


        public void PublicInstanceMethod()
        {
            Console.WriteLine("Invoked the public Instance method");
        }

        protected void ProtectedInstanceMethod()
        {
            Console.WriteLine("Invoked the protected Instance method");
        }

        private void PrivateInstanceMethod()
        {
            Console.WriteLine("Invoked the protected Instance method");
        }
        public static void StaticMethod()
        {
            Console.WriteLine("Invoked the Static method");
        }

        public void InvokeParent()
        {
            Console.WriteLine("Class Parent");
            Console.WriteLine("a " + a);
            Console.WriteLine("b " + b);
            Console.WriteLine("c " + c);
            Console.WriteLine("d " + d);
            Console.WriteLine("e " + e);
            Console.WriteLine("f " + f);

            StaticMethod();
            PublicInstanceMethod();
            ProtectedInstanceMethod();
            PrivateInstanceMethod();
        }
    }

    public class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("Invoked Child");
        }

        public void InvokeChild()
        {
            Console.WriteLine("Class Child");

            Console.WriteLine("Cant access private fields");
            //Console.WriteLine("a " + a);
            //Console.WriteLine("b " + b);
            //Console.WriteLine("e " + e);

            Console.WriteLine("c " + c);
            Console.WriteLine("d " + d);
            Console.WriteLine("f " + f);
            StaticMethod();
            PublicInstanceMethod();
            ProtectedInstanceMethod();

            Console.WriteLine("Cant access private Methods");
            //PrivateInstanceMethod();
        }

    }

}
