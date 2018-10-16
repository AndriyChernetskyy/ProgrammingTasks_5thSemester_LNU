using System;
using Xunit;

namespace Task_1.Test
{
    public class PersonTest
    {
        [Fact]
        public void GetHashCode_3_returns_3()
        {
            int x = 3;
            int expected = 3;

            var student = new Student();
            int actual = x.GetHashCode(); ;

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Clone_Age_20_returns_Age_20()
        {
            int expected = 20;

            Person student = new Student();
            student.Age = 20;

            Person person = (Person)student.Clone();

            int actual = person.Age;

            Assert.Equal(expected, actual);
        }
    }
}
