using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNewVersion
{
    ref struct MyStructWithReference
    {
        public void Dispose()
        {
            DisposableRefStructs.IsMyStructWithReferenceDead = true;
        }
    }

    class DisposableRefStructs
    {
        public static bool IsMyStructWithReferenceDead { get; set; } = false;

        [Test]
        public void DisposableRefStructsTest()
        {
            using (var myStructWithReferente = new MyStructWithReference())
            {

            } // is disposed

            Assert.That(IsMyStructWithReferenceDead, Is.True);
        }
    }
}
