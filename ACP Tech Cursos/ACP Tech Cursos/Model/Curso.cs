namespace ACP_Tech_Cursos.Model

{
    public class Curso
    {
        private string _nome;
        private double _valor;
        private int _carga_horaria;

        //Contrutor
        public Curso()
        {

        }
        public int Id { get; set; }

        public string Nome { get; set; }     
             
        public double Valor { get; set; }
        
        public int Carga_horaria { get; set; }
        
    }
}
