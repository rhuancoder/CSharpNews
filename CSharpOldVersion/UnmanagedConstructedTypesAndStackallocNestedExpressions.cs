using System;

namespace CSharpNewVersion
{
    public struct Coords<T>
    {
        public T X;
        public T Y;
    }

    class UnmanagedConstructedTypesAndStackallocNestedExpressions
    {
        public void UnmanagedConstructedTypesAndStackallocNestedExpressionsTest()
        {
            //Span<Coords<int>> coordinates = stackalloc[]
            //{
            //    new Coords<int> { X = 0, Y = 2 },
            //    new Coords<int> { X = 50, Y = 30 }
            //};

            //Span<int> numbers = stackalloc[] { 1, 2, 3, 4 };
            //var ind = numbers.IndexOfAny(stackalloc[] { 3, 4 });
        }
    }
}
