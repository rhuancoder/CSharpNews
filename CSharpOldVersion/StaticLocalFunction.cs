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
                return Multiply();
            }

            return 0;

            int Sum(int numberA2, int numberB2) =>  numberA2 + numberB2;
            int Multiply() => numberA * numberB;
        }
    }
}
