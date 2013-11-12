using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace OldTestCode
{
    [TestClass]
    public class SomeOldTest
    {
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
            Assert.IsInstanceOf();
            Assert.IsNull(null);
            

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
}
