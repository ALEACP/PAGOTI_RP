using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ACP_Tech.Models;

namespace ACP_Tech.Data
{
    public class ACP_TechContext : DbContext
    {
        public ACP_TechContext (DbContextOptions<ACP_TechContext> options)
            : base(options)
        {
        }

        public DbSet<ACP_Tech.Models.Curso> Curso { get; set; }

        public DbSet<ACP_Tech.Models.Aluno> Aluno { get; set; }
    }
}
