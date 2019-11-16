using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class BlockOfFlats
    {
        public BlockOfFlats(int registernumber, Entrance[] entrancelist)
        {
            RegisterNumber = registernumber;
            EntranceList = entrancelist;
        }

        public int RegisterNumber { get; }
        public Entrance[] EntranceList { get; }
    }
}
