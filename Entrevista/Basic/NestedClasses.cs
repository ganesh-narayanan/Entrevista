using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Basic
{
    [TestClass]
    public class NestedClasses
    {
        [TestMethod]
        public void TestInnerStatic()
        {
            Outer.InnerStatic.Output();
        }

        [TestMethod]
        public void TestInnerNormal()
        {
            Outer.Inner inner = new Outer.Inner();
        }

        [TestMethod]
        public void TestInnerWithOuterInstance()
        {
            Outer outer = new Outer();
            Outer.Inner inner = new Outer.Inner(outer);
        }
    }

    public class Outer
    {
        private int a = 0;
        int b = 1;
        protected int c = 2;
        public int d = 3;
        private static int e = 4;

        public void InstanceMethod()
        {
            Console.WriteLine("Invoked the Instance method");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("Invoked the Static method");
        }

        public Outer()
        {
            Console.WriteLine("Class Outer");
            Console.WriteLine("a " + a);
            Console.WriteLine("b " + b);
            Console.WriteLine("c " + c);
            Console.WriteLine("d " + d);
            Console.WriteLine("e " + e);
            StaticMethod();
            InstanceMethod();
        }

        public static class InnerStatic
        {
            public static void Output()
            {
                Console.WriteLine("Class InnerStatic");
                Console.WriteLine("Cant access non-static fields");
                //Cant access non-static fields
                //Console.WriteLine("a " + a);
                //Console.WriteLine("b " + b);
                //Console.WriteLine("c " + c);
                //Console.WriteLine("d " + d);

                Console.WriteLine("e " + e);

                StaticMethod();

                Console.WriteLine("Cant access non-static Methods");
                // InstanceMethod();
            }
        }
        public class Inner
        {
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
            public Inner()
            {
                Console.WriteLine("Class Inner");
                Console.WriteLine("Cant access non-static fields");
                //Cant access non-static fields
                //Console.WriteLine("a " + a);
                //Console.WriteLine("b " + b);
                //Console.WriteLine("c " + c);
                //Console.WriteLine("d " + d);

                Console.WriteLine("e " + e);

                StaticMethod();
                Console.WriteLine("Cant access non-static fields");
                //InstanceMethod();
            }
        }
    }
}
