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

        public PessoaJuridica(string ie, string cnpj)
        {
            this.IE = ie;
            this.CNPJ = ie;
        }
        public PessoaJuridica()
        {

        }
        public override string ToString()
        {
            return $"Nome: {Nome}   Data de Nascimento: {DataDeNascimento}   Endereço: {Endereco}   IE: {IE}   CNPJ: {CNPJ}";
        }
    }
}
