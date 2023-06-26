using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Univap.Programacao3.Data;
using Univap.Programacao3.Engine;
using Univap.Programacao3.Projeto.Model;

namespace Univap.Programacao3.Projeto.View
{
    public partial class Frm_CadastroAluno : FormEngine
    {
        private Turma _turma;
        private List<PessoaAlunoView> _listaPessoaAlunoView;
        public Frm_CadastroAluno(Turma turma)
        {
            _turma = turma;
            InitializeComponent();
        }

        private void Frm_CadastroAluno_Load(object sender, EventArgs e)
        {
            _listaPessoaAlunoView = DbContext.GetAll<PessoaAlunoView>().Where(y => y.IdTurma != _turma.Id).ToList();
            if (_listaPessoaAlunoView.Count > 0)
            {
                foreach (var pessoaAluno in _listaPessoaAlunoView)
                {
                    Cbo_Alunos_Nomes.Items.Add($"{pessoaAluno.IdAluno}-{pessoaAluno.Nome}");
                }
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
            
        }

        private void Btn_Alunos_Enviar_Click(object sender, EventArgs e)
        {
            /// :: Form validation.
            if (String.IsNullOrEmpty(Cbo_Alunos_Nomes.Text))
                MessageBox.Show("Preencha todos os campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                /// :: Save info.
                var aluno = new Aluno();
                DbContext.Get<Aluno>(aluno, "Id", Cbo_Alunos_Nomes.Text.Split('-')[0]);
                aluno.IdTurma = _turma.Id;
                DbContext.Update<Aluno>(aluno);
                MessageBox.Show("Informações salvas com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
