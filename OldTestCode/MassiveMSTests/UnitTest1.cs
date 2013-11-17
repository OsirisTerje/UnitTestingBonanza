using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using  Assert = NUnit.Framework.AssertMs;

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

        [TestMethod]
        public void MSTestit799()
        {
            var d = DateTime.Now;
            Assert.IsInstanceOfType(d,typeof(DateTime));
        }
    }


  

}

//namespace NUnit.Framework
//{
//    public class TestClassAttribute : NUnit.Framework.TestFixtureAttribute
//    {
//    }

//    public class TestMethodAttribute : NUnit.Framework.TestAttribute
//    { }

//    //See https://xunit.codeplex.com/wikipage?title=Comparisons&referringTitle=Home for comparisons
//}
