using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UmimeTopPro.SolutionSolvers.Math
{
    class UzemivkaSolver : ISolutionSolver
    {
        public void Solve()
        {
            //\"ajax/uzemickaLog.php?question=\"+1601+\"&user=\"+user+\"&playerNumber=\"+myPlayerNumber+\"&posX=\"+x+\"&posY=\"+y+\"&correct=\"+1+\"&ps=\"+ps+\"&game=\"+game+\"&cookieHash=\"+cookieHash+\"&source=\"+source+\"&deviceType=\"+deviceType;
            Program.Js.ExecuteScript("var grid = ndata[0].myMap.toString().split('|'); for(y=0;y<grid.length;y++){for(x=0;x<grid[0].length;x++){var url = \"ajax/uzemickaLog.php?question=\"+1601+\"&user=\"+user+\"&playerNumber=\"+myPlayerNumber+\"&posX=\"+x+\"&posY=\"+y+\"&correct=\"+1+\"&ps=\"+ps+\"&game=\"+game+\"&cookieHash=\"+cookieHash+\"&source=\"+source+\"&deviceType=\"+deviceType; $( \"#result\" ).load(url, function() {    });}};");

            Program.Workspace.StopSolvingWorkspace();
        }
    }
}
