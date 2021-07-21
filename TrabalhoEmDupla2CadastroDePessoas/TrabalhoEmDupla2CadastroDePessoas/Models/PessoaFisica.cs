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

        public PessoaFisica(int id, string nome, DateTime dataDeNascimento, Endereco endereco, string cpf, string rg)
        {
            this.ID = id;
            this.Nome = nome;
            this.DataDeNascimento = dataDeNascimento;
            this.Endereco = endereco;
            this.CPF = cpf;
            this.RG = rg;
        }
        public PessoaFisica()
        {

        }
        public override string ToString()
        {
            return $"PESSOA ID: {ID}\n====================================================\n   Nome: {Nome}\n   Data de Nascimento: {DataDeNascimento.ToShortDateString()}\n   Endereço:\n      CEP: {Endereco.CEP}\n      Cidade: {Endereco.Cidade}\n      Bairro: {Endereco.Bairro}\n      Rua: {Endereco.Rua}\n      Número da Residência: {Endereco.NumeroResidencia}\n      Complemento: {Endereco.Complemento}\n   CPF: {CPF}\n   RG: {RG}\n====================================================";
        }
    }
}
