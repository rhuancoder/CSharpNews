namespace CSharpNewVersion
{
    internal struct MyStructWithReference
    {
        public void Dispose()
        {
            DisposableRefStructs.IsMyStructWithReferenceDead = true;
        }
    }

    internal class DisposableRefStructs
    {
        public static bool IsMyStructWithReferenceDead { get; set; } = false;

        public void DisposableRefStructsTest()
        {
            //using (var myStructWithReferente = new MyStructWithReference())
            //{
            //}
            // can't implement using
        }
    }
}