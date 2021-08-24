using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiClienteNet5
{
    public class Cliente
    {
        //public Cliente()
        //{

        //}

        public int ID { get; set; }
        public string CPF_CNPJ { get; set; }
        public string NOME { get; set; }
        public string SOBRENOME { get; set; }
        public char SEXO { get; set; }        
        public char PESSOA { get; set; }
    }
}
