using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNewVersion
{
    class MyClass { }


    class NullableReferenceTypes
    {
        [Test]
        public void NullableReferenceTypesTest()
        {
            string name = null;

            MyClass? myClass = null;
        }

        [Test]
        public void NullableReferenceTypesWithNullableWarnTest()
        {
#nullable enable
            string name = null;

            MyClass myClass = null;
#nullable restore
        }
    }
}
