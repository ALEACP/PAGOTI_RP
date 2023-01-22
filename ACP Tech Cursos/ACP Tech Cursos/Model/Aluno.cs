using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACP_Tech_Cursos.Model

{
    public class Aluno : Pessoa
    {           
        private DateTime _datanascimento;
        private long _matricula;
        private string _email;
        private string _sexo;        
        private Pessoa pe = new Pessoa();
        
        public Aluno()
        {

        }

        public int Id { get; set; }
        public DateTime DataNascimento {get ; set ; }     
        
        public long Matricula {get ; set ; }

        public int CursoId { get; set; }

        public string Email {get ;set ; }        

        public string Sexo {get ;set ; }               

    }
}
