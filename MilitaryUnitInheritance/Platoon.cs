using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnitInheritance_DaileyKyle08182020
{
    abstract class Platoon
    {
        public string rank { get; set; }
        public string position { get; set; }
        public int size { get; set; }

        public void PLLeader()
        {
            Console.WriteLine(" Delegates to his peasants, gloats about his superior knowledge and time at IBLOC");
            Console.WriteLine(" Issues OPORD, emphazies the weather, and OER Bullets, tells his squad to make him look good or else lunch is canceled");
            Console.WriteLine("H-Minus, AATW, Army Strong");
        }

        public virtual void PSG()
        {
            Console.WriteLine("Looks at his Platoon Leader with disdan, cant wait to retire");
            Console.WriteLine("Wonders wears his Team Leaders are because his platoon is so messed up");
            Console.WriteLine(" Gets Platoon REDCON 1");
        }
    }
}