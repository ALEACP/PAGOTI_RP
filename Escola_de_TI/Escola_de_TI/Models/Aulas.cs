namespace Escola_De_Danca.Entites
{
    class Aulas
    {
        private string _nome;
        private double _valor;
        private int _carga_horaria;
                  
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
             
        public double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        public int Carga_horaria
        {
            get { return _carga_horaria; }
            set { _carga_horaria = value; }
        }
    }
}
