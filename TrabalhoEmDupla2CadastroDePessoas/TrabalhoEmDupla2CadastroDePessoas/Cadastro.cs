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
        List<PessoaFisica> listaPF = new List<PessoaFisica>();
        List<PessoaJuridica> listaPJ = new List<PessoaJuridica>();
        int idPF = 0;
        int idPJ = 0;
        public void CadastroPessoaFisica()
        {
            idPF++;
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
            Endereco endereco = CadastroEndereco();
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("RG: ");
            string rg = Console.ReadLine();
            PessoaFisica model = new PessoaFisica(idPF, nome, dataDeNascimento, endereco, cpf, rg);
            listaPF.Add(model);
        }
        public void CadastroPessoaJuridica()
        {
            idPJ++;
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
            Endereco endereco = CadastroEndereco();
            Console.Write("CNPJ: ");
            string cnpj = Console.ReadLine();
            Console.Write("IE: ");
            string ie = Console.ReadLine();
            PessoaJuridica model = new PessoaJuridica(idPJ, nome, dataDeNascimento, endereco, cnpj, ie);
            listaPJ.Add(model);
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

        public void MostrarPF()
        {
            foreach (PessoaFisica item in listaPF)
            {
                Console.WriteLine(item);
            }
        }
        public void MostrarPJ()
        {
            foreach (PessoaJuridica item in listaPJ)
            {
                Console.WriteLine(item);
            }
        }
    }
}
