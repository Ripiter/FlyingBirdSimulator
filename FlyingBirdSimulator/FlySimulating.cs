using System;
using System.Threading;

namespace FlyingBirdSimulator
{
    class FlySimulating
    {
        Subject subject;
        bool stopSimulating = false;
        public event EventHandler dataAvaible;

        public bool StopSimulating { get => stopSimulating; set => stopSimulating = value; }

        public void StartSimulation(Subject subject)
        {
            this.subject = subject;
            Thread simulation = new Thread(Simulating);

            if (subject is IFly)
                simulation.Start();
        }

        void Simulating()
        {
            subject.Start();
            while (stopSimulating == false)
            {
                ((IFly)subject).Fly();
                if (dataAvaible != null)
                    dataAvaible(subject, new EventArgs());
            }
        }
    }
}
