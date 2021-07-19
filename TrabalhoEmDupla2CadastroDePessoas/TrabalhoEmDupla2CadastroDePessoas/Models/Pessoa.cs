using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEmDupla2CadastroDePessoas.Models
{
    public class Pessoa
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public Endereco Endereco { get; set; }

        public Pessoa(int id,  string nome, DateTime dataDeNascimento, Endereco endereco)
        {
            this.ID = id;
            this.Nome = nome;
            this.DataDeNascimento = dataDeNascimento;
            this.Endereco = endereco;
        }
        public Pessoa()
        {

        }
    }
}
