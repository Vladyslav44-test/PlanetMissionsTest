using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetMissionsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Venus().MissionInfo());
            Console.WriteLine(new Mars().MissionInfo());
            Console.WriteLine(new PlanetMission().MissionInfo());
        }
    }
}
