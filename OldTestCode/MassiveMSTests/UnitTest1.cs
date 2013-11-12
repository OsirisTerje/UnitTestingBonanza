using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace MassiveMSTests
{
    [TestClass]
    public class HugeMSTestClass
    {
        [TestMethod]
        public void MSTestit1()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void MSTestit2()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void MSTestit3()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void MSTestit499()
        {
            Assert.IsTrue(true);
        }
    }


    public class TestClassAttribute : NUnit.Framework.TestFixtureAttribute
    {
    }

    public class TestMethodAttribute : NUnit.Framework.TestAttribute
    { }


}
