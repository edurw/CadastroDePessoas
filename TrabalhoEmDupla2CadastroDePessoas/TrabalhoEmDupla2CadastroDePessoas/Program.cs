using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrabalhoEmDupla2CadastroDePessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Start();
            Console.WriteLine("Saindo ...");
            Thread.Sleep(1000);
        }
    }
}
