using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmimeTopPro.SolutionSolvers.Math
{
    class BarevneSudokuSolver : ISolutionSolver
    {
        public void Solve()
        {
            Program.Js.ExecuteScript(@"
for(i=0;i<items.length;i++)
{
logAttempt(ps,user,items[i].id,'',1,-5,cookieHash);
}");
            Program.Workspace.StopSolvingWorkspace();
        }
    }
}
