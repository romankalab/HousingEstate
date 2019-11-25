using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Entrance
    {
        public Entrance(int orientationNumber)
        {
            OrientationNumber = orientationNumber;
            FlatList = new List<Flat>();
        }

        public int OrientationNumber { get; }
        public List<Flat> FlatList { get; }
    }
}
