using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNewVersion
{
    class TuplePatterns
    {
        public decimal GetTax(string state, string city) =>
            (state, city) switch
            {
                ("RJ", "Rio de Janeiro") => 10,
                ("RJ", "Petropolis") => 12,
                ("PR", "Curitiba") => 15,
                (_, _) => 5
            };

        [Test]
        public void TuplePatternsTest()
        {
            var firstTax = GetTax("RJ", "Rio de Janeiro");
            var secondTax = GetTax("PR", "Curitiba");
            var thirdTax = GetTax("SP", "Sao Paulo");

            Assert.That(firstTax, Is.EqualTo(10));
            Assert.That(secondTax, Is.EqualTo(15));
            Assert.That(thirdTax, Is.EqualTo(5));

        }
    }
}
