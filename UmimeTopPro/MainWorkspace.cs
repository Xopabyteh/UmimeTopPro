using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UmimeTopPro
{
    public partial class MainWorkspace : System.Windows.Forms.Form
    {
        private const string loginUrl = "https://www.umimeto.org/account-sign-in";
        public SolutionSolvers.SolutionSolver Solver;
        public int ActiveRadIndex = -1;

        public delegate void StopSolvingDelegate();
        public MainWorkspace()
        {
            InitializeComponent();

            InitializeDriver();
            Program.Driver.Navigate().GoToUrl(loginUrl);

            Solver = new SolutionSolvers.SolutionSolver(Program.CurrentSolver);
        }

        
        private void Form_Load(object sender, EventArgs e)
        {
            if (Program.username != null && Program.password != null)
            {
                IWebElement username = Program.Driver.FindElement(By.XPath(@"//*[@id='email']"));
                IWebElement password = Program.Driver.FindElement(By.XPath(@"//*[@id='heslo']"));
                IWebElement submit = Program.Driver.FindElement(By.XPath(@"//*[@value='Přihlásit']"));

                username.SendKeys(Program.username);
                password.SendKeys(Program.password);

                submit.Click();
            }
        }

        private void InitializeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments(new string[]{ "--start-maximized", "--incognito","--start-in-incognito"});

            ChromeDriverService cds = ChromeDriverService.CreateDefaultService();
            cds.HideCommandPromptWindow = true;

            Program.Driver = new ChromeDriver(cds,options);
            Program.Js = (IJavaScriptExecutor)Program.Driver;
        }

        private void btn_stopWork_Click(object sender, EventArgs e)
        {
            StopSolvingWorkspace();
        }

        public void StopSolvingWorkspace()
        {
            if (btn_stopWork.InvokeRequired)
            {
                var d = new StopSolvingDelegate(StopSolvingWorkspace);
                btn_stopWork.Invoke(d);
            }
            else
            {
                btn_stopWork.Enabled = false;
                btn_work.Enabled = true;
                btn_modules.Enabled = true;

                Solver.StopSolving();
            }
        }
        private void btn_work_Click(object sender, EventArgs e)
        {
            if(Program.CurrentSolver != null)
            {
                btn_stopWork.Enabled = true;
                btn_work.Enabled = false;
                btn_modules.Enabled = false;

                Solver.ISolver = Program.CurrentSolver;
                Solver.StartSolving();
            }
        }


        #region Navmenu
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel_workArea.Controls.Add(childForm);
            panel_workArea.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
                activeForm.Close();
        }
        private void btn_modules_Click(object sender, EventArgs e)
        {     
            openChildForm(new Modules());
        }
        private void btn_autoLogin_Click(object sender, EventArgs e)
        {
            openChildForm(new Autologin());
        }
        #endregion

        #region FormControls
        private bool panelDrag = false;
        private int movX, movY;
        private void panel_control_MouseDown(object sender, MouseEventArgs e)
        {
            panelDrag = true;
            movX = e.X;
            movY = e.Y;
        }

        private void panel_control_MouseMove(object sender, MouseEventArgs e)
        {
            if(panelDrag)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }


        private void panel_control_MouseUp(object sender, MouseEventArgs e)
        {
            panelDrag = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void check_onTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = check_onTop.Checked;
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion


    }
}
