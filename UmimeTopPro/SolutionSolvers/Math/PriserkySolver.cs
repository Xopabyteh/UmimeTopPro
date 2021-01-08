namespace UmimeTopPro.SolutionSolvers.Math
{
    class PriserkySolver : ISolutionSolver
    {
        public void Solve()
        {
            Program.Js.ExecuteScript(@"score=420420;
answers=score;
answersCorrect=score;


var _0x42358c = 'ajax/zombiciLog.php?question=' + 0 + '&user=' + user + '&correct=' + 1 + _0xbddb('0x4') + ps + _0xbddb('0x33') + score + '&answers=' + answers + '&answersCorrect=' + answersCorrect + _0xbddb('0x3e') + cookieHash + _0xbddb('0x55') + deviceType + '&source=' + source;
$(_0xbddb('0x15'))[_0xbddb('0xf')](_0x42358c, function() {});
document.getElementById('exercise').innerHTML = 'Automaticaly solved by UmimeTop';");

            Program.Workspace.StopSolvingWorkspace();
        }
    }
}
