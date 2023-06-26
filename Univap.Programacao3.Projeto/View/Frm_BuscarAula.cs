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
    public partial class Frm_BuscarAula : FormEngine
    {
        public Aula Aula { get; set; }
        private List<Aula> _listaAula;
        public Frm_BuscarAula()
        {
            InitializeComponent();
        }

        private void Frm_BuscarAula_Load(object sender, EventArgs e)
        {
            _listaAula = DbContext.GetAll<Aula>().Where(y => y.IdProfessor == Frm_Main.Pessoa.Id).ToList();
            if (_listaAula.Count > 0)
            {
                foreach (var aula in _listaAula)
                {
                    Cbo_Aula_Lista.Items.Add($"{aula.Id}-{aula.Data.ToString()}");
                }
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        private void Btn_Aula_Enviar_Click(object sender, EventArgs e)
        {
            /// :: Form validation.
            if (String.IsNullOrEmpty(Cbo_Aula_Lista.Text))
                MessageBox.Show("Preencha todos os campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Aula = _listaAula.FirstOrDefault(y => y.Id == Convert.ToInt32(Cbo_Aula_Lista.Text.Split('-')[0]));
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
