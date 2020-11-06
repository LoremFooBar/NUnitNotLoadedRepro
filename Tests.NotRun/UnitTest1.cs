using FluentAssertions;
using Lib;

namespace Tests
{
    public class Tests
    {
        [MyTestAttr]
        public void Test1()
        {
            1.Should().Be(2);
        }
    }
}