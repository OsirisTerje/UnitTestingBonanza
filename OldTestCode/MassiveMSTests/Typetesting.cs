using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assert = NUnit.Framework.AssertMs;


namespace MassiveTests2
{

    public class AnotherHugeMSTestClassWithSomeInstanceTests
    {

        [TestMethod]
        public void MSTestit799()
        {
            var d = DateTime.Now;
            Assert.IsInstanceOfType(d, typeof(DateTime));
        }


        [TestMethod]
        public void MSTestit899()
        {
            Assert.IsTrue(true);
        }
    }

}

