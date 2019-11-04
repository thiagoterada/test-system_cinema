using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                dgvFilme.DataSource = banco.retornarFilmes();
                if (Directory.Exists(@"C:\Cinema") == false)
                {
                    Directory.CreateDirectory(@"C:\Cinema");
                }
                using (StreamWriter arquivoTexto = new StreamWriter(@"C:\Cinema\Filmes.txt", true))
                {
                    arquivoTexto.WriteLine("-- Iniciando Log -- ");
                    arquivoTexto.WriteLine(DateTime.Today.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString());
                    arquivoTexto.WriteLine("Usuário efetuou um cadastro de Filme:");
                    arquivoTexto.WriteLine("Nome: " + txtNm.Text);
                    arquivoTexto.WriteLine("Classificação: " + txtClass.Text);
                    arquivoTexto.WriteLine("Categoria: " + cboCategoria.Text);
                    arquivoTexto.WriteLine("Duração: " + mtxtDura.Text);
                    arquivoTexto.WriteLine("Ano: " + txtAno.Text);
                    arquivoTexto.WriteLine("Diretor: " + txtDire.Text);
                    arquivoTexto.WriteLine("-- Término Log --");
                    arquivoTexto.WriteLine(" ");
                }
                limparCampos();

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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void dgvFilme_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DAO.Generica banco = new DAO.Generica();
                lblId.Text = dgvFilme.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txtNm.Text = dgvFilme.Rows[e.RowIndex].Cells["NOME"].Value.ToString();
                txtClass.Text = dgvFilme.Rows[e.RowIndex].Cells["CLASSIFICACAO"].Value.ToString();
                cboCategoria.SelectedItem = dgvFilme.Rows[e.RowIndex].Cells["CATEGORIA"].Value.ToString();
                mtxtDura.Text = dgvFilme.Rows[e.RowIndex].Cells["DURACAO"].Value.ToString();
                txtAno.Text = dgvFilme.Rows[e.RowIndex].Cells["ANO"].Value.ToString();
                txtDire.Text = dgvFilme.Rows[e.RowIndex].Cells["DIRETOR"].Value.ToString();
                btnAlterar.Enabled = true;
                btnDeletar.Enabled = true;
            }
            catch
            {

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
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
                banco.atualizarFilmes(lblId.Text, txtNm.Text, txtClass.Text, cboCategoria.Text, mtxtDura.Text, txtAno.Text, txtDire.Text);
                MessageBox.Show("Atualização realizada!");
                btnAlterar.Enabled = false;
                btnDeletar.Enabled = false;
                dgvFilme.DataSource = banco.retornarFilmes();
                using (StreamWriter arquivoTexto = new StreamWriter(@"C:\Cinema\Filmes.txt", true))
                {
                    arquivoTexto.WriteLine("-- Iniciando Log -- ");
                    arquivoTexto.WriteLine(DateTime.Today.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString());
                    arquivoTexto.WriteLine("Usuário efetuou uma atualização de Filme:");
                    arquivoTexto.WriteLine("ID: " + lblId.Text);
                    arquivoTexto.WriteLine("Nome: " + txtNm.Text);
                    arquivoTexto.WriteLine("Classificação: " + txtClass.Text);
                    arquivoTexto.WriteLine("Categoria: " + cboCategoria.Text);
                    arquivoTexto.WriteLine("Duração: " + mtxtDura.Text);
                    arquivoTexto.WriteLine("Ano: " + txtAno.Text);
                    arquivoTexto.WriteLine("Diretor: " + txtDire.Text);
                    arquivoTexto.WriteLine("-- Término Log --");
                    arquivoTexto.WriteLine(" ");
                }
                limparCampos();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível atualizar!");
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você realmente deseja deletar?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DAO.Generica banco = new DAO.Generica();
                    banco.deletarFilmes(lblId.Text);
                    MessageBox.Show("O registro foi deletado!");
                    btnAlterar.Enabled = false;
                    btnDeletar.Enabled = false;
                    using (StreamWriter arquivoTexto = new StreamWriter(@"C:\Cinema\Filmes.txt", true))
                    {
                        int id = int.Parse(lblId.Text);
                        arquivoTexto.WriteLine("-- Iniciando Log -- ");
                        arquivoTexto.WriteLine(DateTime.Today.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString());
                        arquivoTexto.WriteLine("Usuário deletou o seguinte registro de Filme:");
                        arquivoTexto.WriteLine("ID: " + lblId.Text);
                        arquivoTexto.WriteLine("-- Término Log --");
                        arquivoTexto.WriteLine(" ");
                    }
                    limparCampos();
                    dgvFilme.DataSource = banco.retornarFilmes();

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não foi possível deletar!");
                }
            }
        }
    }
}
