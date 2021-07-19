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
            /*Console.Write("Dia: ");
            Console.Write("Mês: ");
            Console.Write("Ano: ");*/
            DateTime dataDeNascimento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Endereço:");
            Endereco endereco = CadastroEndereco();
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("RG: ");
            string rg = Console.ReadLine();

            PessoaFisica model = new PessoaFisica(nome, dataDeNascimento, endereco, cpf, rg);
        }

        public Endereco CadastroEndereco()
        {
            Endereco endereco = new Endereco();
            Console.Write("CEP: ");
            endereco.CEP = Console.ReadLine();
            Console.Write("Cidade: ");
            endereco.Cidade = Console.ReadLine();
            Console.Write("Bairro: ");
            endereco.Bairro = Console.ReadLine();
            Console.Write("Rua: ");
            endereco.Rua = Console.ReadLine();
            Console.Write("Número da Residência: ");
            endereco.NumeroResidencia = Console.ReadLine();
            Console.Write("Complemento: ");
            endereco.Complemento = Console.ReadLine();

            return endereco = new Endereco(endereco.CEP, endereco.Cidade, endereco.Bairro, endereco.Rua, endereco.NumeroResidencia, endereco.Complemento);
        }
    }
}
