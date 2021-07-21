using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEmDupla2CadastroDePessoas
{
    public delegate int Opcoes();
    public delegate void Escolha(int escolha);
    public class Tela
    {
        OperacaoPF operacaoPF = new OperacaoPF();
        OperacaoPJ operacaoPJ = new OperacaoPJ();
        protected Opcoes funcaoOpcoes;
        protected Escolha funcaoEscolha;

        public void Start()
        {
            int escolha = 0;
            do
            {
                Cabecalho();
                escolha = funcaoOpcoes();
                funcaoEscolha(escolha);
            } while (escolha != 0);
        }

        private void Cabecalho()
        {
            Console.WriteLine(@"\\\\\\\\\\\\\\\\\\\\ HAVAN LABS ////////////////////");
            Console.WriteLine("====================================================");
        }

        private void Opcoes(string mensagem)
        {
            Console.WriteLine(mensagem);

        }
        private void Rodape()
        {
            Console.Write("=========================================== Opção: ");
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

        
    }
}
