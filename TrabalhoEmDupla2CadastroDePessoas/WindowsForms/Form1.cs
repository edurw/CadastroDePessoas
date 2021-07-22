using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoEmDupla2CadastroDePessoas.Models;
using TrabalhoEmDupla2CadastroDePessoas;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        bool tipoPessoa = false; //false= fisica, true=juridica
        public List<PessoaFisica> pessoasF = new List<PessoaFisica>();
        public List<PessoaJuridica> pessoasJ = new List<PessoaJuridica>();
        private static int idBackup=0;
        private static int idAtual = 1;
        private static Pessoa PessoaSelect =null;
        public Form1()
        {
            InitializeComponent();
            DGListar.AutoGenerateColumns = false;
            DGListar.AllowUserToAddRows = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MudaJuridica();
        }

        private void RdFisica_CheckedChanged(object sender, EventArgs e)
        {
            MudaFisica();
        }

        private void MudaFisica()
        {
            LbCPF.Text="CPF:";
            LbRG.Text = "RG:";
            LbData.Text = "Data de Nascimento:";
            LbTitulo.Text = "Cadastro de Pessoa Fisica";
            tipoPessoa = false;
            LimparCampos();
            exibir();
            LimparCampos();
        }


        private void MudaJuridica()
        {
            LbCPF.Text = "CNPJ:";
            LbRG.Text = "IE:";
            LbData.Text = "Data de Fundação:";
            LbTitulo.Text = "Cadastro de Pessoa Juridica";
            tipoPessoa = true;
            exibir();
            LimparCampos();
        }


        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();  
        }
        private void LimparCampos() 
        {
            CmpNome.Text = "";
            CmpData.Text = "";
            CmpCPF.Text = "";
            CmpRG.Text = "";
            CmpCidade.Text = "";
            CmpBairro.Text = "";
            CmpRua.Text = "";
            CmpComplemento.Text = "";
            CmpNum.Text = "";
            CmpCEP.Text = "";
            idBackup = 0;
            PessoaSelect = null;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (tipoPessoa) //se for juridica...
            {
                if (idBackup != 0)//alterar registro
                {
                    pessoasJ.Remove((PessoaJuridica)PessoaSelect);
                    PessoaJuridica pj = new PessoaJuridica();
                    pj.Nome = CmpNome.Text;
                    pj.DataDeNascimento = CmpData.Value;
                    pj.CNPJ = CmpCPF.Text;
                    pj.IE = CmpRG.Text;
                    Endereco endereco = new Endereco();
                    endereco.Cidade = CmpCidade.Text;
                    endereco.Bairro = CmpBairro.Text;
                    endereco.Rua = CmpRua.Text;
                    endereco.NumeroResidencia = CmpNum.Text;
                    endereco.Complemento = CmpComplemento.Text;
                    endereco.CEP = CmpCEP.Text;
                    pj.Endereco = endereco;
                    pj.ID = idBackup;
                    idBackup = 0;
                    pessoasJ.Add(pj);
                    exibir();
                    LimparCampos();
                }
                else //registro novo
                {

                PessoaJuridica pj = new PessoaJuridica();
                pj.Nome = CmpNome.Text;
                pj.DataDeNascimento = CmpData.Value;
                pj.CNPJ = CmpCPF.Text;
                pj.IE = CmpRG.Text;
                Endereco endereco = new Endereco();
                endereco.Cidade = CmpCidade.Text;
                endereco.Bairro = CmpBairro.Text;
                endereco.Rua = CmpRua.Text;
                endereco.NumeroResidencia = CmpNum.Text;
                endereco.Complemento = CmpComplemento.Text;
                endereco.CEP = CmpCEP.Text;
                pj.Endereco = endereco;
                pj.ID = idAtual;
                idAtual++;
                pessoasJ.Add(pj);
                exibir();
                LimparCampos();
                }
            }
            else           //se for fisica...
            {
                if (idBackup != 0)//registro alterar
                {
                    pessoasF.Remove((PessoaFisica)PessoaSelect);
                    PessoaFisica pf = new PessoaFisica();
                    pf.Nome = CmpNome.Text;
                    pf.DataDeNascimento = CmpData.Value;
                    pf.CPF = CmpCPF.Text;
                    pf.RG = CmpRG.Text;
                    Endereco endereco = new Endereco();
                    endereco.Cidade = CmpCidade.Text;
                    endereco.Bairro = CmpBairro.Text;
                    endereco.Rua = CmpRua.Text;
                    endereco.NumeroResidencia = CmpNum.Text;
                    endereco.Complemento = CmpComplemento.Text;
                    endereco.CEP = CmpCEP.Text;
                    pf.Endereco = endereco;
                    pf.ID = idBackup;
                    idBackup = 0;
                    pessoasF.Add(pf);
                    exibir();
                    LimparCampos();
                }
                else //registro novo
                {
                    
                PessoaFisica pf = new PessoaFisica();
                pf.Nome = CmpNome.Text;
                pf.DataDeNascimento = CmpData.Value;
                pf.CPF = CmpCPF.Text;
                pf.RG = CmpRG.Text;
                Endereco endereco = new Endereco();
                endereco.Cidade = CmpCidade.Text;
                endereco.Bairro = CmpBairro.Text;
                endereco.Rua = CmpRua.Text;
                endereco.NumeroResidencia = CmpNum.Text;
                endereco.Complemento = CmpComplemento.Text;
                endereco.CEP = CmpCEP.Text;
                pf.Endereco = endereco;
                pf.ID = idAtual;
                idAtual++;
                pessoasF.Add(pf);
                exibir();
                LimparCampos();
                }
            }
        }

        private void exibir() 
        {
            if (tipoPessoa) //se for juridica...
            {
                DGListar.Rows.Clear();
                foreach (PessoaJuridica pessoa in pessoasJ)
                {
                    DGListar.Rows.Add(pessoa.ID,pessoa.Nome,pessoa.DataDeNascimento, pessoa.CNPJ,pessoa.IE, pessoa.Endereco.Cidade, pessoa.Endereco.Bairro, pessoa.Endereco.Rua, pessoa.Endereco.NumeroResidencia, pessoa.Endereco.Complemento, pessoa.Endereco.CEP);
                }
                DGListar.Refresh();
            }
            else           //se for fisica...
            {
                DGListar.Rows.Clear();
                foreach (PessoaFisica pessoa in pessoasF)
                {
                    DGListar.Rows.Add(pessoa.ID, pessoa.Nome, pessoa.DataDeNascimento, pessoa.CPF, pessoa.RG, pessoa.Endereco.Cidade, pessoa.Endereco.Bairro, pessoa.Endereco.Rua, pessoa.Endereco.NumeroResidencia, pessoa.Endereco.Complemento, pessoa.Endereco.CEP);
                }
                DGListar.Refresh();
            }
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (tipoPessoa) //se for juridica...
            {
                pessoasJ.Remove((PessoaJuridica)PessoaSelect);
                LimparCampos();
                exibir();
            }
            else           //se for fisica...
            {
                pessoasF.Remove((PessoaFisica)PessoaSelect);
                LimparCampos();
                exibir();
            }
        }


        private void DGListar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int linha = e.RowIndex;

            if (tipoPessoa) //se for juridica...
            {
                if (linha >= 0)
                {

                    int id = Convert.ToInt32(this.DGListar.Rows[linha].Cells[0].Value.ToString());
                    idBackup = id;
                    PessoaJuridica pessoaJuridica =  pessoasJ.Find(pj => pj.ID == id);
                    PessoaSelect = pessoaJuridica;
                    CmpNome.Text = pessoaJuridica.Nome;
                    CmpData.Value = pessoaJuridica.DataDeNascimento;
                    CmpCPF.Text = pessoaJuridica.CNPJ;
                    CmpRG.Text = pessoaJuridica.IE;
                    CmpCidade.Text = pessoaJuridica.Endereco.Cidade;
                    CmpBairro.Text = pessoaJuridica.Endereco.Bairro;
                    CmpRua.Text = pessoaJuridica.Endereco.Rua;
                    CmpNum.Text = pessoaJuridica.Endereco.NumeroResidencia;
                    CmpComplemento.Text = pessoaJuridica.Endereco.Complemento;
                    CmpCEP.Text = pessoaJuridica.Endereco.CEP;

                }
            }
            else           //se for fisica...
            {
                if (linha >= 0)
                {

                    int id = Convert.ToInt32(this.DGListar.Rows[linha].Cells[0].Value.ToString());
                    idBackup = id;
                    PessoaFisica pessoaFisica = pessoasF.Find(pf => pf.ID == id);
                    PessoaSelect = pessoaFisica;
                    CmpNome.Text = pessoaFisica.Nome;
                    CmpData.Value = pessoaFisica.DataDeNascimento;
                    CmpCPF.Text = pessoaFisica.CPF;
                    CmpRG.Text = pessoaFisica.RG;
                    CmpCidade.Text = pessoaFisica.Endereco.Cidade;
                    CmpBairro.Text = pessoaFisica.Endereco.Bairro;
                    CmpRua.Text = pessoaFisica.Endereco.Rua;
                    CmpNum.Text = pessoaFisica.Endereco.NumeroResidencia;
                    CmpComplemento.Text = pessoaFisica.Endereco.Complemento;
                    CmpCEP.Text = pessoaFisica.Endereco.CEP;
                }
            }
            
        }
    }
}
