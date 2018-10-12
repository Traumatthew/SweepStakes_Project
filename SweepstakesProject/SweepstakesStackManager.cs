using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> sweepstakesStack = new Stack<Sweepstakes>();

        public void InsertSweepstakes(Sweepstakes sweepstake)
        {
            sweepstakesStack.Push(sweepstake);
        }

    }
}
