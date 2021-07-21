using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoEmDupla2CadastroDePessoas.Models;

namespace TrabalhoEmDupla2CadastroDePessoas
{
    public delegate void Operacoes();

    public  class Crud
    {
        protected static List<Pessoa> lista = new List<Pessoa>();
        protected Operacoes CreateOperacao;
        protected Operacoes ReadOperacao;
        protected Operacoes UpdateOperacao;
        protected Operacoes DeleteOperacao;

        public void Create()
        {
            CreateOperacao();
        }
        public void Read()
        {
            ReadOperacao(); 
        }
        public void Update()
        {
            UpdateOperacao(); 
        }
        public void Delete()
        {
            DeleteOperacao();
        }
    }
}
