using ChallengesWithTestsMark8;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace N_UnitDemo
{
    [TestFixture]
    public class ChallengesSet04Tests
    {
        private ChallengesSet04 _set04;

        [SetUp]
        public void Setup()
        {
            _set04 = new ChallengesSet04();
        }

        [TestCase(new int[] { 2, 6, 8, 3, 1, 3 }, 9)]
        [TestCase(new int[] { 4, 6, 10 }, 20)]
        [TestCase(new int[] { 3, 1, 3 }, -7)]
        [TestCase(new int[] { 2, 3 }, -1)]
        [TestCase(new int[] { 0, 0 }, 0)]
        [TestCase(new int[] { }, 0)]
        // [InlineData(null, 0)] // Assumption: array will not be null
        public void AddEvenSubtractOdd(int[] numbers, int expected)
        {
            var actual = _set04.AddEvenSubtractOdd(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("a", "aa", "aaa", "aaaa", 1)]
        [TestCase("aa", "a", "aaa", "aaaa", 1)]
        [TestCase("aa", "aaa", "a", "aaaa", 1)]
        [TestCase("aa", "aaa", "aaaa", "a", 1)]
        [TestCase("aa", "aa", "aaa", "aaaa", 2)]
        [TestCase("aaa", "aaa", "aaa", "aaaa", 3)]
        [TestCase("aaaa", "aaaa", "aaaa", "aaaa", 4)]
        [TestCase("", "aa", "aaa", "aaaa", 0)]
        [TestCase("aa", "aa", "", "aaaa", 0)]
        [TestCase("aaaaaaaaa", "a        a", "aaaaaaaa", "aaaaaaaaaaaaaaaaaaaaaaaaa", 8)]
        public void GetLengthOfShortestString(string string1, string string2, string string3, string string4, int expected)
        {
            var actual = _set04.GetLengthOfShortestString(string1, string2, string3, string4);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1, 2, 3, 4, 1)]
        [TestCase(2, 2, 3, 4, 2)]
        [TestCase(4, 5, 3, -1, -1)]
        [TestCase(5, 2, -3, 4, -3)]
        [TestCase(8, 0, 3, 4, 0)]
        [TestCase(7, 5, 3, 4, 3)]
        public void GetSmallestNumber(int num1, int num2, int num3, int num4, int expected)
        {
            var actual = _set04.GetSmallestNumber(num1, num2, num3, num4);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("true coders")]
        [TestCase("truecoders")]
        [TestCase("TRUECODERS")]
        [TestCase("tRUEcODERS")]
        [TestCase("test")]
        [TestCase("")]
        [TestCase(null)]
        public void ChangeBusinessNameTo_TrueCoders(string originalBusinessName)
        {
            // Arrange 
            Business business = new Business() { Name = originalBusinessName };

            // Act
            _set04.ChangeBusinessNameTo_TrueCoders(business);

            // Assert
            Assert.AreEqual("TrueCoders", business.Name);
        }

        [TestCase(2, 2, 2, true)]
        [TestCase(2, 3, 2, true)]
        [TestCase(3, 4, 5, true)]
        [TestCase(16, 10, 7, true)]
        [TestCase(30, 15, 20, true)]
        [TestCase(50, 30, 40, true)]
        [TestCase(100, 99, 2, true)]
        [TestCase(1000, 1, 1000, true)]
        [TestCase(100, 1, 99, false)]
        [TestCase(1, 19, 20, false)]
        [TestCase(85, 84, 1, false)]
        [TestCase(300, 400, 800, false)]
        [TestCase(2, 2, 0, false)]
        [TestCase(2, 0, 2, false)]
        [TestCase(0, 2, 2, false)]
        [TestCase(0, 0, 0, false)]
        [TestCase(-2, -2, -2, false)]
        [TestCase(-2, 2, 2, false)]
        [TestCase(10, 20, 50, false)]
        public void CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3, bool expected)
        {
            var actual = _set04.CouldFormTriangle(sideLength1, sideLength2, sideLength3);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("0", true)]
        [TestCase("123", true)]
        [TestCase("123.45", true)]
        [TestCase("-543", true)]
        [TestCase("-987.65", true)]
        [TestCase("abc", false)]
        [TestCase("77a", false)]
        [TestCase("a55", false)]
        [TestCase("22*", false)]
        [TestCase("4#", false)]
        [TestCase("", false)]
        [TestCase(null, false)]
        public void IsStringANumber(string word, bool expected)
        {
            var actual = _set04.IsStringANumber(word);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new string[] { "test", null, "test" }, false)]
        [TestCase(new string[] { "test", null, "test", null }, false)]
        [TestCase(new string[] { null, "test" }, false)]
        [TestCase(new string[] { null, "test", "test" }, false)]
        [TestCase(new string[] { "test", "test", "test" }, false)]
        [TestCase(new string[] { "test", "test", null }, false)]
        [TestCase(new object[] { 1, null, 7, "test" }, false)]
        [TestCase(new object[] { 1, null, '7', "test" }, false)]
        [TestCase(new object[] { 1, null, 'a', false, "test" }, false)]
        [TestCase(new object[] { null, "test", "test" }, false)]
        [TestCase(new object[] { null, "test", "test", null, "test" }, false)]
        [TestCase(new string[] { null, "test", "test", null, null }, true)]
        [TestCase(new string[] { null, null, "test", null, "test" }, true)]
        [TestCase(new string[] { null, "test", null, "test", null }, true)]
        [TestCase(new object[] { 1, null, null }, true)]
        [TestCase(new object[] { null, null, null }, true)]
        [TestCase(new object[] { null, null, 5, null }, true)]
        [TestCase(new object[] { null, null, 5, null, "test" }, true)]
        [TestCase(new object[] { null, null, "test", null, true }, true)]
        [TestCase(new object[] { null, null, '!', null, 4 }, true)]
        [TestCase(new object[] { null, false, null, null, '!', null, 4 }, true)]
        [TestCase(new object[] { null, null, new int[] { }, false, null, null, '!', null, 4 }, true)]
        public void MajorityOfElementsInArrayAreNull(object[] objects, bool expected)
        {
            var actual = _set04.MajorityOfElementsInArrayAreNull(objects);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, -3)]
        [TestCase(new int[] { 1, 2, 2, 3, 4 }, 2.6666666666)]
        [TestCase(new int[] { 1, -2, -2, 3, -4 }, -2.6666666666)]
        [TestCase(new int[] { 1, -2, 2, 3, -4 }, -1.3333333333)]
        [TestCase(new int[] { 1, 3, 5, 7 }, 0)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        [TestCase(new int[] { }, 0)]
        [TestCase(null, 0)]
        public void AverageEvens(int[] numbers, double expected)
        {
            var actual = _set04.AverageEvens(numbers);
            Assert.AreEqual(Math.Round(expected, 5), Math.Round(actual, 5));
        }


        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 6)]
        [TestCase(4, 24)]
        [TestCase(5, 120)]
        [TestCase(6, 720)]
        [TestCase(7, 5040)]
        [TestCase(8, 40320)]
        [TestCase(9, 362880)]
        [TestCase(10, 3628800)]
        public void Factorial(int number, int expected)
        {
            var actual = _set04.Factorial(number);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NegativeFactorialShouldThrowArgumentOutOfRangeException()
        {
            // Arrange
            int negative1 = -1;
            int negative2 = -2;
            int negative3 = -3;

            // Act
            Action actual1 = () => _set04.Factorial(negative1);
            Action actual2 = () => _set04.Factorial(negative2);
            Action actual3 = () => _set04.Factorial(negative3);

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(actual1.Invoke);
            Assert.Throws<ArgumentOutOfRangeException>(actual2.Invoke);
            Assert.Throws<ArgumentOutOfRangeException>(actual3.Invoke);
        }
    }
}
