using ACP_Tech.Data; 
using ACP_Tech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACP_Tech.Services
{
    public class AlunoService
    {
        private readonly ACP_TechContext _context;
        public AlunoService(ACP_TechContext context)
        {
            _context = context;
        }

        public List<Aluno> PesquisarTodos()
        {
            return _context.Aluno.ToList();
        }
    }
}
