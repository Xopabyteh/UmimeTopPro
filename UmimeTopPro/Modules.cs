using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmimeTopPro
{
    public partial class Modules : Form
    {
        public List<RadioButton> ModRads = new List<RadioButton>();
        public Modules()
        {
            InitializeComponent();
            AddRads();

            if (Program.Workspace.ActiveRadIndex != -1)
                ModRads[Program.Workspace.ActiveRadIndex].Checked = true;
        }
        private void AddRads()
        {
            ModRads.Add(rad_barevneSudoku);
            ModRads.Add(rad_tipovacka);
            ModRads.Add(rad_zavody);
            ModRads.Add(rad_uzemicka);
            ModRads.Add(rad_rozbitaKalkulacka);
            ModRads.Add(rad_kulicka);
            ModRads.Add(rad_roboti);
            ModRads.Add(rad_priserky);
            ModRads.Add(rad_logicke);
            ModRads.Add(rad_procvicovani);
        }
        private void SetSolver(ISolutionSolver IS, RadioButton exception)
        {
            Program.CurrentSolver = IS;
            for (int i = 0; i < ModRads.Count; i++)
            {
                if (ModRads[i] == exception)
                    Program.Workspace.ActiveRadIndex = i;
            }  
        }

        private void rad_zavody_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_zavody.Checked)
                SetSolver(new SolutionSolvers.Math.ZavodySolver(), rad_zavody);
        }

        private void rad_tipovacka_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_tipovacka.Checked)
                SetSolver(new SolutionSolvers.Math.TipovackaSolver(), rad_tipovacka);
        }

        private void rad_uzemicka_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_uzemicka.Checked)
                SetSolver(new SolutionSolvers.Math.UzemivkaSolver(), rad_uzemicka);
        }

        private void rad_barevneSudoku_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_barevneSudoku.Checked)
                SetSolver(new SolutionSolvers.Math.BarevneSudokuSolver(), rad_barevneSudoku);
        }

        private void rad_rozbitaKalkulacka_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_rozbitaKalkulacka.Checked)
                SetSolver(new SolutionSolvers.Math.RozbitaKalkulackaSolver(), rad_rozbitaKalkulacka);
        }

        private void rad_kulicka_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_kulicka.Checked)
                SetSolver(new SolutionSolvers.Math.KulickaSolver(), rad_kulicka);
        }

        private void rad_roboti_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_roboti.Checked)
                SetSolver(new SolutionSolvers.Math.RobotiSolver(), rad_roboti);
        }

        private void rad_priserky_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_priserky.Checked)
                SetSolver(new SolutionSolvers.Math.PriserkySolver(), rad_priserky);
        }

        private void rad_logicke_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_logicke.Checked)
                SetSolver(new SolutionSolvers.Math.LogickeSolver(), rad_logicke);
        }

        private void rad_procvicovani_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_procvicovani.Checked)
                SetSolver(new SolutionSolvers.Math.ProcvicovaniSolver(), rad_procvicovani);
        }
    }
}
