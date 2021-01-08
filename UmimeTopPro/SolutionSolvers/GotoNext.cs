using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;

namespace UmimeTopPro.SolutionSolvers
{
    public static class GotoNext
    {
        public static void Next(string xp, int bef, int af)
        {
            if(bef > 0)
                Thread.Sleep(bef);
            Program.Driver.FindElement(By.XPath(xp)).Click();
            if(af > 0)
                Thread.Sleep(af);
        }
    }
}
