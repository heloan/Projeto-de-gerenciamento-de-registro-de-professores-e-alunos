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
    public partial class Usc_CadastroDisciplina : UserControlEngine
    {
        private Disciplina _itemDisciplina;
        private List<Pessoa> _listaProfessores;
        private List<Turma> _listaTurma;
        private List<PessoaAlunoView> _listaPessoaAluno;
        public Usc_CadastroDisciplina()
        {
            InitializeComponent();
        }

        private void Btn_Disciplina_Enviar_Click(object sender, EventArgs e)
        {
            /// :: Form validation.
            var validation = ValidateFields<DisciplinaFormulario>();
            if (validation.Status == ValidateFieldEnum.Result.FieldEmpity)
                MessageBox.Show("Preencha todos os campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validation.Status == ValidateFieldEnum.Result.WrongFormat)
                MessageBox.Show("Formato do nome da propriedade fora do padrão.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                /// :: Save info.
                if (_itemDisciplina == null)
                {
                    _itemDisciplina = new Disciplina() 
                    { 
                        Nome = validation.Content.Nome, 
                        IdProfessor = Convert.ToInt32(validation.Content.Professor.Split('-')[0]),
                        IdTurma = Convert.ToInt32(validation.Content.Turma.Split('-')[0]),
                    };
                    DbContext.Insert<Disciplina>(_itemDisciplina);
                    Btn_Disciplina_Novo.Enabled = true;
                }
                else
                {
                    _itemDisciplina = new Disciplina()
                    {
                        Nome = validation.Content.Nome,
                        IdProfessor = Convert.ToInt32(validation.Content.Professor.Split('-')[0]),
                        IdTurma = Convert.ToInt32(validation.Content.Turma.Split('-')[0]),
                    };
                    DbContext.Update<Disciplina>(_itemDisciplina);
                }
                MessageBox.Show("Informações salvas com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Usc_CadastroDisiplina_Load(object sender, EventArgs e)
        {
            /// :: Apply effect.
            ApplyMaks();

            _listaProfessores = DbContext.GetAll<Pessoa>().Where(y => y.Type == 0).ToList();
            foreach (var pessoa in _listaProfessores)
            {
                Cbo_DisciplinaFormulario_Professor.Items.Add($"{pessoa.Id}-{pessoa.Nome}");
            }

            _listaTurma = DbContext.GetAll<Turma>();
            foreach (var turma in _listaTurma)
            {
                Cbo_DisciplinaFormulario_Turma.Items.Add($"{turma.Id}-{turma.Curso}-{turma.Periodo}");
            }

            Btn_Disciplina_Novo.Enabled = false;
        }

        private void UpdateAlunos(string IdTurma)
        {
            _listaPessoaAluno = DbContext.GetAll<PessoaAlunoView>("IdTurma", IdTurma);
            string alunos = "";
            foreach (var pessoaAluno in _listaPessoaAluno)
            {
                alunos += $"{pessoaAluno.IdAluno} - {pessoaAluno.Nome}\r\n";
            }
            Txt_Lista_Aluno.Text = alunos;
        }

        private void Cbo_Disciplina_Turma_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAlunos(Cbo_DisciplinaFormulario_Turma.Text.Split('-')[0]);
        }

        private void Btn_Disciplina_Buscar_Click(object sender, EventArgs e)
        {
            var formBuscarDisciplina = new Frm_BuscarDisciplina();
            DialogResult result = formBuscarDisciplina.ShowDialog();
            if (result == DialogResult.OK)
            {
                _itemDisciplina = formBuscarDisciplina.Disciplina;
                var professor = _listaProfessores.FirstOrDefault(y => y.Id == _itemDisciplina.IdProfessor);
                var turma = _listaTurma.FirstOrDefault(y => y.Id == _itemDisciplina.IdTurma);
                UpdateFields<DisciplinaFormulario>(new DisciplinaFormulario { 
                    Nome = _itemDisciplina.Nome,
                    Professor = $"{professor.Id}-{professor.Nome}",
                    Turma = $"{turma.Id}-{turma.Curso}-{turma.Periodo}"
                });
                UpdateAlunos(Cbo_DisciplinaFormulario_Turma.Text.Split('-')[0]);
                Btn_Disciplina_Novo.Enabled = true;
            }
        }

        private void Btn_Disciplina_Novo_Click(object sender, EventArgs e)
        {
            UpdateFields<DisciplinaFormulario>(new DisciplinaFormulario());
            _itemDisciplina = null;
            Btn_Disciplina_Novo.Enabled = false;
        }
    }
}
