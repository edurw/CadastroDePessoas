using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
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
            LimparCampos();
            ListarFisica();
        }


        private void MudaJuridica()
        {
            LbCPF.Text = "CNPJ:";
            LbRG.Text = "IE:";
            LbData.Text = "Data de Fundação:";
            LbTitulo.Text = "Cadastro de Pessoa Juridica";
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
    }
}
