using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etec.Prova1406
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você deseja sair do sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void filmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cadFilme form = new cadFilme();
                form.MdiParent = this;
                form.Show();
            }
            catch
            {

            }
            
        }

        private void sessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cadSessao form = new cadSessao();
                form.MdiParent = this;
                form.Show();
            }
            catch
            {

            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Today.ToShortDateString() + " | " + DateTime.Now.ToLongTimeString();
        }
    }
}
