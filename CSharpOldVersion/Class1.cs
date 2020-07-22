using System;

namespace CSharpNewVersion
{
    interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        DateTime BirthDate { get; set; }

        int GetAge();
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
    }

    class User : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
    }


    class Class1
    {
    }
}
