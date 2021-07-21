using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEmDupla2CadastroDePessoas.Models
{
    public class PessoaJuridica : Pessoa
    {
        public string IE { get; set; }
        public string CNPJ { get; set; }

        public PessoaJuridica(int id, string nome, DateTime dataDeNascimento, Endereco endereco, string ie, string cnpj)
        {
            this.ID = id;
            this.Nome = nome;
            this.DataDeNascimento = dataDeNascimento;
            this.Endereco = endereco;
            this.IE = ie;
            this.CNPJ = cnpj;
        }
        public PessoaJuridica()
        {

        }
        public override string ToString()
        {
            return $"PESSOA ID: {ID}\n====================================================\nNome: { Nome}\nData de Nascimento: { DataDeNascimento.ToShortDateString()}\nEndereço:\n   CEP: { Endereco.CEP}\n   Cidade: { Endereco.Cidade}\n   Bairro: { Endereco.Bairro}\n   Rua: { Endereco.Rua}\n   Número da Residência: { Endereco.NumeroResidencia}\n   Complemento: { Endereco.Complemento}\nIE: {IE}\nCNPJ: {CNPJ}";
        }
    }
}
