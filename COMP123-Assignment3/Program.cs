using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment3
{
    /*
     * Mingxin Cong
     * 301130476
     * Date of last modification: July 23, 2020
     * Program Description: Assignment 3
     * Revision History: 
     * Finished on July 23, 2020
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("giant planet 1", 10000, 1000000, "Gas");
            Console.WriteLine(giantPlanet.ToString());
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("terrestrial planet 1", 20000, 2000000, true);
            Console.WriteLine(terrestrialPlanet.ToString());
            WaitForAnyKey();
        }

        static void WaitForAnyKey()
        {
            Console.ReadKey();
        }
    }
}
