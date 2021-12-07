using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola_De_Danca.Entites
{
    public class Aluno : Pessoa
    {           
        private DateTime _datanascimento;
        private long _matricula;
        private string _email;
        private string _sexo;
        private SqlCommand cmd = new SqlCommand();
        private Conexao cn = new Conexao();
        private Pessoa pe = new Pessoa();
        public string mensagem;

        public Aluno()
        {

        }

        public DateTime DataNascimento
        {
            get { return _datanascimento; }
            set { _datanascimento = value; }
        }
        public long Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        public void Incluir()
        {
            try
            {
                cmd.CommandText = "INSERT INTO ALUNO (NOME,CPF, DATANASCIMENTO, MATRICULA, EMAIL,SEXO) " +
                  "VALUES (@nome,@cpf,@datanascimento,@matricula,@email,@sexo)";

                cmd.Parameters.AddWithValue("@nome",Nome);
                cmd.Parameters.AddWithValue("@cpf", CPF);
                cmd.Parameters.AddWithValue("@datanascimento", _datanascimento);
                cmd.Parameters.AddWithValue("@matricula", _matricula);
                cmd.Parameters.AddWithValue("@email", _email);
                cmd.Parameters.AddWithValue("@Sexo", _sexo);

                cmd.Connection = cn.AbrirConexao();
                //MessageBox.Show("Banco Conectado!");
                cmd.ExecuteNonQuery();
                cn.FecharConexao();

                mensagem = "Inclusão realizada com sucesso!";
            }
            catch (SqlException ex)
            {
                mensagem = ex.Message;
            }

        }


    }
}
