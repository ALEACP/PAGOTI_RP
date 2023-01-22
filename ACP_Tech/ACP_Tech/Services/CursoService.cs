using ACP_Tech.Data;
using ACP_Tech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACP_Tech.Services
{
    public class CursoService
    {
        private readonly ACP_TechContext _context;

        private CursoService(ACP_TechContext context) 
        {
            _context = context;
        }

        public List<Curso> Pesquisar() 
        {
            return _context.Curso.ToList();         
        }


    }
}
