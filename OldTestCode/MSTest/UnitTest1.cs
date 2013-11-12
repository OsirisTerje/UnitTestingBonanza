using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Now = NUnit.Framework;
using TestFixture = NUnit.Framework.TestFixtureAttribute;
using Test = NUnit.Framework.TestAttribute;
using TestCase = NUnit.Framework.TestCaseAttribute;

namespace MSTest
{
    [TestFixture]
    [TestClass]
    public class MultiTest1
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

        [IntegrationTest]
        [TestCase(4,8)]
        [TestCase(2,4)]
        [Test]
        public void NUnitDataDrivenTest(int x,int expected)
        {
            int result = x*2;
            Now.Assert.That(result,Now.Is.EqualTo(expected));
        }

        [TestCase(true)]
        [TestCase(4.1)]
        [TestCase(2)]
        [Test]
        public void NUnitDataDrivenGenericTest<T>(T x) where T:struct
        {
            var container = new Container<T> {Value = x};
            Now.Assert.That(container.Value, Now.Is.EqualTo(x));
        }


        [Fact]
        public void XTestMethod1()
        {
            Xunit.Assert.True(true);
        }

    }


    public class IntegrationTest : NUnit.Framework.CategoryAttribute
    { }

    public class Container<T>
    {
        public T Value { get; set; }
    }
}
