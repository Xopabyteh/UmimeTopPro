using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmimeTopPro.SolutionSolvers.Math
{
    class KulickaSolver : ISolutionSolver
    {
        public void Solve()
        {
            try
            {
                Program.Js.ExecuteScript(@"toCollect=0;finished=0;evaluate();");
                GotoNext.Next(@"//span[@id='next']", 1000, 1000);
            }
            catch
            {
                Program.Workspace.StopSolvingWorkspace();
            }

        }
    }
}
