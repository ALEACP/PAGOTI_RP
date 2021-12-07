using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_De_Danca.Entites
{
    public class Pessoa
    {
        private string _nome;
        private string _cpf;        
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
        
      
    }
}
