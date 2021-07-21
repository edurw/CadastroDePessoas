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
            endereco.CEP = Valida.ValidaString();
            Console.Write("Cidade: ");
            endereco.Cidade = Valida.ValidaString();
            Console.Write("Bairro: ");
            endereco.Bairro = Valida.ValidaString();
            Console.Write("Rua: ");
            endereco.Rua = Valida.ValidaString();
            Console.Write("Número da Residência: ");
            endereco.NumeroResidencia = Valida.ValidaString();
            Console.Write("Complemento: ");
            endereco.Complemento = Valida.ValidaString();

            return new Endereco(endereco.CEP, endereco.Cidade, endereco.Bairro, endereco.Rua, endereco.NumeroResidencia, endereco.Complemento);
        }
    }
}


