using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTask;
using System.Reflection;
using Microsoft.Practices.Unity;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestReversed1()
        {
            var uc = new UnityContainer();
            uc.RegisterType<Reversed1>();
            var rev = uc.Resolve<Reversed1>();
            string expected = @"t.dat\ra\bla\f";
            Assert.AreEqual(expected, rev.ReversPathString(@"f\bla\ra\t.dat"), true, "Handler Reversed1 not correctly");

        }
        [TestMethod]
        public void TestReversed2()
        {
            var uc = new UnityContainer();
            uc.RegisterType<Reversed2>();
            var rev = uc.Resolve<Reversed2>();
            string expected = @"tad.t\ar\alb\f";
            Assert.AreEqual(expected, rev.ReversPathString(@"f\bla\ra\t.dat"), true, "Handler Reversed2 not correctly");

        }
    }
}
