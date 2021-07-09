using ChallengesWithTestsMark8;
using NUnit.Framework;

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
    }
}