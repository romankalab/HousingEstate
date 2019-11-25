using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class BlockOfFlats
    {
        public BlockOfFlats(int registerNumber)
        {
            RegisterNumber = registerNumber;
            EntranceList = new List<Entrance>();
        }

        public int RegisterNumber { get; }
        public List<Entrance> EntranceList { get; }
    }
}
