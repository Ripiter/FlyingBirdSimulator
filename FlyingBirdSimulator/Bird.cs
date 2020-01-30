using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingBirdSimulator
{
    abstract class Bird : Subject
    {
        public Bird(string name) : base(name)
        {

        }
    }
}
