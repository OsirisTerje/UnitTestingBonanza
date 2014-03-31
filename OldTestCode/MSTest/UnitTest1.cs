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

        [Test]
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

        [TestCase(4,8)]
        [TestCase(2,4)]
        [Test]
        public void NUnitDataDrivenTest(int somedata,int theResult)
        {
            int res = somedata*2;
            NU.Assert.That(res,NU.Is.EqualTo(theResult));
        }


    }
}
