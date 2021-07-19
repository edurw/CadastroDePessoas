using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEmDupla2CadastroDePessoas.Models
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
        public string RG { get; set; }

        public PessoaFisica(string cpf, string rg)
        {
            this.CPF = cpf;
            this.RG = rg;
        }
        public PessoaFisica()
        {

        }
        public override string ToString()
        {
            return $"Nome: {Nome}   Data de Nascimento: {DataDeNascimento}   Endereço: {Endereco}   CPF: {CPF}   RG: {RG}";
        }
    }
}
