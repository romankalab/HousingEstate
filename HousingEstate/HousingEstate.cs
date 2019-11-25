using System.Collections.Generic;

namespace HousingEstate
{
    class HousingEstate
    {
        public HousingEstate()
        {
            BlockOfFlats = new List<BlockOfFlats>();
        }

        public List<BlockOfFlats> BlockOfFlats { get; }
    }
}
