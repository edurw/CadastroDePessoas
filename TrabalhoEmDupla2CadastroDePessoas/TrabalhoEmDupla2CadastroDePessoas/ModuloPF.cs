using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEmDupla2CadastroDePessoas
{
    public class ModuloPF : Tela
    {
        OperacaoPF crud = new OperacaoPF();
        public ModuloPF()
        {
            this.funcaoEscolha = Escolha;
            this.funcaoOpcoes = Opcoes;
        }
    private void Escolha(int opcao)
    {
        switch (opcao)
        {
            case 1:
                crud.Create();
                Console.Clear();
                break;
            case 2:
                crud.Read();
                Console.WriteLine("pressione qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
                break;
            case 3:
                crud.Update();
                Console.Clear();
                break;
            case 4:
                crud.Delete();
                Console.Clear();
                break;
            
            }
    }

    private int Opcoes()
    {
        int escolha;
            Console.WriteLine("1 -Cadastrar" +
                              "\n2 -Listar" +
                              "\n3 -Editar" +
                              "\n4 -Deletar" +
                              "\n0 -Sair");
            Console.WriteLine("===============================================Opção:");
        escolha = Valida.LeituraNumero();
            return escolha;
    }
    }
}
