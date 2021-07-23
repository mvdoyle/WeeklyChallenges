using ChallengesWithTestsMark8;
using NUnit.Framework;
using System;

namespace N_UnitDemo
{
    [TestFixture]
    public class Tests
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
            //var actual = _set01.Subtract
            throw new NotImplementedException();
        }
    }
}