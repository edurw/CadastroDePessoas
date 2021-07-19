using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoEmDupla2CadastroDePessoas.Models;

namespace TrabalhoEmDupla2CadastroDePessoas
{
    public class Cadastro
    {
        public void CadastroPessoaFisica()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Data de Nascimento: ");
            DateTime dataDeNascimento = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Endereço: ");
            Endereco endereco = new Endereco();

            Pessoa model = new Pessoa(nome, dataDeNascimento, endereco);
        }
    }
}
