using NUnit.Framework;
using System.Collections.Generic;

namespace Kata1.Tests
{
    
    public class Test
    {
        [Test]
        public void NoCharacterTest()
        {
            var expected = new List<string> { "" };
            Assert.That(Anagrams.Of(""), Is.EqualTo(expected));
        }

        [Test]
        public void OneCharacter()
        {
            var expected = new List<string> { "A" };
            Assert.That(Anagrams.Of("A"), Is.EqualTo(expected));
        }

        [Test]
        public void TwoCharacters()
        {
            var expected = new List<string> { "AB", "BA" };
            Assert.That(Anagrams.Of("AB"), Is.EqualTo(expected));

        }

        [Test]
        public void ThreeCharacters()
        {
            var expected = new List<string> { "ABC", "ACB", "BAC", "BCA", "CAB", "CBA" };
            Assert.That(Anagrams.Of("ABC"), Is.EqualTo(expected));
        }
    }
}
