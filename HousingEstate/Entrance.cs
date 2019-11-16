using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Entrance
    {
        public Entrance(int orientationnumber, Flat[,] flatlist, int blockofflats)
        {
            OrientationNumber = orientationnumber;
            FlatList = flatlist;
            BlockOfFlats = blockofflats;
        }

        public int OrientationNumber { get; }
        public Flat[,] FlatList { get; }
        public int BlockOfFlats { get; }
    }
}
