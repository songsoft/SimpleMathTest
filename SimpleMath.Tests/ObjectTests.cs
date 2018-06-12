using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SimpleMath;

namespace SimpleMath.Tests
{
    [TestClass]
    public class ObjectTests
    {
        private DateTime startTime;

        public static void Main()
        {
            MathTests test = new MathTests();
            test.Test_Fibonacci();
            Console.WriteLine("Bye!");
        }

        //[AssemblyInitialize]
        //public static void AssemblyInitialize()
        //{
        //    Console.WriteLine("AssemblyInitialize...");
        //}

        //[AssemblyCleanup]
        //public static void AssemblyCleanup()
        //{
        //    Console.WriteLine("AssemblyCleanup");
        //}

        [TestInitialize]
        public void TestInitialize()
        {
            startTime = DateTime.Now;
        }

        [TestMethod]
        public void Test_AreSame()
        {
            List<object> listObject = new List<object>();
            object objOriginal = new object();
            listObject.Add(objOriginal);

            object objOriginal2 = new object();

            listObject.Add(objOriginal2);

            object actual = listObject[1];


            Assert.AreSame(objOriginal, actual, "{0} {1}", objOriginal.GetHashCode(), actual.GetHashCode());
        }

        [TestMethod]
        public void Test_IsInstanceOf()
        {
            List<object> listObject = new List<object>();
            object objOriginal = new object();
            listObject.Add(objOriginal);

            object actual = listObject[0];


            Assert.IsInstanceOfType(objOriginal, typeof(object), "{0} {1}", objOriginal.GetHashCode(), actual.GetHashCode());
        }


        [TestCleanup]
        public void TestCleanup()
        {
            TimeSpan span = DateTime.Now - startTime;
            Console.WriteLine("Time Span: {0} seconds, {1} Milliseconds", span.Seconds, span.Milliseconds);
        }
    }
}
