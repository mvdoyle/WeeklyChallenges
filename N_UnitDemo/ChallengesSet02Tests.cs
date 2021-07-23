using ChallengesWithTestsMark8;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace N_UnitDemo
{
    [TestFixture]
    public class ChallengesSet02Tests
    {
        private ChallengesSet02 _set02;

        [SetUp]
        public void Setup()
        {
            _set02 = new ChallengesSet02();
        }

        [Test]
        public void CharacterIsALetter()
        {
            string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";

            foreach (var letter in lowercaseAlphabet)
            {
                var lowercaseActual = _set02.CharacterIsALetter(letter);
                var uppercaseActual = _set02.CharacterIsALetter(char.ToUpper(letter));

                Assert.IsTrue(lowercaseActual);
                Assert.IsTrue(uppercaseActual);
            }
        }



    }
}
