using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEmDupla2CadastroDePessoas.Models
{
    public class Endereco
    {
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public string NumeroResidencia { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }

        public Endereco(string cep, string cidade, string bairro, string rua, string numeroResidencia, string complemento)
        {
            this.CEP = cep;
            this.Cidade = cidade;
            this.Rua = rua;
            this.NumeroResidencia = numeroResidencia;
            this.Complemento = complemento;
            this.Bairro = bairro;
        }
        public Endereco()
        {

        }
    }
}
