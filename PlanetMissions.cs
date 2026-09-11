using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetMissionsTest
{
    internal abstract class PlanetMission
    {
        protected float fuelPerKm;
        protected long kmPerHour;
        protected long kmToPlanet;

        public string MissionInfo()
        {
            long fuel = (long)(kmToPlanet * fuelPerKm);
            long time = kmToPlanet / kmPerHour;
            return $"We'll burn {fuel} units of fuel in {time} hours";
        }
    }

    class Mars : PlanetMission
    {
        public Mars()
        {
            kmToPlanet = 92000000;
            fuelPerKm = 1.73f;
            kmPerHour = 37000;
        }
    }

    class Venus : PlanetMission
    {
        public Venus()
        {
            kmToPlanet = 41000000;
            fuelPerKm = 2.11f;
            kmPerHour = 29500;
        }
    }
}
