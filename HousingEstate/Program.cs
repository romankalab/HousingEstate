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
            //blockOfFlats1.EntranceList.Add(entrance1);
            housingEstate.BlockOfFlats.Add(blockOfFlats1);



            //for (int i = 1; i < 6; i++)
            //{
            //    blockOfFlats1.EntranceList.Add(new Entrance(i * 2));
            //}

            //foreach (var entrance in blockOfFlats1.EntranceList)
            //{
            //    for (int i = 1; i < 15; i++)
            //    {
            //        entrance.FlatList.Add(new Flat(i));
            //    }
            //}

            //foreach (var entrance in blockOfFlats1.EntranceList)
            //{
            //    foreach (var flat in entrance.FlatList)
            //    {
            //        for (int i = 0; i < GetRandomNumberOfPeople(); i++)
            //        {
            //            flat.People.Add(new Person(GetRandomName(), GetRandomSurname, GetRandomAge()));
            //        }
            //    }
            //}

            
            Console.WriteLine(GetRandomName());

        }

        private static string GetRandomName()
        {
            List<string> randomNames = new List<string>
                {
                    "Roman",
                    "Jakub",
                    "Martin"
                };

            Random rand = new Random();

            return randomNames.ToArray()[rand.Next(0, randomNames.Count)];
        }
    }
}
