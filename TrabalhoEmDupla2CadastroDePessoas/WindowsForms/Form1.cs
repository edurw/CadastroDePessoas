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
        public Form1()
        {
            InitializeComponent();
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
            ListarFisica();
        }


        private void MudaJuridica()
        {
            LbCPF.Text = "CNPJ:";
            LbRG.Text = "IE:";
            LbData.Text = "Data de Fundação:";
            LbTitulo.Text = "Cadastro de Pessoa Juridica";
            tipoPessoa = true;
            LimparCampos();
            ListarJuridica();
        }
        private void ListarFisica()
        {
            //throw new NotImplementedException();
        }

        private void ListarJuridica()
        {
            //throw new NotImplementedException();
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
                pj.CNPJ = CmpNome.Text;
                pj.IE = CmpRG.Text;
                Endereco endereco = new Endereco();
                endereco.Cidade = CmpCidade.Text;
                endereco.Bairro = CmpBairro.Text;
                endereco.Rua = CmpRua.Text;
                endereco.NumeroResidencia = CmpNum.Text;
                endereco.Complemento = CmpCidade.Text;
                endereco.CEP = CmpCEP.Text;
                pj.Endereco = endereco;
                Crud
                


            }
            else           //se for fisica...
            {

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
