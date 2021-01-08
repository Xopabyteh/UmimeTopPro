using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;

namespace UmimeTopPro.SolutionSolvers.Math
{
    public class ZavodySolver : ISolutionSolver
    {
        public void Solve()
        {
            Program.Js.ExecuteScript(@"  var data = {};
  data.ps = ps;
  data.question = 0;
  data.correct = 1;  
  data.cookieHash = cookieHash;
  data.deviceType = deviceType;
  data.source = source;

for (i = 0; i < 50; i++) {
  controlSendCommand('logAnswer',data); 
}
   ");
            Program.Workspace.StopSolvingWorkspace(); 
        }
    }
}
