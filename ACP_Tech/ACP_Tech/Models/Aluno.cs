using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACP_Tech.Models
{
    public class Aluno: Pessoa 
    {
        public int Id { get; set; }      
        public long Matricula { get; set; }
        public DateTime DataNascimento { get; set; }        
        public string Sexo { get; set; }
                    
    }
}
