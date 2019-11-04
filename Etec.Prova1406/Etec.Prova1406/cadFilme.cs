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
    public partial class cadFilme : Form
    {
        public cadFilme()
        {
            InitializeComponent();
        }

        private void cadFilme_Load(object sender, EventArgs e)
        {
            try
            {
                DAO.Generica banco = new DAO.Generica();
                dgvFilme.DataSource = banco.retornarFilmes();
            }
            catch
            {
                MessageBox.Show("Erro na conexão!");
                this.Hide();
            }
            
        }
    }
}
