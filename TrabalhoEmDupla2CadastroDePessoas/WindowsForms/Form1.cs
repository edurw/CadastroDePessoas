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
        }


        private void MudaJuridica()
        {
            LbCPF.Text = "CNPJ:";
            LbRG.Text = "IE:";
            LbData.Text = "Data de Fundação:";
            LbTitulo.Text = "Cadastro de Pessoa Juridica";
            tipoPessoa = true;
            exibir();
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
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (tipoPessoa) //se for juridica...
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
                pj.ID = pessoasJ.Count + 1;
                pessoasJ.Add(pj);
                exibir();
            }
            else           //se for fisica...
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
                pf.ID = pessoasF.Count + 1;
                pessoasF.Add(pf);
                exibir();
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

            }
            else           //se for fisica...
            {

            }
        }

        private void DGListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
