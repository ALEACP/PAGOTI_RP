using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACP_Tech_Cursos.Model;
using ACP_Tech_Cursos.Controller;

namespace ACP_Tech_Cursos
{
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void CadastroAluno_Load(object sender, EventArgs e)
        {
            Aluno oAluno = new Aluno();

            grdCursos.DataSource = AlunoController.ObterAluno();
            

        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            //try
            //{
                Aluno oAluno = new Aluno();

                oAluno.Nome = txtNome.Text;
                oAluno.CPF = txtCPF.Text;
                oAluno.Email = txtEmail.Text;
                oAluno.DataNascimento = dtNascimento.Value;
                oAluno.Matricula = int.Parse(txtMatricula.Text);
                oAluno.Sexo = txtSexo.Text;
                oAluno.CursoId = 1;
                AlunoController.Incluir(oAluno);
                MessageBox.Show("Aluno Cadastrado!!!");
                

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show (ex.Message);
            //}
           
            
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
