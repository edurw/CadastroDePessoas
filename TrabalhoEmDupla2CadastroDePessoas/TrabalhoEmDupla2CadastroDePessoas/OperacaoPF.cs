using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoEmDupla2CadastroDePessoas.Models;

namespace TrabalhoEmDupla2CadastroDePessoas
{
    public  class OperacaoPF : Crud
    {

        public OperacaoPF()
        {
            this.CreateOperacao = Cadastrar;
            this.ReadOperacao = Listar;
            this.UpdateOperacao = Alterar;
            this.DeleteOperacao = Deletar;
        }

        private void Alterar()
        {
            Console.WriteLine("selecione o id da pessoa a alterar");
            Listar();
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (PessoaFisica item in lista)
            {
                if (item.ID == id)
                {
                    Console.WriteLine("Pessoa Encontrada");
                    Console.Write("Nome: ");
                    item.Nome = Console.ReadLine();
                    Console.Write("Data de Nascimento:\n");
                    Console.Write("   Dia: ");
                    int Dia = Convert.ToInt32(Console.ReadLine());
                    Console.Write("   Mês: ");
                    int Mes = Convert.ToInt32(Console.ReadLine());
                    Console.Write("   Ano: ");
                    int Ano = Convert.ToInt32(Console.ReadLine());
                    item.DataDeNascimento = new DateTime(Ano, Mes, Dia);
                    Console.WriteLine("Endereço:");
                    Endereco endereco = OperacoesEndereco.CadastroEndereco();
                    item.Endereco = endereco;
                    Console.Write("CPF: ");
                    item.CPF = Console.ReadLine();
                    Console.Write("RG: ");
                    item.RG = Console.ReadLine();

                }
            }

        }

        public  void Cadastrar()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Data de Nascimento:\n");
            Console.Write("   Dia: ");
            int Dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("   Mês: ");
            int Mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("   Ano: ");
            int Ano = Convert.ToInt32(Console.ReadLine());
            DateTime dataDeNascimento = new DateTime(Ano, Mes, Dia);
            Console.WriteLine("Endereço:");
            Endereco endereco = OperacoesEndereco.CadastroEndereco();
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("RG: ");
            string rg = Console.ReadLine();
            PessoaFisica model = new PessoaFisica(lista.Count()+1, nome, dataDeNascimento, endereco, cpf, rg);
            lista.Add(model);
        }

        public  void Listar()
        {
            foreach (PessoaFisica item in lista)
            {
                Console.WriteLine(item);
            }
        }
        public void Deletar()
        {
            Console.WriteLine("selecione o id da pessoa a deletar");
            Listar();
            int id = Convert.ToInt32(Console.ReadLine());
            lista.Remove(FindById(id));
        }
        public PessoaFisica FindById(int Id)
        {
            foreach (PessoaFisica item in lista)
            {
                if (item.ID == Id)
                {
                    Console.WriteLine("Pessoa Encontrada");
                    return item;
                }
            }
            Console.WriteLine("Pessoa Nao Encontrada");
            return null;
        }
    }
}
