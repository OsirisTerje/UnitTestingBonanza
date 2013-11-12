using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

//using TestInitialize = NUnit.Framework.SetUpAttribute;
//using TestContext = System.Object;
//using TestProperty = NUnit.Framework.PropertyAttribute;
//using TestClass = NUnit.Framework.TestFixtureAttribute;
//using TestMethod = NUnit.Framework.TestAttribute;
//using TestCleanup = NUnit.Framework.TearDownAttribute;

namespace OldTestCode
{
    [TestClass]
    public class SomeOldTest2
    {


        [TestInitialize]
        public void StartItUp()
        { }

        [TestCleanup]
        public void EndItAll()
        { }

        [TestMethod]
        public void MSTestit1()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void MSTestit2()
        {
            Assert.AreEqual(true,true);
            var x = new Whatever();
            Assert.AreSame(x,x);
            var now = DateTime.Now;
            AssertMs.IsInstanceOfType(now,typeof(DateTime));
            Assert.IsNull(null);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void MSTestit3()
        {
           throw new Exception();
        }

        [Priority(1)]
        [TestProperty("Whatever","Something")]
        [TestCategory("LongRunningTest")]
        [TestMethod]
        public void MSTestit499()
        {
            Assert.IsTrue(true);
        }

    }
}
