using System;
using System.Threading;

namespace FlyingBirdSimulator
{
    class FlySimulating
    {
        Subject subject;
        bool stopSimulating = false;
        int dataRefreshRate = 250;
        public event EventHandler dataAvaible;


        public bool StopSimulating { get => stopSimulating; set => stopSimulating = value; }
        public int DataRefreshRate { get => dataRefreshRate; set => dataRefreshRate = value; }

        public void StartSimulation(Subject subject)
        {
            this.subject = subject;
            Thread simulation = new Thread(Simulating);
            Thread dataRefresh = new Thread(RefreshData);
            dataRefresh.Start();

            if (subject is IFly)
                simulation.Start();
        }

        void Simulating()
        {
            subject.Start();
            while (stopSimulating == false)
            {
                ((IFly)subject).Fly();
            }
        }

        void RefreshData()
        {
            while(stopSimulating == false)
            {
                if (dataAvaible != null)
                    dataAvaible(subject, new EventArgs());

                Thread.Sleep(DataRefreshRate);
            }
        }
    }
}
