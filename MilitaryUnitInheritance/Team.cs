using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnitInheritance_DaileyKyle08182020
{
    class Team : Squad
    {
        public string rank { get; set; }
        public string position { get; set; }
        public int size { get; set; }

        //Constructor of the Team class
        //public override Team(string tmRank, string tmPosition, int tmSize)
        //{
           // rank = tmRank;
           // position = tmPosition;
           // size = tmSize;
       // }
        public void alphaTeam()
        {
            Console.WriteLine("We take point, we are navigating for the overall unit");
        }
        public void bravoTeam()
        {
            Console.WriteLine("We secure the rear of the formation for the overall unit");
        }
    }
}

