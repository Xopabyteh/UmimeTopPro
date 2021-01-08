using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmimeTopPro.SolutionSolvers.Math
{
    class RobotiSolver : ISolutionSolver
    {
        public void Solve()
        {
            Program.Js.ExecuteScript(@"for(i=0;i<101;i++) //128
{
logLevelDone(user,ps,i,1,-5,-5); 
}");
            Program.Workspace.StopSolvingWorkspace();
        }
    }
}
