﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEmDupla2CadastroDePessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            menu.MostraMenu();
            Console.WriteLine("Saindo ...");
            Console.ReadLine();
        }
    }
}
