using Lib;
using NUnit.Framework;

namespace Tests.DoRun
{
    public class Tests
    {
        [MyTestAttr]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}