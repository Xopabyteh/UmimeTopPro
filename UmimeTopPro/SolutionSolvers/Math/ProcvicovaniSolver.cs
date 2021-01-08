using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmimeTopPro.SolutionSolvers.Math
{
    class ProcvicovaniSolver : ISolutionSolver
    {
        public void Solve()
        {
            Program.Js.ExecuteScript(@"
var answerString = '-500';
var answerClass = classifyAnswer(1, 420, 50, answerString, -500);
$[_0x1ed8('0x6')]({
                'url': _0x1ed8('0xa'),
    'type': 'POST',
    'data': {
                    'exercise': exercise,
        'ps': ps,
        'user': user,
        'skill': 1,
        'cookieHash': cookieHash,
        'inRow': inRow,
        'homework': homework,
        'responseMasteryTime': responseMasteryTime,
        'masteryAttempts': masteryAttempts,
        'bufferedAttempts': bufferedAttempts,
        'deviceType': deviceType,
        'source': source
    },
    'success': function(_0x1634c0) {
                    processLog = ![];
                    bufferedAttempts = 0x0;
                }
            });

            logAnswer(0, answerString, 1, 5, answerClass);

            document.getElementById('exercise').innerHTML = 'Automaticaly solved by UmimeTop.';
            ");

            Program.Workspace.StopSolvingWorkspace();
        }
    }
}
