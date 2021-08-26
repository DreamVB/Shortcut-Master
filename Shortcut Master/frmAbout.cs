using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Shortcut_Master
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void ExecApp(string Filename)
        {
            Process p = new Process();
            try
            {
                p.StartInfo.FileName = Filename;
                p.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {

        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExecApp("https://github.com/DreamVB/Shortcut-Master");
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
