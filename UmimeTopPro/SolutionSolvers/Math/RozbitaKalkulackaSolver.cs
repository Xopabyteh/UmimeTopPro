using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;


namespace UmimeTopPro.SolutionSolvers.Math
{
    class RozbitaKalkulackaSolver : ISolutionSolver
    {
        public void Solve()
        {
            try
            {
                IWebElement btn = Program.Driver.FindElement(By.XPath(@"//*[@class='calculatorButton blue noselect']"));
                int btnVal = Convert.ToInt32(btn.GetAttribute("button"));

                IWebElement send = Program.Driver.FindElement(By.XPath(@"//div[@button='=']"));
                IList<IWebElement> answers = Program.Driver.FindElements(By.XPath(@"//*[@class='answer noselect']"));

                for (int i = 0; i < answers.Count; i++)
                {
                    Program.Js.ExecuteScript($"document.querySelectorAll('.answer.noselect')[{i}].setAttribute('answer','{btnVal}');");
                }
                btn.Click();
                send.Click();

                GotoNext.Next(@"//span[@id='next']", 1000, 1000);
            }
            catch
            {
                Program.Workspace.StopSolvingWorkspace();
            }
            
        }
    }
}
