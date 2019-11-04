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
    public partial class cadSessao : Form
    {
        public cadSessao()
        {
            InitializeComponent();
        }

        private bool ValidarCampoString(string campoValidar, string nomeCampo)
        {
            if (campoValidar == "")
            {
                MessageBox.Show("Campo " + nomeCampo + " Inválido!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidarCampoNum(string campoValidar, string nomeCampo)
        {
            try
            {
                int.Parse(campoValidar);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Campo " + nomeCampo + " Inválido!");
                return false;
            }
        }

        private void cadSessao_Load(object sender, EventArgs e)
        {
            try
            {
                cboTipoSessao.SelectedItem = "2D";
                DAO.Generica banco = new DAO.Generica();
                dgvSessao.DataSource = banco.retornarSessoes();
                cboFilme.ValueMember = "idFilme";
                cboFilme.DisplayMember = "nm";
                cboFilme.DataSource = banco.retornarFilmesCombo();
            }
            catch
            {
                MessageBox.Show("Erro na conexão!");
                this.Hide();
            }
        }
    }
}
