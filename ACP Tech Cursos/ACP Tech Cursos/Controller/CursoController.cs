using ACP_Tech_Cursos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACP_Tech_Cursos.Controller
{
    public static class CursoController
    {
        public static Context cnn;
        static CursoController()
        {
            cnn = new Context();
        }

        public static void Incluir(Curso curso)
        {            
            cnn.Curso.Add(curso);
            cnn.Entry(curso).State = curso.Id  > 0 ? Microsoft.EntityFrameworkCore.EntityState.Modified : //: no contexto é o mesmo que senão
                Microsoft.EntityFrameworkCore.EntityState.Added;
            cnn.SaveChanges(); 
         }                      
        public static Curso ObterCurso(int Id) 
        {
            return cnn.Curso.Where(c => c.Id == Id).FirstOrDefault();
        }
        public static List<Curso> ObterCurso()
        {
            return cnn.Curso.ToList();
        }
        public static void Delete(int Id)
        {
            Curso curso = ObterCurso(Id);
            cnn.RemoveRange(curso);
            cnn.SaveChanges(); 
        }

    }
}
