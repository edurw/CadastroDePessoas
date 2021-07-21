using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoEmDupla2CadastroDePessoas.Models;

namespace TrabalhoEmDupla2CadastroDePessoas
{
    public class OperacoesEndereco
    {

        public static Endereco CadastroEndereco()
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

            return new Endereco(endereco.CEP, endereco.Cidade, endereco.Bairro, endereco.Rua, endereco.NumeroResidencia, endereco.Complemento);
        }
    }
}


