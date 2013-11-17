using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NU = NUnit.Framework;
using TestFixture = NUnit.Framework.TestFixtureAttribute;
using Test = NUnit.Framework.TestAttribute;
using TestCase = NUnit.Framework.TestCaseAttribute;

namespace MSTest
{
    [TestFixture]
    [TestClass]
    public class MsTest1
    {
        [TestMethod]
        public void MsTestMethod1()
        {
            Assert.IsTrue(true);
        }


        [TestMethod]
        public void MsTestMethod2()
        {
            Assert.IsTrue(true);
        }

        
        [TestMethod]
        public void MsTestMethod3()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void NUnitTestMethod4()
        {
            NU.Assert.IsTrue(true);
        }

     


    }
}
