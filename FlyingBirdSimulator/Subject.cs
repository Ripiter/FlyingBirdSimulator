using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingBirdSimulator
{
    abstract class Subject
    {
        float speed;
        double distance;
        double timePassed;
        string name;
        protected Stopwatch stopwatch;

        public float Speed { get => speed; set => speed = value; }
        public double Distance { get => distance; set => distance = value; }
        public string Name { get => name; protected set => name = value; }
        public double TimePassed { get => timePassed; set => timePassed = value; }

        public Subject(string name)
        {
            this.Name = name;
        }

        public virtual void Start()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
        }


    }
}
