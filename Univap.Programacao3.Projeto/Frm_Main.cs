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
using Univap.Programacao3.Projeto.View;

namespace Univap.Programacao3.Projeto
{
    public partial class Frm_Main : FormEngine
    {
        public static Pessoa Pessoa { get; set; } = new Pessoa();
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            DbContext.Get<Pessoa>(Pessoa);
            if(Pessoa.Type == 2)
                GenerateTabsSecretaria();
            else if(Pessoa.Type == 0)
                GenerateTabsProfessor();
        }

        private void GenerateTabsSecretaria()
        {
            CloseAllTabs(Tbc_Main);

            var uscCadastroPessoas = new Usc_CadastroPessoas();
            uscCadastroPessoas.Dock = DockStyle.Fill;

            TabPage tbCadastroPessoas = new TabPage();
            tbCadastroPessoas.Name = "Tab_CadastroPessoas";
            tbCadastroPessoas.Text = "Cadastro Pessoas";
            Tbc_Main.TabPages.Add(tbCadastroPessoas);
            tbCadastroPessoas.Controls.Add(uscCadastroPessoas);

            var uscCadastroTurma = new Usc_CadastroTurma();
            uscCadastroTurma.Dock = DockStyle.Fill;

            TabPage tbCadastroTurma = new TabPage();
            tbCadastroTurma.Name = "Tab_CadastroTurma";
            tbCadastroTurma.Text = "Cadastro Turmas";
            Tbc_Main.TabPages.Add(tbCadastroTurma);
            tbCadastroTurma.Controls.Add(uscCadastroTurma);

            var uscCadastroDisciplina = new Usc_CadastroDisciplina();
            uscCadastroDisciplina.Dock = DockStyle.Fill;

            TabPage tbCadastroDisciplina = new TabPage();
            tbCadastroDisciplina.Name = "Tab_CadastroDisciplina";
            tbCadastroDisciplina.Text = "Cadastro Disciplinas";
            Tbc_Main.TabPages.Add(tbCadastroDisciplina);
            tbCadastroDisciplina.Controls.Add(uscCadastroDisciplina);
        }

        private void GenerateTabsProfessor()
        {
            CloseAllTabs(Tbc_Main);

            var uscProfessorDisciplina = new Usc_ProfessorDisciplina();
            uscProfessorDisciplina.Dock = DockStyle.Fill;

            TabPage tbProfessorDisciplina = new TabPage();
            tbProfessorDisciplina.Name = "Tab_ProfessorDisciplina";
            tbProfessorDisciplina.Text = "Disciplinas";
            Tbc_Main.TabPages.Add(tbProfessorDisciplina);
            tbProfessorDisciplina.Controls.Add(uscProfessorDisciplina);

            var uscAula = new Usc_Aula();
            uscAula.Dock = DockStyle.Fill;

            TabPage tbAula = new TabPage();
            tbAula.Name = "Tab_Aula";
            tbAula.Text = "Aula";
            Tbc_Main.TabPages.Add(tbAula);
            tbAula.Controls.Add(uscAula);
        }
    }
}
