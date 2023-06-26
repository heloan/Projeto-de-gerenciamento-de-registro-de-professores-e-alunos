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
    public partial class Frm_BuscarPessoa : FormEngine
    {
        public Pessoa Pessoa { get; set; }
        private List<Pessoa> _listaPessoa;

        public Frm_BuscarPessoa()
        {
            InitializeComponent();
        }

        private void Frm_BuscarPessoa_Load(object sender, EventArgs e)
        {
            _listaPessoa = DbContext.GetAll<Pessoa>().Where(y => y.Type != 2).ToList();
            if (_listaPessoa.Count > 0)
            {
                foreach (var pessoa in _listaPessoa)
                {
                    Cbo_Pessoas_Lista.Items.Add($"{pessoa.Id}-{pessoa.Nome}");
                }
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        private void Btn_Pessoas_Enviar_Click(object sender, EventArgs e)
        {
            /// :: Form validation.
            if (String.IsNullOrEmpty(Cbo_Pessoas_Lista.Text))
                MessageBox.Show("Preencha todos os campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Pessoa = _listaPessoa.FirstOrDefault(y => y.Id == Convert.ToInt32(Cbo_Pessoas_Lista.Text.Split('-')[0]));
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Cbo_Pessoas_Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Pessoas_Lista_Click(object sender, EventArgs e)
        {

        }
    }
}
