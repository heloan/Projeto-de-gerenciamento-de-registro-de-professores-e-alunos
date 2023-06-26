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

namespace Univap.Programacao3.Projeto
{
    public partial class Frm_Login : FormEngine
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            /// :: Form validation.
            var validation = ValidateFields<Login>();
            if (validation.Status == ValidateFieldEnum.Result.FieldEmpity)
                MessageBox.Show("Preencha todos os campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validation.Status == ValidateFieldEnum.Result.WrongFormat)
                MessageBox.Show("Formato do nome da propriedade fora do padrão.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var ItemLogin = new Login();
                DbContext.Get<Login>(ItemLogin, "User", validation.Content.User);
                if (ItemLogin.Password == validation.Content.Password)
                    OpenMain(ItemLogin.IdPessoa);
                else
                    MessageBox.Show("Senha errada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            /// :: Apply effect.
            ApplyMaks();
        }

        private void OpenMain(int id)
        {
            var formSearch = new Frm_Main();
            Frm_Main.Pessoa.Id = id;
            formSearch.ShowDialog();
        }
    }
}   
