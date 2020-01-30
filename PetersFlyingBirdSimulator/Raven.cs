using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetersFlyingBirdSimulator
{
    class Raven : Bird, ISetAtitude
    {
        public override void Draw()
        {
            // I Draw
        }

        public void SetAltitude(double altitude)
        {
            // Sets altitude
        }

        public override void SetLocation(double longitude, double latitude)
        {
            // Sets Location
        }
    }
}
