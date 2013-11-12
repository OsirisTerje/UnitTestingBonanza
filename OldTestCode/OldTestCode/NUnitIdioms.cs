﻿using System;
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

    public class TestInitializeAttribute : SetUpAttribute
    { }

    public class TestCleanupAttribute : TearDownAttribute
    { }

    public class AssertMs : Assert
    {
        public static void IsInstanceOfType(object actual, Type expected)
        {
            Assert.IsInstanceOf(expected,actual);
        }
    }

    public class TestCategory : CategoryAttribute
    {
        public TestCategory(string category) : base(category)
        {
            
        }
    }

    public class TestPropertyAttribute : PropertyAttribute
    {
        public TestPropertyAttribute(string prop, string value) : base(prop,value)
        {
            
        }
    }
}
