using NUnit.Framework;
using System;

namespace CSharpNewVersion
{
    interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        DateTime BirthDate { get; set; }

        // implementing method, right in the interface
        int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }

    class User : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }

    [TestFixture]
    class InterfaceMethod
    {
        [Test]
        public void Class1Test()
        {
            IPerson person = new Customer
            {
                BirthDate = Convert.ToDateTime("01/01/1990")
            };

            var years = DateTime.Now.Year - person.BirthDate.Year;

            Assert.That(years, Is.EqualTo(person.GetAge()));
        }
    }
}
