using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_De_Danca.Entites
{
    public class Aluno : Pessoa
    {           
        private DateTime _datanascimento;
        private long _matricula;
        private string _email;
        private string _sexo;               
        private Pessoa pe = new Pessoa();
        public string mensagem;
    

        public DateTime DataNascimento
        {
            get { return _datanascimento; }
            set { _datanascimento = value; }
        }
        public long Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

                
    }
}
