using System;
using Xunit;

namespace Task_1.Test
{
    public class Person
    {
        [Fact]
        public void GetHashCode_3_returns_3()
        {
            int x = 3;
            int expected = 3;

            var person = new Person();
            int actual = x.GetHashCode(); ;

            Assert.Equal(expected, actual);
        }
    }
}
