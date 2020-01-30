using System;
using System.Threading;

namespace FlyingBirdSimulator
{
    class Program
    {
        static Subject subject;


        static void Main(string[] args)
        {
            FlySimulating flySimulating = new FlySimulating();
            subject = new Crow("Jimmothy");

            flySimulating.StartSimulation(subject);
            flySimulating.dataAvaible += SimulatingInfo;
            

            Console.ReadKey();
            flySimulating.StopSimulating = true;

            Console.ReadLine();
        }

        private static void SimulatingInfo(object sender, EventArgs e)
        {
            Subject sub = (Subject)sender;

            Console.WriteLine(sub.Name + " Traveled " + (int)sub.Distance + "meters");
        }

    }
}
