using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SimpleMath;

namespace SimpleMath.Tests
{
    [TestClass]
    public class MathTests
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
        public void Test_Fibonacci()
        {
            const int FACTOR = 8;
            const int EXPECTED = 22;    // 21

            int actual = MathFunctions.Fibonacci(FACTOR);

            Assert.AreEqual(EXPECTED, actual, "Expected {0}, Actual {1}", EXPECTED, actual);   
        }

        [TestCleanup]
        public void TestCleanup()
        {
            TimeSpan span = DateTime.Now - startTime;
            Console.WriteLine("Time Span: {0} seconds, {1} Milliseconds", span.Seconds, span.Milliseconds);
        }
    }
}
