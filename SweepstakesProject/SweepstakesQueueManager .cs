using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        public Queue<Sweepstakes> sweepstakeQueue = new Queue<Sweepstakes>();

        public void InsertSweepstakes(Sweepstakes sweepstake)
        {
            sweepstakeQueue.Enqueue(sweepstake);
        }

        public Sweepstakes GetSweepstakes()
        {
            return sweepstakeQueue.Dequeue();
        }

    }
}
