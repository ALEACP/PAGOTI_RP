using Escola_De_Danca.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Escola_De_Danca
{
    public partial class CadastroAluno : Form
    {
        
        public CadastroAluno()
        {
            InitializeComponent();
            
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            Aluno cadAluno = new Aluno ();

            cadAluno.Nome = txtNome.Text;
            cadAluno.CPF = txtCPF.Text;
            cadAluno.DataNascimento = dtNascimento.Value;
            cadAluno.Matricula = int.Parse(txtMatricula.Text);
            cadAluno.Email = txtEmail.Text;
            cadAluno.Sexo = txtSexo.Text;            

            cadAluno.Incluir();

            MessageBox.Show(cadAluno.mensagem);
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtSexo.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
