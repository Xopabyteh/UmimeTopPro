using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace UmimeTopPro.SolutionSolvers.Math
{
    class TipovackaSolver : ISolutionSolver
    {
        public void Solve()
        {
            Program.Js.ExecuteScript(@"var answer = -420
            var answer = encodeURIComponent(answer);
            var deviation = 0     

            var data = {};
            data.ps = ps;
            data.answer = answer;
            data.deviation = deviation;
            data.responseTime = questionTime;    
            data.question = 0
            data.cookieHash = cookieHash;
            data.deviceType = deviceType;
            data.source = source;
            controlSendCommand('logAnswer',data); ");

            Thread.Sleep(5);
        }
    }
}
