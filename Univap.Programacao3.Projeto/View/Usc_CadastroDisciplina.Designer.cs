namespace Univap.Programacao3.Projeto.View
{
    partial class Usc_CadastroDisciplina
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
            this.Txt_DisciplinaFormulario_Nome = new System.Windows.Forms.TextBox();
            this.Lbl_Disciplina_Nome = new System.Windows.Forms.Label();
            this.Lbl_Disciplina_Professor = new System.Windows.Forms.Label();
            this.Cbo_DisciplinaFormulario_Professor = new System.Windows.Forms.ComboBox();
            this.Cbo_DisciplinaFormulario_Turma = new System.Windows.Forms.ComboBox();
            this.Lbl_Disciplina_Turma = new System.Windows.Forms.Label();
            this.Btn_Disciplina_Enviar = new System.Windows.Forms.Button();
            this.Txt_Lista_Aluno = new System.Windows.Forms.TextBox();
            this.Lbl_Lista_Aluno = new System.Windows.Forms.Label();
            this.Btn_Disciplina_Novo = new System.Windows.Forms.Button();
            this.Btn_Disciplina_Buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_DisciplinaFormulario_Nome
            // 
            this.Txt_DisciplinaFormulario_Nome.Location = new System.Drawing.Point(17, 27);
            this.Txt_DisciplinaFormulario_Nome.Name = "Txt_DisciplinaFormulario_Nome";
            this.Txt_DisciplinaFormulario_Nome.Size = new System.Drawing.Size(719, 20);
            this.Txt_DisciplinaFormulario_Nome.TabIndex = 5;
            this.Txt_DisciplinaFormulario_Nome.Tag = "required";
            // 
            // Lbl_Disciplina_Nome
            // 
            this.Lbl_Disciplina_Nome.AutoSize = true;
            this.Lbl_Disciplina_Nome.Location = new System.Drawing.Point(14, 11);
            this.Lbl_Disciplina_Nome.Name = "Lbl_Disciplina_Nome";
            this.Lbl_Disciplina_Nome.Size = new System.Drawing.Size(38, 13);
            this.Lbl_Disciplina_Nome.TabIndex = 4;
            this.Lbl_Disciplina_Nome.Text = "Nome:";
            // 
            // Lbl_Disciplina_Professor
            // 
            this.Lbl_Disciplina_Professor.AutoSize = true;
            this.Lbl_Disciplina_Professor.Location = new System.Drawing.Point(14, 50);
            this.Lbl_Disciplina_Professor.Name = "Lbl_Disciplina_Professor";
            this.Lbl_Disciplina_Professor.Size = new System.Drawing.Size(54, 13);
            this.Lbl_Disciplina_Professor.TabIndex = 6;
            this.Lbl_Disciplina_Professor.Text = "Professor:";
            // 
            // Cbo_DisciplinaFormulario_Professor
            // 
            this.Cbo_DisciplinaFormulario_Professor.FormattingEnabled = true;
            this.Cbo_DisciplinaFormulario_Professor.Location = new System.Drawing.Point(17, 67);
            this.Cbo_DisciplinaFormulario_Professor.Name = "Cbo_DisciplinaFormulario_Professor";
            this.Cbo_DisciplinaFormulario_Professor.Size = new System.Drawing.Size(719, 21);
            this.Cbo_DisciplinaFormulario_Professor.TabIndex = 7;
            this.Cbo_DisciplinaFormulario_Professor.Tag = "required";
            // 
            // Cbo_DisciplinaFormulario_Turma
            // 
            this.Cbo_DisciplinaFormulario_Turma.FormattingEnabled = true;
            this.Cbo_DisciplinaFormulario_Turma.Location = new System.Drawing.Point(17, 108);
            this.Cbo_DisciplinaFormulario_Turma.Name = "Cbo_DisciplinaFormulario_Turma";
            this.Cbo_DisciplinaFormulario_Turma.Size = new System.Drawing.Size(719, 21);
            this.Cbo_DisciplinaFormulario_Turma.TabIndex = 9;
            this.Cbo_DisciplinaFormulario_Turma.Tag = "required";
            this.Cbo_DisciplinaFormulario_Turma.SelectedIndexChanged += new System.EventHandler(this.Cbo_Disciplina_Turma_SelectedIndexChanged);
            // 
            // Lbl_Disciplina_Turma
            // 
            this.Lbl_Disciplina_Turma.AutoSize = true;
            this.Lbl_Disciplina_Turma.Location = new System.Drawing.Point(14, 91);
            this.Lbl_Disciplina_Turma.Name = "Lbl_Disciplina_Turma";
            this.Lbl_Disciplina_Turma.Size = new System.Drawing.Size(40, 13);
            this.Lbl_Disciplina_Turma.TabIndex = 8;
            this.Lbl_Disciplina_Turma.Text = "Turma:";
            // 
            // Btn_Disciplina_Enviar
            // 
            this.Btn_Disciplina_Enviar.Location = new System.Drawing.Point(642, 291);
            this.Btn_Disciplina_Enviar.Name = "Btn_Disciplina_Enviar";
            this.Btn_Disciplina_Enviar.Size = new System.Drawing.Size(94, 34);
            this.Btn_Disciplina_Enviar.TabIndex = 10;
            this.Btn_Disciplina_Enviar.Text = "Enviar";
            this.Btn_Disciplina_Enviar.UseVisualStyleBackColor = true;
            this.Btn_Disciplina_Enviar.Click += new System.EventHandler(this.Btn_Disciplina_Enviar_Click);
            // 
            // Txt_Lista_Aluno
            // 
            this.Txt_Lista_Aluno.Location = new System.Drawing.Point(17, 148);
            this.Txt_Lista_Aluno.Multiline = true;
            this.Txt_Lista_Aluno.Name = "Txt_Lista_Aluno";
            this.Txt_Lista_Aluno.ReadOnly = true;
            this.Txt_Lista_Aluno.Size = new System.Drawing.Size(719, 137);
            this.Txt_Lista_Aluno.TabIndex = 15;
            this.Txt_Lista_Aluno.Tag = "";
            // 
            // Lbl_Lista_Aluno
            // 
            this.Lbl_Lista_Aluno.AutoSize = true;
            this.Lbl_Lista_Aluno.Location = new System.Drawing.Point(14, 132);
            this.Lbl_Lista_Aluno.Name = "Lbl_Lista_Aluno";
            this.Lbl_Lista_Aluno.Size = new System.Drawing.Size(42, 13);
            this.Lbl_Lista_Aluno.TabIndex = 14;
            this.Lbl_Lista_Aluno.Text = "Alunos:";
            // 
            // Btn_Disciplina_Novo
            // 
            this.Btn_Disciplina_Novo.Location = new System.Drawing.Point(117, 291);
            this.Btn_Disciplina_Novo.Name = "Btn_Disciplina_Novo";
            this.Btn_Disciplina_Novo.Size = new System.Drawing.Size(94, 34);
            this.Btn_Disciplina_Novo.TabIndex = 17;
            this.Btn_Disciplina_Novo.Text = "Novo";
            this.Btn_Disciplina_Novo.UseVisualStyleBackColor = true;
            this.Btn_Disciplina_Novo.Click += new System.EventHandler(this.Btn_Disciplina_Novo_Click);
            // 
            // Btn_Disciplina_Buscar
            // 
            this.Btn_Disciplina_Buscar.Location = new System.Drawing.Point(17, 291);
            this.Btn_Disciplina_Buscar.Name = "Btn_Disciplina_Buscar";
            this.Btn_Disciplina_Buscar.Size = new System.Drawing.Size(94, 34);
            this.Btn_Disciplina_Buscar.TabIndex = 16;
            this.Btn_Disciplina_Buscar.Text = "Buscar";
            this.Btn_Disciplina_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Disciplina_Buscar.Click += new System.EventHandler(this.Btn_Disciplina_Buscar_Click);
            // 
            // Usc_CadastroDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Disciplina_Novo);
            this.Controls.Add(this.Btn_Disciplina_Buscar);
            this.Controls.Add(this.Txt_Lista_Aluno);
            this.Controls.Add(this.Lbl_Lista_Aluno);
            this.Controls.Add(this.Btn_Disciplina_Enviar);
            this.Controls.Add(this.Cbo_DisciplinaFormulario_Turma);
            this.Controls.Add(this.Lbl_Disciplina_Turma);
            this.Controls.Add(this.Cbo_DisciplinaFormulario_Professor);
            this.Controls.Add(this.Lbl_Disciplina_Professor);
            this.Controls.Add(this.Txt_DisciplinaFormulario_Nome);
            this.Controls.Add(this.Lbl_Disciplina_Nome);
            this.Name = "Usc_CadastroDisciplina";
            this.Size = new System.Drawing.Size(754, 338);
            this.Load += new System.EventHandler(this.Usc_CadastroDisiplina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_DisciplinaFormulario_Nome;
        private System.Windows.Forms.Label Lbl_Disciplina_Nome;
        private System.Windows.Forms.Label Lbl_Disciplina_Professor;
        private System.Windows.Forms.ComboBox Cbo_DisciplinaFormulario_Professor;
        private System.Windows.Forms.ComboBox Cbo_DisciplinaFormulario_Turma;
        private System.Windows.Forms.Label Lbl_Disciplina_Turma;
        private System.Windows.Forms.Button Btn_Disciplina_Enviar;
        private System.Windows.Forms.TextBox Txt_Lista_Aluno;
        private System.Windows.Forms.Label Lbl_Lista_Aluno;
        private System.Windows.Forms.Button Btn_Disciplina_Novo;
        private System.Windows.Forms.Button Btn_Disciplina_Buscar;
    }
}
