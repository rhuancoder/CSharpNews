using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CSharpNewVersion
{
    class IndexesAndRanges
    {
        [Test]
        public void IndexesAndRangesTest()
        {
            var words = new string[]
            {
                "cachorro",
                "gato",
                "passarinho",
                "elefante"
            };

            Assert.That(words[0], Is.EqualTo("cachorro"));

            Assert.That(words[^1], Is.EqualTo("elefante"));

            Assert.That(words[words.Length -1], Is.EqualTo("elefante"));

            foreach(var word in words[2..^0])
            {
                Debug.WriteLine(word);
            }

            Range range = 1..^0;

            foreach (var word in words[range])
            {
                Debug.WriteLine(word);
            }

            Assert.That(words[words.Length - 1], Is.EqualTo("elefante"));
        }
    }
}
