using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment3
{
    class TerrestrialPlanet: Planet, IHasMoons, IHabitable
    {
        private bool _oxygen;
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            _oxygen = oxygen;
        }

        public bool HasMoons() => MoonCount > 0;

        public bool Habitable() => _oxygen;
    }
}
