using System;
 
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
 
    /// <summary>
    /// Add using  Assert = NUnit.Framework.AssertMs; 
    /// at top of file to avoid using AssertMs in front of these. 
    /// You might need to suppress a R# warning, add it to your team settings. 
    /// </summary>
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
 
    public class PriorityAttribute : PropertyAttribute
    {
        public PriorityAttribute(int n) : base("Priority",n)
        {
            
        }
    }
}
