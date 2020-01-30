using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetersFlyingBirdSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird pinguin = new Pinguin();
            Bird raven = new Raven();

            pinguin.SetLocation(0, 0);
            pinguin.Draw();
            if (pinguin is ISetAtitude)
                ((ISetAtitude)pinguin).SetAltitude(0);


            raven.SetLocation(1, 1);
            raven.Draw();
            if (raven is ISetAtitude)
                ((ISetAtitude)raven).SetAltitude(1);


            Console.ReadKey();

        }
    }
}
