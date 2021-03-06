﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleMath.Tests
{
    /// <summary>
    /// Summary description for UnitTest0
    /// </summary>
    [TestClass]
    public class TestContextTests
    {
        public TestContextTests()
        {
            //
            // TODO: Add constructor logic here
            //
            if (testContextInstance != null)    // not set at this point
            {
                Console.WriteLine("ctor() TestContext.TestDir {0}", TestContext.TestDir);
            }
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            //
            // TODO: Add test logic here
            //
            if (testContextInstance != null)
            {
                Console.WriteLine("TestMethod1 TestContext");
                Console.WriteLine("\t TestDir {0}", TestContext.TestDir);
                Console.WriteLine("\t TestName {0}", TestContext.TestName);
                Console.WriteLine("\t DeploymentDirectory {0}", TestContext.DeploymentDirectory);
            }
        }
    }
}
