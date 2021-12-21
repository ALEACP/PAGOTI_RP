using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACP_Tech.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string NomeCurso { get; set; }
        public double Valor { get; set; }
        public int CargaHoraria { get; set; }

    }
}
