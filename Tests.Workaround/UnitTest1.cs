using FluentAssertions;
using Lib;
using NUnit.Framework;

namespace Tests.Workaround
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