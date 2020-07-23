using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment3
{
    class GiantPlanet: Planet, IHasMoons, IHasRings
    {
        private string _type;
        public GiantPlanet(string name, double diameter, double mass, string type):base(name, diameter, mass)
        {
            _type = type;
        }
        public bool HasMoons()
        {
            return MoonCount > 0;
        }

        public bool HasRings()
        {
            return RingCount > 0;
        }
    }
}
