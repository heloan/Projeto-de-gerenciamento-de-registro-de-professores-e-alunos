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
using Univap.Programacao3.Engine.Engine;
using Univap.Programacao3.Projeto.Model;

namespace Univap.Programacao3.Projeto.View
{
    public partial class Usc_ProfessorDisciplina : UserControlEngine
    {
        private Disciplina _itemDisciplina;
        private List<Pessoa> _listaProfessores;
        private List<Turma> _listaTurma;
        private List<PessoaAlunoView> _listaPessoaAluno;

        public Usc_ProfessorDisciplina()
        {
            InitializeComponent();
        }

        private void Usc_ProfessorDisciplina_Load(object sender, EventArgs e)
        {
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
                UpdateFields<DisciplinaFormulario>(new DisciplinaFormulario
                {
                    Nome = _itemDisciplina.Nome,
                    Professor = $"{professor.Id}-{professor.Nome}",
                    Turma = $"{turma.Id}-{turma.Curso}-{turma.Periodo}"
                });
                UpdateAlunos(Cbo_DisciplinaFormulario_Turma.Text.Split('-')[0]);
            }
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
    }
}
