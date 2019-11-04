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

        private bool ValidarCampoData(string campoValidar, string nomeCampo)
        {
            try
            {
                DateTime.Parse(campoValidar);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Campo " + nomeCampo + " Inválido!");
                return false;
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

        private void cadFilme_Load(object sender, EventArgs e)
        {
            try
            {
                cboCategoria.SelectedItem = "Ação";
                DAO.Generica banco = new DAO.Generica();
                dgvFilme.DataSource = banco.retornarFilmes();
            }
            catch
            {
                MessageBox.Show("Erro na conexão!");
                this.Hide();
            }
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampoString(txtNm.Text, "Nome") == false)
            {
                txtNm.Clear();
                txtNm.Focus();
                return;
            }
            if (ValidarCampoString(txtClass.Text, "Classificação") == false)
            {
                txtClass.Clear();
                txtClass.Focus();
                return;
            }
            if (ValidarCampoNum(txtClass.Text, "Classificação") == false)
            {
                txtClass.Clear();
                txtClass.Focus();
                return;
            }
            if (ValidarCampoString(cboCategoria.Text, "Categoria") == false)
            {
                cboCategoria.SelectedItem = "Ação";
                cboCategoria.Focus();
                return;
            }
            if (ValidarCampoData(mtxtDura.Text, "Duração") == false)
            {
                mtxtDura.Clear();
                mtxtDura.Focus();
                return;
            }
            if (ValidarCampoString(txtAno.Text, "Ano") == false)
            {
                txtAno.Clear();
                txtAno.Focus();
                return;
            }
            if (ValidarCampoNum(txtAno.Text, "Ano") == false)
            {
                txtAno.Clear();
                txtAno.Focus();
                return;
            }
            if (ValidarCampoString(txtDire.Text, "Diretor") == false)
            {
                txtDire.Clear();
                txtDire.Focus();
                return;
            }
            try
            {
                DAO.Generica banco = new DAO.Generica();
                banco.cadastrarFilmes(txtNm.Text, txtClass.Text, cboCategoria.Text, mtxtDura.Text, txtAno.Text, txtDire.Text);
                MessageBox.Show("Cadastro realizado!");
                btnAlterar.Enabled = false;
                btnDeletar.Enabled = false;
                limparCampos();
                dgvFilme.DataSource = banco.retornarFilmes();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível cadastrar!");
            }
        }

        private void limparCampos()
        {
            txtNm.Clear();
            txtClass.Clear();
            cboCategoria.SelectedItem = "Ação";
            mtxtDura.Clear();
            txtAno.Clear();
            txtDire.Clear();
        }
    }
}
