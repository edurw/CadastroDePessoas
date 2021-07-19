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
        public static void MostraMenu()
        {
            Console.Clear();
            Cabecalho();
            Opcoes();
            Rodape();
            Escolha();
        }

        private static void Cabecalho()
        {
            Console.WriteLine(@"\\\\\\\\\\\\\\\\\ HAVAN LABS /////////////////");
            Console.WriteLine("==============================================");
        }
        private static void Opcoes()
        {
            Console.WriteLine("\t1 - Cadastro Pessoa Física\n\t2 - Cadastro Pessoa Jurídica\n\t3 - Exibir Pessoa Física Cadastrada\n\t4 - Exibir Pessoa Jurídica Cadastrada\n\t0 - Sair");
        }
        private static void Rodape()
        {
            Console.Write("======================================= Opção:");
        }
        private static void Escolha()
        {
            int opcao = 0;
            do
            {
                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Informação inválida");
                }
            } while (true);
            switch (opcao)
            {
                case 0:
                    break;
                case 1:
                    
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }
    }
}
