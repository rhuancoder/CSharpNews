using System;

namespace CSharpNewVersion
{
    interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        DateTime BirthDate { get; set; }

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


    class Class1
    {
    }
}
