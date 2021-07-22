
namespace WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LbTitulo = new System.Windows.Forms.Label();
            this.RdFisica = new System.Windows.Forms.RadioButton();
            this.RdJuridica = new System.Windows.Forms.RadioButton();
            this.CmpNome = new System.Windows.Forms.TextBox();
            this.CmpCPF = new System.Windows.Forms.TextBox();
            this.CmpRG = new System.Windows.Forms.TextBox();
            this.CmpCidade = new System.Windows.Forms.TextBox();
            this.CmpBairro = new System.Windows.Forms.TextBox();
            this.CmpRua = new System.Windows.Forms.TextBox();
            this.CmpComplemento = new System.Windows.Forms.TextBox();
            this.CmpCEP = new System.Windows.Forms.TextBox();
            this.DGListar = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF_CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG_IE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.LbNome = new System.Windows.Forms.Label();
            this.LbData = new System.Windows.Forms.Label();
            this.LbCPF = new System.Windows.Forms.Label();
            this.LbCidade = new System.Windows.Forms.Label();
            this.LbRG = new System.Windows.Forms.Label();
            this.LbBairro = new System.Windows.Forms.Label();
            this.LbRua = new System.Windows.Forms.Label();
            this.LbNum = new System.Windows.Forms.Label();
            this.LbComplemento = new System.Windows.Forms.Label();
            this.LbCEP = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.CmpData = new System.Windows.Forms.DateTimePicker();
            this.CmpNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DGListar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmpNum)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.Location = new System.Drawing.Point(173, 29);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(342, 39);
            this.LbTitulo.TabIndex = 0;
            this.LbTitulo.Text = "Cadastro de Pessoas";
            this.LbTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RdFisica
            // 
            this.RdFisica.AutoSize = true;
            this.RdFisica.Location = new System.Drawing.Point(301, 95);
            this.RdFisica.Name = "RdFisica";
            this.RdFisica.Size = new System.Drawing.Size(52, 17);
            this.RdFisica.TabIndex = 1;
            this.RdFisica.TabStop = true;
            this.RdFisica.Text = "Fisica";
            this.RdFisica.UseVisualStyleBackColor = true;
            this.RdFisica.CheckedChanged += new System.EventHandler(this.RdFisica_CheckedChanged);
            // 
            // RdJuridica
            // 
            this.RdJuridica.AutoSize = true;
            this.RdJuridica.Location = new System.Drawing.Point(388, 95);
            this.RdJuridica.Name = "RdJuridica";
            this.RdJuridica.Size = new System.Drawing.Size(61, 17);
            this.RdJuridica.TabIndex = 2;
            this.RdJuridica.TabStop = true;
            this.RdJuridica.Text = "Juridica";
            this.RdJuridica.UseVisualStyleBackColor = true;
            this.RdJuridica.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // CmpNome
            // 
            this.CmpNome.AccessibleDescription = "";
            this.CmpNome.AccessibleName = "";
            this.CmpNome.Location = new System.Drawing.Point(111, 160);
            this.CmpNome.Name = "CmpNome";
            this.CmpNome.Size = new System.Drawing.Size(301, 20);
            this.CmpNome.TabIndex = 3;
            this.CmpNome.Tag = "";
            // 
            // CmpCPF
            // 
            this.CmpCPF.Location = new System.Drawing.Point(111, 212);
            this.CmpCPF.Name = "CmpCPF";
            this.CmpCPF.Size = new System.Drawing.Size(301, 20);
            this.CmpCPF.TabIndex = 5;
            this.CmpCPF.Tag = "";
            // 
            // CmpRG
            // 
            this.CmpRG.Location = new System.Drawing.Point(111, 238);
            this.CmpRG.Name = "CmpRG";
            this.CmpRG.Size = new System.Drawing.Size(301, 20);
            this.CmpRG.TabIndex = 6;
            // 
            // CmpCidade
            // 
            this.CmpCidade.Location = new System.Drawing.Point(111, 264);
            this.CmpCidade.Name = "CmpCidade";
            this.CmpCidade.Size = new System.Drawing.Size(301, 20);
            this.CmpCidade.TabIndex = 7;
            // 
            // CmpBairro
            // 
            this.CmpBairro.Location = new System.Drawing.Point(111, 290);
            this.CmpBairro.Name = "CmpBairro";
            this.CmpBairro.Size = new System.Drawing.Size(301, 20);
            this.CmpBairro.TabIndex = 8;
            // 
            // CmpRua
            // 
            this.CmpRua.Location = new System.Drawing.Point(111, 316);
            this.CmpRua.Name = "CmpRua";
            this.CmpRua.Size = new System.Drawing.Size(301, 20);
            this.CmpRua.TabIndex = 9;
            // 
            // CmpComplemento
            // 
            this.CmpComplemento.Location = new System.Drawing.Point(111, 368);
            this.CmpComplemento.Name = "CmpComplemento";
            this.CmpComplemento.Size = new System.Drawing.Size(301, 20);
            this.CmpComplemento.TabIndex = 12;
            // 
            // CmpCEP
            // 
            this.CmpCEP.Location = new System.Drawing.Point(111, 394);
            this.CmpCEP.Name = "CmpCEP";
            this.CmpCEP.Size = new System.Drawing.Size(301, 20);
            this.CmpCEP.TabIndex = 13;
            // 
            // DGListar
            // 
            this.DGListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGListar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Data,
            this.CPF_CNPJ,
            this.RG_IE,
            this.Cidade,
            this.Bairro,
            this.Rua,
            this.Numero,
            this.Complemento,
            this.CEP});
            this.DGListar.Location = new System.Drawing.Point(457, 160);
            this.DGListar.MultiSelect = false;
            this.DGListar.Name = "DGListar";
            this.DGListar.ReadOnly = true;
            this.DGListar.Size = new System.Drawing.Size(337, 254);
            this.DGListar.TabIndex = 18;
            this.DGListar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGListar_CellMouseClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // CPF_CNPJ
            // 
            this.CPF_CNPJ.HeaderText = "CPF/CNPJ";
            this.CPF_CNPJ.Name = "CPF_CNPJ";
            this.CPF_CNPJ.ReadOnly = true;
            // 
            // RG_IE
            // 
            this.RG_IE.HeaderText = "RG/IE";
            this.RG_IE.Name = "RG_IE";
            this.RG_IE.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // Bairro
            // 
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            // 
            // Rua
            // 
            this.Rua.HeaderText = "Rua";
            this.Rua.Name = "Rua";
            this.Rua.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Complemento
            // 
            this.Complemento.HeaderText = "Complemento";
            this.Complemento.Name = "Complemento";
            this.Complemento.ReadOnly = true;
            // 
            // CEP
            // 
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            // 
            // LbNome
            // 
            this.LbNome.AutoSize = true;
            this.LbNome.Location = new System.Drawing.Point(4, 167);
            this.LbNome.Name = "LbNome";
            this.LbNome.Size = new System.Drawing.Size(38, 13);
            this.LbNome.TabIndex = 14;
            this.LbNome.Text = "Nome:";
            this.LbNome.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // LbData
            // 
            this.LbData.AutoSize = true;
            this.LbData.Location = new System.Drawing.Point(4, 193);
            this.LbData.Name = "LbData";
            this.LbData.Size = new System.Drawing.Size(92, 13);
            this.LbData.TabIndex = 15;
            this.LbData.Text = "Data Nascimento:";
            this.LbData.Click += new System.EventHandler(this.label3_Click);
            // 
            // LbCPF
            // 
            this.LbCPF.AutoSize = true;
            this.LbCPF.Location = new System.Drawing.Point(4, 219);
            this.LbCPF.Name = "LbCPF";
            this.LbCPF.Size = new System.Drawing.Size(30, 13);
            this.LbCPF.TabIndex = 14;
            this.LbCPF.Text = "CPF:";
            this.LbCPF.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // LbCidade
            // 
            this.LbCidade.AutoSize = true;
            this.LbCidade.Location = new System.Drawing.Point(4, 271);
            this.LbCidade.Name = "LbCidade";
            this.LbCidade.Size = new System.Drawing.Size(43, 13);
            this.LbCidade.TabIndex = 14;
            this.LbCidade.Text = "Cidade:";
            this.LbCidade.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // LbRG
            // 
            this.LbRG.AutoSize = true;
            this.LbRG.Location = new System.Drawing.Point(4, 245);
            this.LbRG.Name = "LbRG";
            this.LbRG.Size = new System.Drawing.Size(26, 13);
            this.LbRG.TabIndex = 15;
            this.LbRG.Text = "RG:";
            this.LbRG.Click += new System.EventHandler(this.label6_Click);
            // 
            // LbBairro
            // 
            this.LbBairro.AutoSize = true;
            this.LbBairro.Location = new System.Drawing.Point(4, 297);
            this.LbBairro.Name = "LbBairro";
            this.LbBairro.Size = new System.Drawing.Size(37, 13);
            this.LbBairro.TabIndex = 14;
            this.LbBairro.Text = "Bairro:";
            this.LbBairro.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // LbRua
            // 
            this.LbRua.AutoSize = true;
            this.LbRua.Location = new System.Drawing.Point(4, 323);
            this.LbRua.Name = "LbRua";
            this.LbRua.Size = new System.Drawing.Size(30, 13);
            this.LbRua.TabIndex = 14;
            this.LbRua.Text = "Rua:";
            this.LbRua.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // LbNum
            // 
            this.LbNum.AutoSize = true;
            this.LbNum.Location = new System.Drawing.Point(4, 349);
            this.LbNum.Name = "LbNum";
            this.LbNum.Size = new System.Drawing.Size(47, 13);
            this.LbNum.TabIndex = 14;
            this.LbNum.Text = "Numero:";
            this.LbNum.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // LbComplemento
            // 
            this.LbComplemento.AutoSize = true;
            this.LbComplemento.Location = new System.Drawing.Point(4, 375);
            this.LbComplemento.Name = "LbComplemento";
            this.LbComplemento.Size = new System.Drawing.Size(74, 13);
            this.LbComplemento.TabIndex = 14;
            this.LbComplemento.Text = "Complemento:";
            this.LbComplemento.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // LbCEP
            // 
            this.LbCEP.AutoSize = true;
            this.LbCEP.Location = new System.Drawing.Point(4, 401);
            this.LbCEP.Name = "LbCEP";
            this.LbCEP.Size = new System.Drawing.Size(31, 13);
            this.LbCEP.TabIndex = 14;
            this.LbCEP.Text = "CEP:";
            this.LbCEP.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(111, 420);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 16;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Location = new System.Drawing.Point(208, 420);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(75, 23);
            this.BtnDeletar.TabIndex = 17;
            this.BtnDeletar.Text = "Deletar";
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(321, 420);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(91, 23);
            this.BtnLimpar.TabIndex = 17;
            this.BtnLimpar.Text = "Limpar campos";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // CmpData
            // 
            this.CmpData.Location = new System.Drawing.Point(111, 187);
            this.CmpData.Name = "CmpData";
            this.CmpData.Size = new System.Drawing.Size(301, 20);
            this.CmpData.TabIndex = 19;
            // 
            // CmpNum
            // 
            this.CmpNum.Location = new System.Drawing.Point(111, 342);
            this.CmpNum.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.CmpNum.Name = "CmpNum";
            this.CmpNum.Size = new System.Drawing.Size(301, 20);
            this.CmpNum.TabIndex = 11;
            // 
            // Form1
            // 
            this.AccessibleName = "teste";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.CmpNum);
            this.Controls.Add(this.CmpData);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.LbRG);
            this.Controls.Add(this.LbCEP);
            this.Controls.Add(this.LbComplemento);
            this.Controls.Add(this.LbNum);
            this.Controls.Add(this.LbRua);
            this.Controls.Add(this.LbBairro);
            this.Controls.Add(this.LbCidade);
            this.Controls.Add(this.LbData);
            this.Controls.Add(this.LbCPF);
            this.Controls.Add(this.LbNome);
            this.Controls.Add(this.DGListar);
            this.Controls.Add(this.CmpCEP);
            this.Controls.Add(this.CmpComplemento);
            this.Controls.Add(this.CmpRua);
            this.Controls.Add(this.CmpBairro);
            this.Controls.Add(this.CmpCidade);
            this.Controls.Add(this.CmpRG);
            this.Controls.Add(this.CmpCPF);
            this.Controls.Add(this.CmpNome);
            this.Controls.Add(this.RdJuridica);
            this.Controls.Add(this.RdFisica);
            this.Controls.Add(this.LbTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGListar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmpNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.RadioButton RdFisica;
        private System.Windows.Forms.RadioButton RdJuridica;
        private System.Windows.Forms.TextBox CmpNome;
        private System.Windows.Forms.TextBox CmpCPF;
        private System.Windows.Forms.TextBox CmpRG;
        private System.Windows.Forms.TextBox CmpCidade;
        private System.Windows.Forms.TextBox CmpBairro;
        private System.Windows.Forms.TextBox CmpRua;
        private System.Windows.Forms.TextBox CmpComplemento;
        private System.Windows.Forms.TextBox CmpCEP;
        private System.Windows.Forms.DataGridView DGListar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label LbNome;
        private System.Windows.Forms.Label LbData;
        private System.Windows.Forms.Label LbCPF;
        private System.Windows.Forms.Label LbCidade;
        private System.Windows.Forms.Label LbRG;
        private System.Windows.Forms.Label LbBairro;
        private System.Windows.Forms.Label LbRua;
        private System.Windows.Forms.Label LbNum;
        private System.Windows.Forms.Label LbComplemento;
        private System.Windows.Forms.Label LbCEP;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.DateTimePicker CmpData;
        private System.Windows.Forms.NumericUpDown CmpNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF_CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG_IE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
    }
}

