using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEmDupla2CadastroDePessoas.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public Endereco Endereco { get; set; }

        public Pessoa(string nome, DateTime dataDeNascimento, Endereco endereco)
        {
            this.Nome = nome;
            this.DataDeNascimento = dataDeNascimento;
            this.Endereco = endereco;
        }
        public Pessoa()
        {

        }
    }
}
