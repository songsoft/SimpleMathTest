using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SimpleMath;

namespace SimpleMath.Tests
{
    static class Extensions
    {
        public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }
    }

    [TestClass]
    public class CollectionTests
    {
        private DateTime startTime;
        List<string> StringList;

        public static void Main()
        {

            Console.WriteLine("Bye!");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            startTime = DateTime.Now;
            StringList = new List<string>() { "ABC", "123", "XYZ" };
        }

        [TestMethod]
        public void Test_Collection()
        {
            StringList.Add("!@#");
            StringList.Add("123");

            CollectionAssert.AllItemsAreInstancesOfType(StringList, typeof(string));
            CollectionAssert.AllItemsAreNotNull(StringList);
        }

        [TestMethod]
        public void Test_Collection_Clone()
        {
            // List<string> StringList2 = StringList.Clone(string);
            List<string> StringList2 = new List<string>(StringList);

            CollectionAssert.AreEqual(StringList, StringList2);
            CollectionAssert.AreEquivalent(StringList, StringList2);

            StringList2.Add("234");
            CollectionAssert.AreNotEqual(StringList, StringList2);
            CollectionAssert.AreNotEquivalent(StringList, StringList2);

            CollectionAssert.IsSubsetOf(StringList, StringList2);
            CollectionAssert.DoesNotContain(StringList, "YES");

            CollectionAssert.AllItemsAreUnique(StringList);

            StringList2.Add("123");
            CollectionAssert.AllItemsAreUnique(StringList2);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            TimeSpan span = DateTime.Now - startTime;
            Console.WriteLine("Time Span: {0} seconds, {1} Milliseconds", span.Seconds, span.Milliseconds);
        }
    }
}
