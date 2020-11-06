using FluentAssertions;
using Lib;

namespace Tests.DoRun
{
    public class UnitTest2
    {
        [MyTestAttr]
        public void Test()
        {
            1.Should().Be(2);
        }
    }
}