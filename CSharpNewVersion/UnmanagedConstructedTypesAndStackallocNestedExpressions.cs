using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNewVersion
{
    public struct Coords<T>
    {
        public T X;
        public T Y;
    }

    class UnmanagedConstructedTypesAndStackallocNestedExpressions
    {
        [Test]
        public void UnmanagedConstructedTypesAndStackallocNestedExpressionsTest()
        {
            Span<Coords<int>> coordinates = stackalloc[]
            {
                new Coords<int> { X = 0, Y = 2 },
                new Coords<int> { X = 50, Y = 30 }
            };

            Span<int> numbers = stackalloc[] { 1, 2, 3, 4 };
            var ind = numbers.IndexOfAny(stackalloc[] { 3, 4 });

            Assert.That(ind, Is.EqualTo(2));
        }
    }
}
