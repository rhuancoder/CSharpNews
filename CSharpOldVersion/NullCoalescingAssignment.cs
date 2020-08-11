using System.Collections.Generic;

namespace CSharpNewVersion
{
    internal class NullCoalescingAssignment
    {
        public void NullCoalescingAssigmentFirstTest()
        {
            List<int> numbers = null;

            if (numbers == null)
            {
                numbers = new List<int>() { 1, 2, 3 };
            }
        }

        public void NullCoalescingAssigmentSecondTest()
        {
            List<int> numbers = null;

            numbers = numbers ?? new List<int>() { 1, 2, 3 };
        }

        //public void NullCoalescingAssigmentThirdTest()
        //{
        //    List<int> numbers = null;

        //    numbers ??= new List<int>() { 1, 2, 3 };
        //}
    }
}