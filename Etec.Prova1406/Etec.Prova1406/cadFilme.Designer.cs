namespace Etec.Prova1406
{
    partial class cadFilme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDire = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dgvFilme = new System.Windows.Forms.DataGridView();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilme)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Filmes";
            // 
            // txtNm
            // 
            this.txtNm.Location = new System.Drawing.Point(20, 57);
            this.txtNm.MaxLength = 40;
            this.txtNm.Name = "txtNm";
            this.txtNm.Size = new System.Drawing.Size(183, 20);
            this.txtNm.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Classificação*:";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(20, 107);
            this.txtClass.MaxLength = 2;
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(86, 20);
            this.txtClass.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Categoria*:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Duração*:";
            // 
            // txtDura
            // 
            this.txtDura.Location = new System.Drawing.Point(20, 153);
            this.txtDura.MaxLength = 8;
            this.txtDura.Name = "txtDura";
            this.txtDura.Size = new System.Drawing.Size(86, 20);
            this.txtDura.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ano*:";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(117, 153);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(86, 20);
            this.txtAno.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Diretor*:";
            // 
            // txtDire
            // 
            this.txtDire.Location = new System.Drawing.Point(20, 195);
            this.txtDire.Name = "txtDire";
            this.txtDire.Size = new System.Drawing.Size(183, 20);
            this.txtDire.TabIndex = 12;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(20, 230);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(183, 23);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(20, 259);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(183, 23);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(20, 288);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(183, 23);
            this.btnDeletar.TabIndex = 15;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(20, 317);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(183, 23);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // dgvFilme
            // 
            this.dgvFilme.AllowUserToAddRows = false;
            this.dgvFilme.AllowUserToDeleteRows = false;
            this.dgvFilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilme.Location = new System.Drawing.Point(219, 13);
            this.dgvFilme.Name = "dgvFilme";
            this.dgvFilme.ReadOnly = true;
            this.dgvFilme.Size = new System.Drawing.Size(267, 327);
            this.dgvFilme.TabIndex = 17;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "Ação",
            "Aventura",
            "Drama",
            "Ficção Científica",
            "Romance",
            "Terror",
            ""});
            this.cboCategoria.Location = new System.Drawing.Point(117, 106);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(86, 21);
            this.cboCategoria.TabIndex = 6;
            // 
            // cadFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 357);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.dgvFilme);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDire);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNm);
            this.Controls.Add(this.label1);
            this.Name = "cadFilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Filmes";
            this.Load += new System.EventHandler(this.cadFilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDire;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dgvFilme;
        private System.Windows.Forms.ComboBox cboCategoria;
    }
}