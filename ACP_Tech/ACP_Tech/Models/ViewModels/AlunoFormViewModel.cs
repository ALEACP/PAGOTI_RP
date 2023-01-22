using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACP_Tech.Models.ViewModels
{
    public class AlunoFormViewModel
    {
        public Aluno Aluno { get; set; }
        public ICollection<Curso> Cursos { get; set; }
    }
}
