using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Person
    {
        public Person(string name, string surname, int age, int reference)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Reference = reference;
        }

        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        public int Reference { get; }
    }
}
