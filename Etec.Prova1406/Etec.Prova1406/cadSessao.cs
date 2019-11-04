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
    public partial class cadSessao : Form
    {
        public cadSessao()
        {
            InitializeComponent();
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

        private bool ValidarCampoDouble(string campoValidar, string nomeCampo)
        {
            try
            {
                double.Parse(campoValidar);
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
                cboFilme.SelectedValue = "1";
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampoData(mtxtHora.Text, "Hora") == false)
            {
                mtxtHora.Clear();
                mtxtHora.Focus();
                return;
            }
            if (ValidarCampoString(txtNroSala.Text, "Número Sala") == false)
            {
                txtNroSala.Clear();
                txtNroSala.Focus();
                return;
            }
            if (ValidarCampoNum(txtNroSala.Text, "Número Sala") == false)
            {
                txtNroSala.Clear();
                txtNroSala.Focus();
                return;
            }
            if (ValidarCampoString(cboFilme.Text, "Filme") == false)
            {
                cboFilme.Focus();
                return;
            }
            if (ValidarCampoString(txtCapac.Text, "Capacidade") == false)
            {
                txtCapac.Clear();
                txtCapac.Focus();
                return;
            }
            if (ValidarCampoNum(txtCapac.Text, "Capacidade") == false)
            {
                txtCapac.Clear();
                txtCapac.Focus();
                return;
            }
            if (ValidarCampoString(txtCapac.Text, "Capacidade") == false)
            {
                txtCapac.Clear();
                txtCapac.Focus();
                return;
            }
            if (ValidarCampoDouble(txtValor.Text, "Valor") == false)
            {
                txtValor.Clear();
                txtValor.Focus();
                return;
            }
            try
            {
                DAO.Generica banco = new DAO.Generica();
                banco.cadastrarSessoes(dtpData.Value, DateTime.Parse(mtxtHora.Text), txtNroSala.Text, cboFilme.SelectedValue.ToString(), txtCapac.Text, cboTipoSessao.Text, txtValor.Text);
                MessageBox.Show("Cadastro realizado!");
                btnAlterar.Enabled = false;
                btnDeletar.Enabled = false;
                using (StreamWriter arquivoTexto = new StreamWriter(@"C:\Cinema\Sessoes.txt", true))
                {
                    arquivoTexto.WriteLine("-- Iniciando Log -- ");
                    arquivoTexto.WriteLine(DateTime.Today.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString());
                    arquivoTexto.WriteLine("Usuário efetuou um cadastro de Sessão:");
                    arquivoTexto.WriteLine("Data: " + dtpData.Text);
                    arquivoTexto.WriteLine("Número Sala: " + txtNroSala.Text);
                    arquivoTexto.WriteLine("Filme: " + cboFilme.Text);
                    arquivoTexto.WriteLine("Id Filme: " + cboFilme.SelectedValue.ToString());
                    arquivoTexto.WriteLine("Capacidade: " + txtCapac.Text);
                    arquivoTexto.WriteLine("Tipo da Sessão: " + cboTipoSessao.Text);
                    arquivoTexto.WriteLine("Valor da Sessão: " + txtValor.Text);
                    arquivoTexto.WriteLine("-- Término Log --");
                    arquivoTexto.WriteLine(" ");
                }
                limparCampos();
                dgvSessao.DataSource = banco.retornarSessoes();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível cadastrar!");
            }
        }

        private void limparCampos()
        {
            dtpData.ResetText();
            mtxtHora.Clear();
            txtNroSala.Clear();
            cboFilme.SelectedValue = "1";
            txtCapac.Clear();
            cboTipoSessao.SelectedItem = "3D";
            txtValor.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void dgvSessao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DAO.Generica banco = new DAO.Generica();
                lblId.Text = dgvSessao.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                dtpData.Text = dgvSessao.Rows[e.RowIndex].Cells["DATA"].Value.ToString();
                mtxtHora.Text = dgvSessao.Rows[e.RowIndex].Cells["HORA"].Value.ToString();
                txtNroSala.Text = dgvSessao.Rows[e.RowIndex].Cells["NUMERO_SALA"].Value.ToString();
                cboFilme.SelectedValue = dgvSessao.Rows[e.RowIndex].Cells["ID_FILME"].Value.ToString();
                txtCapac.Text = dgvSessao.Rows[e.RowIndex].Cells["CAPACIDADE"].Value.ToString();
                cboTipoSessao.SelectedItem = dgvSessao.Rows[e.RowIndex].Cells["TIPO"].Value.ToString();
                txtValor.Text = dgvSessao.Rows[e.RowIndex].Cells["VALOR"].Value.ToString();
                btnAlterar.Enabled = true;
                btnDeletar.Enabled = true;
                btnCadastrar.Enabled = false;
                btnNovo.Visible = true;
            }
            catch
            {

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarCampoData(mtxtHora.Text, "Hora") == false)
            {
                mtxtHora.Clear();
                mtxtHora.Focus();
                return;
            }
            if (ValidarCampoString(txtNroSala.Text, "Número Sala") == false)
            {
                txtNroSala.Clear();
                txtNroSala.Focus();
                return;
            }
            if (ValidarCampoNum(txtNroSala.Text, "Número Sala") == false)
            {
                txtNroSala.Clear();
                txtNroSala.Focus();
                return;
            }
            if (ValidarCampoString(cboFilme.Text, "Filme") == false)
            {
                cboFilme.Focus();
                return;
            }
            if (ValidarCampoString(txtCapac.Text, "Capacidade") == false)
            {
                txtCapac.Clear();
                txtCapac.Focus();
                return;
            }
            if (ValidarCampoNum(txtCapac.Text, "Capacidade") == false)
            {
                txtCapac.Clear();
                txtCapac.Focus();
                return;
            }
            if (ValidarCampoString(txtCapac.Text, "Capacidade") == false)
            {
                txtCapac.Clear();
                txtCapac.Focus();
                return;
            }
            if (ValidarCampoDouble(txtValor.Text, "Valor") == false)
            {
                txtValor.Clear();
                txtValor.Focus();
                return;
            }
            try
            {
                DAO.Generica banco = new DAO.Generica();
                banco.atualizarSessoes(lblId.Text, dtpData.Value, DateTime.Parse(mtxtHora.Text), txtNroSala.Text, cboFilme.SelectedValue.ToString(), txtCapac.Text, cboTipoSessao.Text, txtValor.Text);
                MessageBox.Show("Atualização realizada!");
                btnAlterar.Enabled = false;
                btnDeletar.Enabled = false;
                btnNovo.Visible = false;
                btnCadastrar.Enabled = true;
                using (StreamWriter arquivoTexto = new StreamWriter(@"C:\Cinema\Sessoes.txt", true))
                {
                    arquivoTexto.WriteLine("-- Iniciando Log -- ");
                    arquivoTexto.WriteLine(DateTime.Today.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString());
                    arquivoTexto.WriteLine("Usuário efetuou uma atualização de Sessão:");
                    arquivoTexto.WriteLine("ID: " + lblId.Text);
                    arquivoTexto.WriteLine("Data: " + dtpData.Text);
                    arquivoTexto.WriteLine("Número Sala: " + txtNroSala.Text);
                    arquivoTexto.WriteLine("Filme: " + cboFilme.Text);
                    arquivoTexto.WriteLine("Id Filme: " + cboFilme.SelectedValue.ToString());
                    arquivoTexto.WriteLine("Capacidade: " + txtCapac.Text);
                    arquivoTexto.WriteLine("Tipo da Sessão: " + cboTipoSessao.Text);
                    arquivoTexto.WriteLine("Valor da Sessão: " + txtValor.Text);
                    arquivoTexto.WriteLine("-- Término Log --");
                    arquivoTexto.WriteLine(" ");
                }
                limparCampos();
                dgvSessao.DataSource = banco.retornarSessoes();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível cadastrar!");
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
                    banco.deletarSessoes(lblId.Text);
                    MessageBox.Show("O registro foi deletado!");
                    btnAlterar.Enabled = false;
                    btnDeletar.Enabled = false;
                    btnNovo.Visible = false;
                    btnCadastrar.Enabled = true;
                    using (StreamWriter arquivoTexto = new StreamWriter(@"C:\Cinema\Sessoes.txt", true))
                    {
                        int id = int.Parse(lblId.Text);
                        arquivoTexto.WriteLine("-- Iniciando Log -- ");
                        arquivoTexto.WriteLine(DateTime.Today.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString());
                        arquivoTexto.WriteLine("Usuário deletou o seguinte registro de Sessão:");
                        arquivoTexto.WriteLine("ID: " + lblId.Text);
                        arquivoTexto.WriteLine("-- Término Log --");
                        arquivoTexto.WriteLine(" ");
                    }
                    limparCampos();
                    dgvSessao.DataSource = banco.retornarSessoes();

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não foi possível deletar!");
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparCampos();
            btnAlterar.Enabled = false;
            btnDeletar.Enabled = false;
            btnCadastrar.Enabled = true;
            btnNovo.Visible = false;
        }
    }
}
