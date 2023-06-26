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
    public partial class Usc_Aula : UserControlEngine
    {
        private Aula _itemAula;
        private List<Disciplina> _listaDisciplinas;
        private List<AlunoDisciplinaView> _alunoDisciplinaLista;
        public Usc_Aula()
        {
            InitializeComponent();
        }

        private void Usc_Aula_Load(object sender, EventArgs e)
        {
            /// :: Apply effect.
            ApplyMaks();

            _listaDisciplinas = DbContext.GetAll<Disciplina>().Where(y => y.IdProfessor == Frm_Main.Pessoa.Id).ToList();
            foreach (var disciplina in _listaDisciplinas)
            {
                Cbo_AulaFormulario_Disciplina.Items.Add($"{disciplina.Id}-{disciplina.Nome}");
            }
        }

        private void Cbo_AulaFormulario_Disciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAlunos(Cbo_AulaFormulario_Disciplina.Text.Split('-')[0]);
        }

        private void UpdateAlunos(string IdDisciplina)
        {
            _alunoDisciplinaLista = DbContext.GetAll<AlunoDisciplinaView>("IdDisciplina", IdDisciplina);
            Clb_ListaPresensa_Alunos.Items.Clear();
            foreach (var alunoDisciplina in _alunoDisciplinaLista)
            {
                string text = $"{alunoDisciplina.IdAluno}-{alunoDisciplina.Nome}";

                if (_itemAula != null) {
                    Presenca presenca = DbContext.GetAll<Presenca>("IdAula", _itemAula.Id.ToString()).FirstOrDefault(y => y.IdAluno == alunoDisciplina.IdAluno);
                    if(presenca == null)
                        Clb_ListaPresensa_Alunos.Items.Add(text, CheckState.Unchecked);
                    else
                        Clb_ListaPresensa_Alunos.Items.Add(text, CheckState.Checked);
                }
                else
                    Clb_ListaPresensa_Alunos.Items.Add(text, CheckState.Unchecked);
            }
        }

        private void Btn_Disciplina_Enviar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Cbo_AulaFormulario_Disciplina.Text) || String.IsNullOrEmpty(Dtp_AulaFormulario_Data.Text))
                MessageBox.Show("Preencha todos os campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                /// :: Save info.
                if (_itemAula == null)
                {
                    _itemAula = new Aula()
                    {
                        IdDisciplina = Convert.ToInt32(Cbo_AulaFormulario_Disciplina.Text.Split('-')[0]),
                        IdProfessor = Frm_Main.Pessoa.Id,
                        Data = Dtp_AulaFormulario_Data.Value
                    };
                    DbContext.Insert<Aula>(_itemAula);
                    SalvarPresenca();
                }
                else
                {
                    _itemAula = new Aula()
                    {
                        IdDisciplina = Convert.ToInt32(Cbo_AulaFormulario_Disciplina.Text.Split('-')[0]),
                        Data = Dtp_AulaFormulario_Data.Value
                    };
                    DbContext.Update<Aula>(_itemAula);
                }
                Btn_Aula_Enviar.Enabled = false;
                MessageBox.Show("Informações salvas com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SalvarPresenca()
        {
            foreach (object item in Clb_ListaPresensa_Alunos.CheckedItems)
            {
                string itemText = Clb_ListaPresensa_Alunos.GetItemText(item);
                Presenca presenca = new Presenca()
                {
                    IdAluno = Convert.ToInt32(itemText.Split('-')[0]),
                    IdAula = _itemAula.Id
                };
                DbContext.Insert<Presenca>(presenca);
            }
        }

        private void Btn_Aula_Buscar_Click(object sender, EventArgs e)
        {
            var formBuscarAula = new Frm_BuscarAula();
            DialogResult result = formBuscarAula.ShowDialog();
            if (result == DialogResult.OK)
            {
                _itemAula = formBuscarAula.Aula;
                var disciplina = _listaDisciplinas.FirstOrDefault(y => y.Id == _itemAula.IdDisciplina);
                Cbo_AulaFormulario_Disciplina.Text = $"{disciplina.Id}-{disciplina.Nome}";
                Dtp_AulaFormulario_Data.Value = _itemAula.Data;
                Btn_Aula_Enviar.Enabled = false;
                UpdateAlunos(Cbo_AulaFormulario_Disciplina.Text.Split('-')[0]);
            }
        }
    }
}
