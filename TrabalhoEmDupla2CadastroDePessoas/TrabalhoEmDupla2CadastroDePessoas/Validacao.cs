using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEmDupla2CadastroDePessoas
{
    public class Validacao
    {
        public static string ValidaStringEmBranco()
        {
            string dado = Console.ReadLine().Trim();
            while (String.IsNullOrEmpty(dado))
            {
                Console.WriteLine("VALOR INVÁLIDO!");
                dado = Console.ReadLine().Trim();
            }
            return dado;
        }

        public static int ValidaInteiros()
        {
            do
            {
                try
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    return num;
                }
                catch (FormatException)
                {
                    Console.WriteLine("CARACTERE INVÁLIDO!");
                }
            } while (true);
        }
    }
}
