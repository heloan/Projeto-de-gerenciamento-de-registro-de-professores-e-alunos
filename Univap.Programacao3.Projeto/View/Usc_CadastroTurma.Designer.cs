namespace Univap.Programacao3.Projeto.View
{
    partial class Usc_CadastroTurma
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
            this.Txt_Turma_Curso = new System.Windows.Forms.TextBox();
            this.Lbl_Turma_Curso = new System.Windows.Forms.Label();
            this.Lbl_Turma_Periodo = new System.Windows.Forms.Label();
            this.Txt_Turma_Periodo = new System.Windows.Forms.TextBox();
            this.Btn_Turma_Enviar = new System.Windows.Forms.Button();
            this.Btn_Turma_Aluno = new System.Windows.Forms.Button();
            this.Btn_Turma_Buscar = new System.Windows.Forms.Button();
            this.Lbl_Turma_Aluno = new System.Windows.Forms.Label();
            this.Txt_Aluno_Lista = new System.Windows.Forms.TextBox();
            this.Btn_Turma_Novo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_Turma_Curso
            // 
            this.Txt_Turma_Curso.Location = new System.Drawing.Point(17, 27);
            this.Txt_Turma_Curso.Name = "Txt_Turma_Curso";
            this.Txt_Turma_Curso.Size = new System.Drawing.Size(719, 20);
            this.Txt_Turma_Curso.TabIndex = 3;
            this.Txt_Turma_Curso.Tag = "required";
            // 
            // Lbl_Turma_Curso
            // 
            this.Lbl_Turma_Curso.AutoSize = true;
            this.Lbl_Turma_Curso.Location = new System.Drawing.Point(14, 11);
            this.Lbl_Turma_Curso.Name = "Lbl_Turma_Curso";
            this.Lbl_Turma_Curso.Size = new System.Drawing.Size(37, 13);
            this.Lbl_Turma_Curso.TabIndex = 2;
            this.Lbl_Turma_Curso.Text = "Curso:";
            // 
            // Lbl_Turma_Periodo
            // 
            this.Lbl_Turma_Periodo.AutoSize = true;
            this.Lbl_Turma_Periodo.Location = new System.Drawing.Point(14, 50);
            this.Lbl_Turma_Periodo.Name = "Lbl_Turma_Periodo";
            this.Lbl_Turma_Periodo.Size = new System.Drawing.Size(46, 13);
            this.Lbl_Turma_Periodo.TabIndex = 4;
            this.Lbl_Turma_Periodo.Text = "Periodo:";
            // 
            // Txt_Turma_Periodo
            // 
            this.Txt_Turma_Periodo.Location = new System.Drawing.Point(17, 66);
            this.Txt_Turma_Periodo.Name = "Txt_Turma_Periodo";
            this.Txt_Turma_Periodo.Size = new System.Drawing.Size(719, 20);
            this.Txt_Turma_Periodo.TabIndex = 5;
            this.Txt_Turma_Periodo.Tag = "required";
            // 
            // Btn_Turma_Enviar
            // 
            this.Btn_Turma_Enviar.Location = new System.Drawing.Point(642, 291);
            this.Btn_Turma_Enviar.Name = "Btn_Turma_Enviar";
            this.Btn_Turma_Enviar.Size = new System.Drawing.Size(94, 34);
            this.Btn_Turma_Enviar.TabIndex = 9;
            this.Btn_Turma_Enviar.Text = "Enviar";
            this.Btn_Turma_Enviar.UseVisualStyleBackColor = true;
            this.Btn_Turma_Enviar.Click += new System.EventHandler(this.Btn_Turma_Enviar_Click);
            // 
            // Btn_Turma_Aluno
            // 
            this.Btn_Turma_Aluno.Location = new System.Drawing.Point(542, 291);
            this.Btn_Turma_Aluno.Name = "Btn_Turma_Aluno";
            this.Btn_Turma_Aluno.Size = new System.Drawing.Size(94, 34);
            this.Btn_Turma_Aluno.TabIndex = 10;
            this.Btn_Turma_Aluno.Text = "Adicionar Aluno";
            this.Btn_Turma_Aluno.UseVisualStyleBackColor = true;
            this.Btn_Turma_Aluno.Click += new System.EventHandler(this.Btn_Turma_Aluno_Click);
            // 
            // Btn_Turma_Buscar
            // 
            this.Btn_Turma_Buscar.Location = new System.Drawing.Point(17, 291);
            this.Btn_Turma_Buscar.Name = "Btn_Turma_Buscar";
            this.Btn_Turma_Buscar.Size = new System.Drawing.Size(94, 34);
            this.Btn_Turma_Buscar.TabIndex = 11;
            this.Btn_Turma_Buscar.Text = "Buscar";
            this.Btn_Turma_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Turma_Buscar.Click += new System.EventHandler(this.Btn_Turma_Buscar_Click);
            // 
            // Lbl_Turma_Aluno
            // 
            this.Lbl_Turma_Aluno.AutoSize = true;
            this.Lbl_Turma_Aluno.Location = new System.Drawing.Point(14, 89);
            this.Lbl_Turma_Aluno.Name = "Lbl_Turma_Aluno";
            this.Lbl_Turma_Aluno.Size = new System.Drawing.Size(42, 13);
            this.Lbl_Turma_Aluno.TabIndex = 12;
            this.Lbl_Turma_Aluno.Text = "Alunos:";
            // 
            // Txt_Aluno_Lista
            // 
            this.Txt_Aluno_Lista.Location = new System.Drawing.Point(17, 105);
            this.Txt_Aluno_Lista.Multiline = true;
            this.Txt_Aluno_Lista.Name = "Txt_Aluno_Lista";
            this.Txt_Aluno_Lista.ReadOnly = true;
            this.Txt_Aluno_Lista.Size = new System.Drawing.Size(719, 180);
            this.Txt_Aluno_Lista.TabIndex = 13;
            this.Txt_Aluno_Lista.Tag = "";
            // 
            // Btn_Turma_Novo
            // 
            this.Btn_Turma_Novo.Location = new System.Drawing.Point(117, 291);
            this.Btn_Turma_Novo.Name = "Btn_Turma_Novo";
            this.Btn_Turma_Novo.Size = new System.Drawing.Size(94, 34);
            this.Btn_Turma_Novo.TabIndex = 14;
            this.Btn_Turma_Novo.Text = "Novo";
            this.Btn_Turma_Novo.UseVisualStyleBackColor = true;
            this.Btn_Turma_Novo.Click += new System.EventHandler(this.Btn_Turma_Novo_Click);
            // 
            // Usc_CadastroTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Turma_Novo);
            this.Controls.Add(this.Txt_Aluno_Lista);
            this.Controls.Add(this.Lbl_Turma_Aluno);
            this.Controls.Add(this.Btn_Turma_Buscar);
            this.Controls.Add(this.Btn_Turma_Aluno);
            this.Controls.Add(this.Btn_Turma_Enviar);
            this.Controls.Add(this.Txt_Turma_Periodo);
            this.Controls.Add(this.Lbl_Turma_Periodo);
            this.Controls.Add(this.Txt_Turma_Curso);
            this.Controls.Add(this.Lbl_Turma_Curso);
            this.Name = "Usc_CadastroTurma";
            this.Size = new System.Drawing.Size(754, 338);
            this.Load += new System.EventHandler(this.Usc_CadastroTurma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Turma_Curso;
        private System.Windows.Forms.Label Lbl_Turma_Curso;
        private System.Windows.Forms.Label Lbl_Turma_Periodo;
        private System.Windows.Forms.TextBox Txt_Turma_Periodo;
        private System.Windows.Forms.Button Btn_Turma_Enviar;
        private System.Windows.Forms.Button Btn_Turma_Aluno;
        private System.Windows.Forms.Button Btn_Turma_Buscar;
        private System.Windows.Forms.Label Lbl_Turma_Aluno;
        private System.Windows.Forms.TextBox Txt_Aluno_Lista;
        private System.Windows.Forms.Button Btn_Turma_Novo;
    }
}
