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
        /// <summary>
        /// Adding in a simple NUnit Test method in the same class that are used for MSTest
        /// The class itself must have both MSTest and NUNit attributes
        /// The Assert statement is ambigious, so we prefix the NUnit ones.
        /// </summary>
        [Test]
        public void NUnitTestMethod4()
        {
            NU.Assert.IsTrue(true);
        }

     


    }
}
