using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Flat
    {
        public Flat(int number, List<Person> peoplelist, int entrance)
        {
            Number = number;
            PeopleList = peoplelist;
            Entrance = entrance;
        }

        public int Number { get; }
        public List<Person> PeopleList { get; set; }
        public int Entrance { get; }
    }
}
