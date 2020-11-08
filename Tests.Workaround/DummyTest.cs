using Lib;
using NUnit.Framework;

namespace Tests.Workaround
{
    public class DummyTest
    {
        [MyTestAttr]
        public void Dummy()
        {
            Assert.Pass();
        }
    }
}