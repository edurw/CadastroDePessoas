using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEmDupla2CadastroDePessoas
{
    class Valida
    {
        public static string ValidaString()
        {

            string value = string.Empty;
            value = Console.ReadLine().Trim();
            while (String.IsNullOrEmpty(value))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("valor invalido!");
                Console.ResetColor();
                value = Console.ReadLine().Trim();
            }
            return value;
        }
      
        public static int LeituraNumero()
        {
            do
            {
                int retorno = -1;
                try
                {
                    retorno = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception) { }
                if (retorno >= 0)
                {
                    return retorno;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dado invalido, insira novamente");
                    Console.ResetColor();
                }
            } while (true);
        }
        public static string validaSN()
        {
            Console.WriteLine("Deseja cadastrar mais 1?(y/n)");

            do
            {
                string resposta = Console.ReadLine().Trim().ToLower();
                if (resposta.Equals("y") || resposta.Equals("n"))
                {
                    return resposta;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dado Invalido! Digite [Y/N]!!!");
                    Console.ResetColor();
                }
            } while (true);

        }
    }
}
