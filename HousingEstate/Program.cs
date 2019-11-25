using System;
using System.Collections.Generic;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            HousingEstate housingEstate = new HousingEstate();
            var blockOfFlats1 = new BlockOfFlats(1);
            var entrance1 = new Entrance(100);
            var flat1 = new Flat(1);
            var person1 = new Person("Jozko", "Mrkvicka", 50);
            var person2 = new Person("Zuzana", "Mrkvickova", 43);
            flat1.People.Add(person1);
            flat1.People.Add(person2);
            entrance1.FlatList.Add(flat1);
            blockOfFlats1.EntranceList.Add(entrance1);
            housingEstate.BlockOfFlats.Add(blockOfFlats1);
        }
    }
}
