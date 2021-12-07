using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_De_Danca.Entites
{
    class Professor
    {
        private int _id;
        private string _nome;
        private string _cpf;
        private double _valor_hora;        
        private string _email;

        //Contrutor
                    

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
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
        public double Valor_Hora
        {
            get { return _valor_hora; }
            set { _valor_hora = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

    }
}
