using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UmimeTopPro.SolutionSolvers
{
    public class SolutionSolver
    {
        public ISolutionSolver ISolver;
        public Thread T = null;

        private bool solving = false;
        public SolutionSolver(ISolutionSolver _ISolver)
        {
            ISolver = _ISolver;
        }

        public void StartSolving()
        {
            solving = true;

            T = new Thread(SolveThread);
            T.Start();
        }
        public void StopSolving()
        {
            solving = false;

            if (T != null)
            {
                T.Abort();
            }
                
        }

        private void SolveThread()
        {
            while(solving)
            {
                ISolver.Solve();
            }
        }
    }
}
