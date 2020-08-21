using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnitInheritance_DaileyKyle08182020
{
    class Squad : Platoon
    {
        public string rank { get; set; }
        public string position { get; set; }
        public int size { get; set; }

        public override void PSG()
        {
            Console.WriteLine("Carries out the orders of the Platoon leader to the team.");
        }
        public void TeamLeader()
        {
            Console.WriteLine("Carries out the orders of the Squad Leader to the team.");
        }
        public void AutomaticRifleman()
        {
            Console.WriteLine("Carries out the orders of the Alpha and Bravo Team Leaders.");
        }
        public void Rifleman()
        {
            Console.WriteLine("Scouts all areas designated by Team Leaders.");
        }
    }
}
