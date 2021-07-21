using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoEmDupla2CadastroDePessoas.Models;

namespace TrabalhoEmDupla2CadastroDePessoas
{
    class Menu : Tela
    {
        ModuloPF moduloPf;
        ModuloPJ moduloPj;
        public Menu()
        {
            moduloPf = new ModuloPF();
            moduloPj = new ModuloPJ();
            this.funcaoEscolha = Escolha;
            this.funcaoOpcoes = Opcoes;
        }

        private void Escolha(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    moduloPf.Start();
                    break;
                case 2:
                    Console.Clear();
                    moduloPj.Start();
                    break;

            }
        }

        private int Opcoes()
        {
            int escolha;
            Console.WriteLine("1 -Pessoa Fisica" +
                            "\n2 -Pessoa Juridica" +
                            "\n0 -Sair");
            Console.WriteLine("===============================================Opção:");
            escolha = Valida.LeituraNumero();

            return escolha;
        }
    }
}
