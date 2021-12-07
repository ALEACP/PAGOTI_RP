using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace Escola_De_Danca
{
    public class Conexao
    {               
        private string server = "ALEACP";
        private string database = "ESCOLA";
        private string usuario = "sa";
        private string senha = "db123";        
        private SqlConnection conn = new SqlConnection();
        public Conexao()
        {
            conn.ConnectionString = "Data Source =" +  server + 
            "; Initial Catalog =" + database +
            "; Integrated Security=false;User ID =" + usuario +
            "; Password =" + senha ;
        }
       
        public SqlConnection AbrirConexao(){
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();                    
            }
            return conn;
        }

        public void FecharConexao() 
        {
            if (conn.State == System.Data.ConnectionState.Open) 
            {
                conn.Close();
            } 

        }

    }   
}
