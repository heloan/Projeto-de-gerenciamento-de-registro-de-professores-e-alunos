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
    public partial class Frm_BuscarDisciplina : FormEngine
    {
        public Disciplina Disciplina { get; set; }
        private List<Disciplina> _listaDisciplina;

        public Frm_BuscarDisciplina()
        {
            InitializeComponent();
        }

        private void Frm_BuscarDisciplina_Load(object sender, EventArgs e)
        {
            if(Frm_Main.Pessoa.Type == 0)
                _listaDisciplina = DbContext.GetAll<Disciplina>("IdProfessor", Frm_Main.Pessoa.Id.ToString());
            else
                _listaDisciplina = DbContext.GetAll<Disciplina>();
            if (_listaDisciplina.Count > 0)
            {
                foreach (var disciplina in _listaDisciplina)
                {
                    Cbo_Disciplina_Lista.Items.Add($"{disciplina.Id}-{disciplina.Nome}");
                }
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }

        }

        private void Btn_Disiplinas_Enviar_Click(object sender, EventArgs e)
        {
            /// :: Form validation.
            if (String.IsNullOrEmpty(Cbo_Disciplina_Lista.Text))
                MessageBox.Show("Preencha todos os campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Disciplina = _listaDisciplina.FirstOrDefault(y => y.Id == Convert.ToInt32(Cbo_Disciplina_Lista.Text.Split('-')[0]));
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
