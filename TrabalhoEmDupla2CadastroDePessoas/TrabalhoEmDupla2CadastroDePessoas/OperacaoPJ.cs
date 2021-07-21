using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoEmDupla2CadastroDePessoas.Models;

namespace TrabalhoEmDupla2CadastroDePessoas
{
    public  class OperacaoPJ : Crud
    {
        public OperacaoPJ()
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
            foreach (PessoaJuridica item in lista)
            {
                if (item.ID == id)
                {
                    Console.WriteLine("Pessoa Encontrada");
                    Console.Write("Nome: ");
                    item.Nome = Console.ReadLine();
                    Console.Write("Data de Fundação:\n");
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
                    Console.Write("CNPJ: ");
                    item.CNPJ = Console.ReadLine();
                    Console.Write("IE: ");
                    item.IE = Console.ReadLine();

                }
            }

        }

        public  void Cadastrar()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Data de Fundaçao:\n");
            Console.Write("   Dia: ");
            int Dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("   Mês: ");
            int Mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("   Ano: ");
            int Ano = Convert.ToInt32(Console.ReadLine());
            DateTime dataDeNascimento = new DateTime(Ano, Mes, Dia);
            Console.WriteLine("Endereço:");
            Endereco endereco = OperacoesEndereco.CadastroEndereco();
            Console.Write("CNPJ: ");
            string cnpj = Console.ReadLine();
            Console.Write("IE: ");
            string ie = Console.ReadLine();
            PessoaJuridica model = new PessoaJuridica(lista.Count() + 1, nome, dataDeNascimento, endereco, cnpj, ie);
            lista.Add(model);
        }

        public PessoaJuridica FindById(int Id) 
        {
            foreach (PessoaJuridica item in lista)
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

        public  void Listar()
        {
            foreach (PessoaJuridica item in lista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
        }

        public void Deletar() 
        {
            Console.WriteLine("selecione o id da pessoa a deletar");
            Listar();
            int id = Convert.ToInt32(Console.ReadLine());
            lista.Remove(FindById(id));
        }
    }
}
