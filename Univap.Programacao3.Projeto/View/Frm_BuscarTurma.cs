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
    public partial class Frm_BuscarTurma : FormEngine
    {
        public Turma Turma { get; set; }
        private List<Turma> _listaTurma;
        public Frm_BuscarTurma()
        {
            InitializeComponent();
        }

        private void Frm_BuscarTurma_Load(object sender, EventArgs e)
        {
            _listaTurma = DbContext.GetAll<Turma>();
            if (_listaTurma.Count > 0)
            {
                foreach (var turma in _listaTurma)
                {
                    Cbo_Turmas_Nome.Items.Add($"{turma.Id}-{turma.Curso}-{turma.Periodo}");
                }
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        private void Btn_Turmas_Enviar_Click(object sender, EventArgs e)
        {
            /// :: Form validation.
            if (String.IsNullOrEmpty(Cbo_Turmas_Nome.Text))
                MessageBox.Show("Preencha todos os campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Turma = _listaTurma.FirstOrDefault(y => y.Id == Convert.ToInt32(Cbo_Turmas_Nome.Text.Split('-')[0]));
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
