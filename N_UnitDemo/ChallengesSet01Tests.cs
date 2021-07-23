using ChallengesWithTestsMark8;
using NUnit.Framework;
using System;

namespace N_UnitDemo
{
    [TestFixture]
    public class ChallengesSet01Tests
    {
        private ChallengesSet01 _set01;

        [SetUp]
        public void Setup()
        {
            _set01 = new ChallengesSet01();
        }

        [TestCase(1, 1, true)]
        [TestCase(10, 10, true)]
        [TestCase(99, 99, true)]
        [TestCase(-10, -10, true)]
        [TestCase(-1, -1, true)]
        [TestCase(0, 1, false)]
        [TestCase(4, 7, false)]
        [TestCase(-1, 1, false)]
        [TestCase(5, 6, false)]
        public void Test1(int a, int b, bool expected)
        {
            var actual = _set01.AreTwoNumbersTheSame(a, b);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(10, 7, 3)]
        [TestCase(100, 75, 25)]
        [TestCase(1, 1, 0)]
        [TestCase(10, 15, -5)]
        [TestCase(0, 7, -7)]
        [TestCase(0, 0, 0)]
        [TestCase(-5, 5, -10)]
        [TestCase(-10, -7, -3)]
        [TestCase(-10, -15, 5)]
        [TestCase(5.5, 1.2, 4.3)]
        [TestCase(0.7, 0.35, 0.35)]
        [TestCase(-2.2, 1.1, -3.3)]
        public void Subtract(double minuend, double subtrahend, double expectedDifference)
        {
            var actual = _set01.Subtract(minuend, subtrahend);
            Assert.AreEqual(expectedDifference, actual);
        }

        [TestCase(10, 7, 17)]
        [TestCase(100, 75, 175)]
        [TestCase(1, 1, 2)]
        [TestCase(10, 15, 25)]
        [TestCase(0, 7, 7)]
        [TestCase(0, 0, 0)]
        [TestCase(-5, 5, 0)]
        [TestCase(-10, -7, -17)]
        [TestCase(-10, -15, -25)]
        public void Add(int addend1, int addend2, int expectedSum)
        {
            var actual = _set01.Add(addend1, addend2);
            Assert.AreEqual(expectedSum, actual);
        }

        [TestCase(10, 7, 7)]
        [TestCase(100, 75, 75)]
        [TestCase(1, 1, 1)]
        [TestCase(10, 15, 10)]
        [TestCase(0, 7, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(-5, 5, -5)]
        [TestCase(-10, -7, -10)]
        [TestCase(-10, -15, -15)]
        public void GetSmallestNumber(int number1, int number2, int expected)
        {
            var actual = _set01.GetSmallestNumber(number1, number2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 7, 70)]
        [TestCase(100, 75, 7500)]
        [TestCase(1, 1, 1)]
        [TestCase(10, 15, 150)]
        [TestCase(0, 7, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(-5, 5, -25)]
        [TestCase(-10, -7, 70)]
        [TestCase(-10, -15, 150)]
        [TestCase(1234567, 7654321, 9449772114007)]
        [TestCase(1234567, -7654321, -9449772114007)]
        public void Multiply(long factor1, long factor2, long product)
        {
            var actual = _set01.Multiply(factor1, factor2);
            Assert.AreEqual(product, actual);
        }

        [TestCase("John", "Hello, John!")]
        [TestCase("Leigh", "Hello, Leigh!")]
        [TestCase("John Thomas", "Hello, John Thomas!")]
        [TestCase("Leigh Ann", "Hello, Leigh Ann!")]
        [TestCase("", "Hello!")]
        // [InlineData(null, "Hello!")] // Assumption: string will not be null
        public void GetGreeting(string personName, string expectedGreeting)
        {
            var actual = _set01.GetGreeting(personName);
            Assert.AreEqual(expectedGreeting, actual);
        }

        [Test]
        public void GetHey()
        {
            var actual = _set01.GetHey();
            Assert.AreEqual("HEY!", actual);
        }

    }
}