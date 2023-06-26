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
    public partial class Usc_CadastroPessoas : UserControlEngine
    {
        private Pessoa _itemPessoa;

        public Usc_CadastroPessoas()
        {
            InitializeComponent();
        }

        private void Btn_Pessoa_Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                /// :: Form validation.
                var validation = ValidateFields<Pessoa>();
                if (validation.Status == ValidateFieldEnum.Result.FieldEmpity)
                    MessageBox.Show("Preencha todos os campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (validation.Status == ValidateFieldEnum.Result.WrongFormat)
                    MessageBox.Show("Formato do nome da propriedade fora do padrão.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    /// :: Save info.
                    if (_itemPessoa == null)
                    {
                        _itemPessoa = validation.Content;
                        DbContext.Insert<Pessoa>(_itemPessoa);
                        if (_itemPessoa.Type == 0)
                        {
                            var user = new Login() { User = _itemPessoa.Email, Password = Txt_Login_Password.Text, IdPessoa = _itemPessoa.Id };
                            DbContext.Insert<Login>(user);
                        }
                        else
                        {
                            var aluno = new Aluno() { IdPessoa = _itemPessoa.Id };
                            DbContext.Insert<Aluno>(aluno);
                        }
                        Btn_Pessoa_Novo.Enabled = true;
                    }
                    else
                    {
                        _itemPessoa = validation.Content;
                        DbContext.Update<Pessoa>(_itemPessoa);
                    }
                    MessageBox.Show("Informações salvas com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Usr_CadastroPessoas_Load(object sender, EventArgs e)
        {
            /// :: Apply effect.
            ApplyMaks();
            Btn_Pessoa_Novo.Enabled = false;
        }

        private void Btn_Pessoa_Buscar_Click(object sender, EventArgs e)
        {
            var formBuscarPessoa = new Frm_BuscarPessoa();
            DialogResult result = formBuscarPessoa.ShowDialog();
            if (result == DialogResult.OK)
            {
                _itemPessoa = formBuscarPessoa.Pessoa;
                UpdateFields<Pessoa>(_itemPessoa);
                Btn_Pessoa_Novo.Enabled = true;
            }
        }

        private void Btn_Pessoa_Novo_Click(object sender, EventArgs e)
        {
            UpdateFields<Pessoa>(new Pessoa());
            _itemPessoa = null;
            Btn_Pessoa_Novo.Enabled = false;
        }
    }
}
