using ACP_Tech_Cursos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACP_Tech_Cursos.Controller
{
    public static class AlunoController
    {
        public static Context cnn;
        static AlunoController()
        {
            cnn = new Context();
        }

        public static void Incluir(Aluno aluno)
        {            
            cnn.Aluno.Add(aluno);
            cnn.Entry(aluno).State = aluno.Id  > 0 ? Microsoft.EntityFrameworkCore.EntityState.Modified : //: no contexto é o mesmo que senão
                Microsoft.EntityFrameworkCore.EntityState.Added;
            cnn.SaveChanges(); 
         }                      
        public static Aluno ObterAluno(int Id) 
        {
            return cnn.Aluno.Where(c => c.Id == Id).FirstOrDefault();
        }
        public static List<Aluno> ObterAluno()
        {
            return cnn.Aluno.ToList();
        }
        public static void Delete(int Id)
        {
            Aluno aluno = ObterAluno(Id);
            cnn.RemoveRange(aluno);
            cnn.SaveChanges(); 
        }

    }
}
