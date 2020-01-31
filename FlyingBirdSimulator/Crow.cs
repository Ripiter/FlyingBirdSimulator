using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingBirdSimulator
{
    class Crow : Bird, IFly
    {
        public Crow(string name) : base(name)
        {
            this.Speed = 3.6f;
        }

        public override void Start()
        {
            base.Start();
        }

        public void Fly()
        {
            this.TimePassed = stopwatch.Elapsed.TotalSeconds;

            Distance = TimePassed * Speed;
        }
    }
}
