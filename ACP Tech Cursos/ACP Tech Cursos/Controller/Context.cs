using ACP_Tech_Cursos.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACP_Tech_Cursos
{
    public class Context: DbContext  
    {               
        private string database = "ACP_Tech";
        private string usuario = "sa";
        private string senha = "db123";

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Curso> Curso { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = ALEACP; Initial Catalog =" + database + "; Integrated Security=true");
        }

    }
}
