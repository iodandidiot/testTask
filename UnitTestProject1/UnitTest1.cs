using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTask;
using System.Reflection;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestReversed1()
        {
            string expected = @"t.dat\ra\bla\f";
            Reversed1 revers = new Reversed1();
            string actual = revers.ReversPathString(@"f\bla\ra\t.dat");
            Assert.AreEqual(expected, actual, true, "Handler Reversed1 not correctly");

        }
        [TestMethod]
        public void TestReversed2()
        {
            string expected = @"tad.t\ar\alb\f";
            Reversed2 revers = new Reversed2();
            string actual = revers.ReversPathString(@"f\bla\ra\t.dat");
            Assert.AreEqual(expected, actual, true, "Handler Reversed2 not correctly");

        }
    }
}
