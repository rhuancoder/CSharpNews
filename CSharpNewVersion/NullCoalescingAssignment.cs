using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNewVersion
{
    class NullCoalescingAssignment
    {
        [Test]
        public void NullCoalescingAssigmentFirstTest()
        {
            List<int> numbers = null;

            if(numbers == null)
            {
                numbers = new List<int>() { 1, 2, 3 };
            }

            Assert.That(numbers, Is.Not.Null);
        }

        [Test]
        public void NullCoalescingAssigmentSecondTest()
        {
            List<int> numbers = null;

            numbers = numbers ?? new List<int>() { 1, 2, 3 };

            Assert.That(numbers, Is.Not.Null);
        }

        [Test]
        public void NullCoalescingAssigmentThirdTest()
        {
            List<int> numbers = null;

            numbers ??= new List<int>() { 1, 2, 3 };

            Assert.That(numbers, Is.Not.Null);
        }
    }
}
