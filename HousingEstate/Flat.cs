using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Flat
    {
        public Flat(int number)
        {
            Number = number;
            People = new List<Person>();
        }

        public int Number { get; }
        public List<Person> People { get; set; }
    }
}
