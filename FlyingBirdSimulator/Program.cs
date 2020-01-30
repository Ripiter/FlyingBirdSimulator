using System;
using System.Threading;

namespace FlyingBirdSimulator
{
    class Program
    {
        static Subject subject;
        static void Main(string[] args)
        {
            subject = new Crow("Jimmothy");
            Thread a = new Thread(FlyingSimulator);
            subject.Start();
            a.Start();

            while (true)
                Console.WriteLine(subject.Name + " Traveled " + (int)subject.Distance + "m");

        }

        static void FlyingSimulator()
        {
            while (true)
            {
                if (subject is IFly)
                {
                    ((IFly)subject).Fly();
                }
            }
        }
    }
}
