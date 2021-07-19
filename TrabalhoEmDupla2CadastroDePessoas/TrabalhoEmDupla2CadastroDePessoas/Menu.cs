using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoEmDupla2CadastroDePessoas.Models;

namespace TrabalhoEmDupla2CadastroDePessoas
{
    class Menu
    {
        Cadastro cadastro = new Cadastro();
        public void MostraMenu()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Cabecalho();
                Opcoes();
                Rodape();
                opcao = LerOpcao();
                Escolha(opcao);

            } while (opcao != 0);
        }

        private void Cabecalho()
        {
            Console.WriteLine(@"\\\\\\\\\\\\\\\\\\\\ HAVAN LABS ////////////////////");
            Console.WriteLine("====================================================");
        }
        private void Opcoes()
        {
            Console.WriteLine("\t1 - Cadastro Pessoa Física\n\t2 - Cadastro Pessoa Jurídica\n\t3 - Exibir Pessoa Física Cadastrada\n\t4 - Exibir Pessoa Jurídica Cadastrada\n\t0 - Sair");
             
        }

        private static int LerOpcao()
        {
            int opcao = 0;
            try
            {
                opcao = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Informação inválida");
            }
            return opcao;
        }

        private void Rodape()
        {
            Console.Write("=========================================== Opção: ");
        }
        private void Escolha(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    CabecalhoCadastroPessoaFisica();
                    cadastro.CadastroPessoaFisica();
                    break;
                case 2:
                    CabecalhoCadastroPessoaJuridica();
                    cadastro.CadastroPessoaJuridica();
                    break;
                case 3:
                    CabecalhoPessoaFisicaCadastrada();
                    cadastro.MostrarPF();
                    Console.WriteLine("Pressione ENTER para sair...");
                    Console.ReadLine();
                    break;
                case 4:
                    CabecalhoPessoaJuridicaCadastrada();
                    cadastro.MostrarPJ();
                    Console.WriteLine("Pressione ENTER para sair...");
                    Console.ReadLine();
                    break;
            }
        }

        private void CabecalhoCadastroPessoaFisica()
        {
            Console.WriteLine("\n============== CADASTRO PESSOA FÍSICA ==============");
        }
        private void CabecalhoCadastroPessoaJuridica()
        {
            Console.WriteLine("\n============= CADASTRO PESSOA JURÍDICA =============");
        }
        private void CabecalhoPessoaFisicaCadastrada()
        {
            Console.WriteLine("\n============= PESSOA FÍSICA CADASTRADA =============");
        }
        private void CabecalhoPessoaJuridicaCadastrada()
        { 
            Console.WriteLine("\n============ PESSOA JURÍDICA CADASTRADA ============");
        }
    }
}
