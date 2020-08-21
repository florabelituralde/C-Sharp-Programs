//Class:  ERAU ISTA322 Programming Fundamentals
//Student:  Kyle Dailey, Tyler Kain, Florabel Ituralde, Tim Tieng (Team Vindicators)
//Instructor:  Christine E. Lee, Instructor
//Date:  08/18/2020

/**************************************************************************************************************************************************************************************

Description:  This project contains code for the Military Unit Inheritance exercise.  It will create a console application which demonstrates inheritance.

***************************************************************************************************************************************************************************************

Revisions:  None

Revision Date:  N/A

Revised By:  N/A

***************************************************************************************************************************************************************************************/

using System;

namespace MilitaryUnitInheritance_DaileyKyle08182020
{
    class Program
    {
        static void myTeamInfo()
        {
            Console.WriteLine("This is my Team!");
            Team myAlphaTeam = new Team();
            myAlphaTeam.rank = "SGT";
            myAlphaTeam.position = "Rifleman";
            myAlphaTeam.size = 4;
            myAlphaTeam.alphaTeam();

            Team myBravoTeam = new Team();// this is my squad
            myBravoTeam.rank = "CPL";
            myBravoTeam.position = "Grenadier";
            myBravoTeam.size = 3;
            myBravoTeam.bravoTeam();

            Console.WriteLine("This is my Squad!");
            Squad mySquad = new Squad();
            mySquad.rank = "SGT";
            mySquad.position = "Squad Leader";
            mySquad.PSG();
            mySquad.PLLeader();
        }

        static void Main()
        {
            try
            {
                myTeamInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine("You did something wrong: {0}", ex.Message);
            }
        }
    }
}
