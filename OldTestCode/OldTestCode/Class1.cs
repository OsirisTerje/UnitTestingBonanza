using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OldTestCode
{
    [TestClass]
    public class SomeOldTest
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
            Assert.IsInstanceOfType(now,typeof(DateTime));
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
