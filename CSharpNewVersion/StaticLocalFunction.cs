using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNewVersion
{
    enum CalculationType
    {
        Sum,
        Multiply
    }

    class StaticLocalFunction
    {
        int Calculate(int numberA, int numberB, CalculationType calculationType)
        {
            if(calculationType == CalculationType.Sum)
            {
                return Sum(numberA, numberB);
            }
            else if(calculationType == CalculationType.Multiply)
            {
                return Multiply(numberA, numberB);
            }

            return 0;

            static int Sum(int numberA, int numberB) =>  numberA + numberB;
            static int Multiply(int numberA, int numberB) => numberA * numberB;
        }

        [Test]
        public void StaticLocalFunctionTest()
        {
            var result = Calculate(10, 2, CalculationType.Sum);
            Assert.That(result, Is.EqualTo(12));

            result = Calculate(10, 2, CalculationType.Multiply);
            Assert.That(result, Is.EqualTo(20));
        }
    }
}
