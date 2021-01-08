using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UmimeTopPro
{
    public partial class Autologin : Form
    {
        
        public Autologin()
        {
            InitializeComponent();
            if(Program.srDat != null && Program.srDat.Length>1)
            {
                txt_username.Text = Program.username;
                txt_password.Text = Program.password;
            }
        }
        private void btn_setupAutologin_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Program.Path, false);
            sw.Write(txt_username.Text.ToString() + "€" + txt_password.Text.ToString());
            sw.Close();
            Program.UpdateDat();
        }
    }
}
