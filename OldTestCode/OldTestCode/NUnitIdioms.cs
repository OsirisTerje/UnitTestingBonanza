using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Framework
{
    public class TestClassAttribute : TestFixtureAttribute
    { }

    public class TestMethodAttribute: TestAttribute
    { }

    public class AssertMS
    {
        public static bool IsInstanceOfType(object actual, typeof expected)
        {
            
        }
    }
}
