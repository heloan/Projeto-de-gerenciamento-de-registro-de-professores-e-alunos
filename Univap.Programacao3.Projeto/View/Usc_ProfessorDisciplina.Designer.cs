namespace Univap.Programacao3.Projeto.View
{
    partial class Usc_ProfessorDisciplina
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Disciplina_Buscar = new System.Windows.Forms.Button();
            this.Txt_Lista_Aluno = new System.Windows.Forms.TextBox();
            this.Lbl_Lista_Aluno = new System.Windows.Forms.Label();
            this.Cbo_DisciplinaFormulario_Turma = new System.Windows.Forms.ComboBox();
            this.Lbl_Disciplina_Turma = new System.Windows.Forms.Label();
            this.Cbo_DisciplinaFormulario_Professor = new System.Windows.Forms.ComboBox();
            this.Lbl_Disciplina_Professor = new System.Windows.Forms.Label();
            this.Txt_DisciplinaFormulario_Nome = new System.Windows.Forms.TextBox();
            this.Lbl_Disciplina_Nome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Disciplina_Buscar
            // 
            this.Btn_Disciplina_Buscar.Location = new System.Drawing.Point(19, 292);
            this.Btn_Disciplina_Buscar.Name = "Btn_Disciplina_Buscar";
            this.Btn_Disciplina_Buscar.Size = new System.Drawing.Size(94, 34);
            this.Btn_Disciplina_Buscar.TabIndex = 27;
            this.Btn_Disciplina_Buscar.Text = "Buscar";
            this.Btn_Disciplina_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Disciplina_Buscar.Click += new System.EventHandler(this.Btn_Disciplina_Buscar_Click);
            // 
            // Txt_Lista_Aluno
            // 
            this.Txt_Lista_Aluno.Location = new System.Drawing.Point(19, 149);
            this.Txt_Lista_Aluno.Multiline = true;
            this.Txt_Lista_Aluno.Name = "Txt_Lista_Aluno";
            this.Txt_Lista_Aluno.ReadOnly = true;
            this.Txt_Lista_Aluno.Size = new System.Drawing.Size(719, 137);
            this.Txt_Lista_Aluno.TabIndex = 26;
            this.Txt_Lista_Aluno.Tag = "";
            // 
            // Lbl_Lista_Aluno
            // 
            this.Lbl_Lista_Aluno.AutoSize = true;
            this.Lbl_Lista_Aluno.Location = new System.Drawing.Point(16, 133);
            this.Lbl_Lista_Aluno.Name = "Lbl_Lista_Aluno";
            this.Lbl_Lista_Aluno.Size = new System.Drawing.Size(42, 13);
            this.Lbl_Lista_Aluno.TabIndex = 25;
            this.Lbl_Lista_Aluno.Text = "Alunos:";
            // 
            // Cbo_DisciplinaFormulario_Turma
            // 
            this.Cbo_DisciplinaFormulario_Turma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_DisciplinaFormulario_Turma.Enabled = false;
            this.Cbo_DisciplinaFormulario_Turma.FormattingEnabled = true;
            this.Cbo_DisciplinaFormulario_Turma.Location = new System.Drawing.Point(19, 109);
            this.Cbo_DisciplinaFormulario_Turma.Name = "Cbo_DisciplinaFormulario_Turma";
            this.Cbo_DisciplinaFormulario_Turma.Size = new System.Drawing.Size(719, 21);
            this.Cbo_DisciplinaFormulario_Turma.TabIndex = 23;
            this.Cbo_DisciplinaFormulario_Turma.Tag = "required";
            // 
            // Lbl_Disciplina_Turma
            // 
            this.Lbl_Disciplina_Turma.AutoSize = true;
            this.Lbl_Disciplina_Turma.Location = new System.Drawing.Point(16, 92);
            this.Lbl_Disciplina_Turma.Name = "Lbl_Disciplina_Turma";
            this.Lbl_Disciplina_Turma.Size = new System.Drawing.Size(40, 13);
            this.Lbl_Disciplina_Turma.TabIndex = 22;
            this.Lbl_Disciplina_Turma.Text = "Turma:";
            // 
            // Cbo_DisciplinaFormulario_Professor
            // 
            this.Cbo_DisciplinaFormulario_Professor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_DisciplinaFormulario_Professor.Enabled = false;
            this.Cbo_DisciplinaFormulario_Professor.FormattingEnabled = true;
            this.Cbo_DisciplinaFormulario_Professor.Location = new System.Drawing.Point(19, 68);
            this.Cbo_DisciplinaFormulario_Professor.Name = "Cbo_DisciplinaFormulario_Professor";
            this.Cbo_DisciplinaFormulario_Professor.Size = new System.Drawing.Size(719, 21);
            this.Cbo_DisciplinaFormulario_Professor.TabIndex = 21;
            this.Cbo_DisciplinaFormulario_Professor.Tag = "required";
            // 
            // Lbl_Disciplina_Professor
            // 
            this.Lbl_Disciplina_Professor.AutoSize = true;
            this.Lbl_Disciplina_Professor.Location = new System.Drawing.Point(16, 51);
            this.Lbl_Disciplina_Professor.Name = "Lbl_Disciplina_Professor";
            this.Lbl_Disciplina_Professor.Size = new System.Drawing.Size(54, 13);
            this.Lbl_Disciplina_Professor.TabIndex = 20;
            this.Lbl_Disciplina_Professor.Text = "Professor:";
            // 
            // Txt_DisciplinaFormulario_Nome
            // 
            this.Txt_DisciplinaFormulario_Nome.Location = new System.Drawing.Point(19, 28);
            this.Txt_DisciplinaFormulario_Nome.Name = "Txt_DisciplinaFormulario_Nome";
            this.Txt_DisciplinaFormulario_Nome.ReadOnly = true;
            this.Txt_DisciplinaFormulario_Nome.Size = new System.Drawing.Size(719, 20);
            this.Txt_DisciplinaFormulario_Nome.TabIndex = 19;
            this.Txt_DisciplinaFormulario_Nome.Tag = "required";
            // 
            // Lbl_Disciplina_Nome
            // 
            this.Lbl_Disciplina_Nome.AutoSize = true;
            this.Lbl_Disciplina_Nome.Location = new System.Drawing.Point(16, 12);
            this.Lbl_Disciplina_Nome.Name = "Lbl_Disciplina_Nome";
            this.Lbl_Disciplina_Nome.Size = new System.Drawing.Size(38, 13);
            this.Lbl_Disciplina_Nome.TabIndex = 18;
            this.Lbl_Disciplina_Nome.Text = "Nome:";
            // 
            // Usc_ProfessorDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Disciplina_Buscar);
            this.Controls.Add(this.Txt_Lista_Aluno);
            this.Controls.Add(this.Lbl_Lista_Aluno);
            this.Controls.Add(this.Cbo_DisciplinaFormulario_Turma);
            this.Controls.Add(this.Lbl_Disciplina_Turma);
            this.Controls.Add(this.Cbo_DisciplinaFormulario_Professor);
            this.Controls.Add(this.Lbl_Disciplina_Professor);
            this.Controls.Add(this.Txt_DisciplinaFormulario_Nome);
            this.Controls.Add(this.Lbl_Disciplina_Nome);
            this.Name = "Usc_ProfessorDisciplina";
            this.Size = new System.Drawing.Size(754, 338);
            this.Load += new System.EventHandler(this.Usc_ProfessorDisciplina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Disciplina_Buscar;
        private System.Windows.Forms.TextBox Txt_Lista_Aluno;
        private System.Windows.Forms.Label Lbl_Lista_Aluno;
        private System.Windows.Forms.ComboBox Cbo_DisciplinaFormulario_Turma;
        private System.Windows.Forms.Label Lbl_Disciplina_Turma;
        private System.Windows.Forms.ComboBox Cbo_DisciplinaFormulario_Professor;
        private System.Windows.Forms.Label Lbl_Disciplina_Professor;
        private System.Windows.Forms.TextBox Txt_DisciplinaFormulario_Nome;
        private System.Windows.Forms.Label Lbl_Disciplina_Nome;
    }
}
