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
using Univap.Programacao3.Engine.Engine;
using Univap.Programacao3.Projeto.Model;

namespace Univap.Programacao3.Projeto.View
{
    public partial class Usc_CadastroTurma : UserControlEngine
    {
        private Turma _itemTurma;
        private List<PessoaAlunoView> _listaPessoaAluno;

        public Usc_CadastroTurma()
        {
            InitializeComponent();
        }

        private void Btn_Turma_Enviar_Click(object sender, EventArgs e)
        {
            /// :: Form validation.
            var validation = ValidateFields<Turma>();
            if (validation.Status == ValidateFieldEnum.Result.FieldEmpity)
                MessageBox.Show("Preencha todos os campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validation.Status == ValidateFieldEnum.Result.WrongFormat)
                MessageBox.Show("Formato do nome da propriedade fora do padrão.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                /// :: Save info.
                if(_itemTurma == null)
                {
                    _itemTurma = validation.Content;
                    DbContext.Insert<Turma>(_itemTurma);
                    Btn_Turma_Aluno.Enabled = true;
                    Btn_Turma_Novo.Enabled = true;
                }
                else
                {
                    _itemTurma = validation.Content;
                    DbContext.Update<Turma>(_itemTurma);
                }
                MessageBox.Show("Informações salvas com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Usc_CadastroTurma_Load(object sender, EventArgs e)
        {
            /// :: Apply effect.
            ApplyMaks();

            if(_itemTurma == null)
            {
                Btn_Turma_Aluno.Enabled = false;
                Btn_Turma_Novo.Enabled = false;
            }
        }

        private void Btn_Turma_Aluno_Click(object sender, EventArgs e)
        {
            var formAluno = new Frm_CadastroAluno(_itemTurma);
            DialogResult result = formAluno.ShowDialog();
            UpdateAlunos();
        }

        private void Btn_Turma_Buscar_Click(object sender, EventArgs e)
        {
            var formBuscarTurma = new Frm_BuscarTurma();
            DialogResult result = formBuscarTurma.ShowDialog();
            if (result == DialogResult.OK)
            {
                _itemTurma = formBuscarTurma.Turma;
                UpdateFields<Turma>(_itemTurma);
                Btn_Turma_Aluno.Enabled = true;
                UpdateAlunos();
                Btn_Turma_Novo.Enabled = true;
            }
        }

        private void UpdateAlunos()
        {
            _listaPessoaAluno = DbContext.GetAll<PessoaAlunoView>("IdTurma", _itemTurma.Id.ToString());
            string alunos = "";
            Txt_Aluno_Lista.Text = "";
            foreach (var pessoaAluno in _listaPessoaAluno)
            {
                alunos+= $"{pessoaAluno.IdAluno} - {pessoaAluno.Nome}\r\n";
            }
            Txt_Aluno_Lista.Text = alunos;
        }

        private void Btn_Turma_Novo_Click(object sender, EventArgs e)
        {
            UpdateFields<Turma>(new Turma());
            _itemTurma = null;
            Btn_Turma_Novo.Enabled = false;
            Txt_Aluno_Lista.Text = "";
        }
    }
}
