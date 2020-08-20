using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNewVersion
{
    class Address
    {
        public string City { get; set; }
        public string State { get; set; }
    }

    class PropertyPatterns
    {
        public decimal GetTax(Address address) =>
            address switch
            {
                { State: "RJ"} => 10,
                { State: "PR"} => 13,
                _ => 5
            };

        [Test]
        public void PropertyPatternsTest()
        {
            var firstAddress = new Address() { State = "RJ" };
            var secondAddress = new Address() { State = "PR" };
            var thirdAddress = new Address() { State = "MG" };

            var firstTax = GetTax(firstAddress);
            var secondTax = GetTax(secondAddress);
            var thirdTax = GetTax(thirdAddress);

            Assert.That(firstTax, Is.EqualTo(10));
            Assert.That(secondTax, Is.EqualTo(13));
            Assert.That(thirdTax, Is.EqualTo(5));
        }
    }
}
