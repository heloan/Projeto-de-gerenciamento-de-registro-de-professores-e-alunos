namespace Univap.Programacao3.Projeto.View
{
    partial class Frm_BuscarTurma
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Turmas_Enviar = new System.Windows.Forms.Button();
            this.Cbo_Turmas_Nome = new System.Windows.Forms.ComboBox();
            this.Lbl_Alunos_Nomes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Turmas_Enviar
            // 
            this.Btn_Turmas_Enviar.Location = new System.Drawing.Point(265, 103);
            this.Btn_Turmas_Enviar.Name = "Btn_Turmas_Enviar";
            this.Btn_Turmas_Enviar.Size = new System.Drawing.Size(94, 34);
            this.Btn_Turmas_Enviar.TabIndex = 12;
            this.Btn_Turmas_Enviar.Text = "Salvar";
            this.Btn_Turmas_Enviar.UseVisualStyleBackColor = true;
            this.Btn_Turmas_Enviar.Click += new System.EventHandler(this.Btn_Turmas_Enviar_Click);
            // 
            // Cbo_Turmas_Nome
            // 
            this.Cbo_Turmas_Nome.FormattingEnabled = true;
            this.Cbo_Turmas_Nome.Location = new System.Drawing.Point(26, 76);
            this.Cbo_Turmas_Nome.Name = "Cbo_Turmas_Nome";
            this.Cbo_Turmas_Nome.Size = new System.Drawing.Size(333, 21);
            this.Cbo_Turmas_Nome.TabIndex = 11;
            // 
            // Lbl_Alunos_Nomes
            // 
            this.Lbl_Alunos_Nomes.AutoSize = true;
            this.Lbl_Alunos_Nomes.Location = new System.Drawing.Point(23, 60);
            this.Lbl_Alunos_Nomes.Name = "Lbl_Alunos_Nomes";
            this.Lbl_Alunos_Nomes.Size = new System.Drawing.Size(90, 13);
            this.Lbl_Alunos_Nomes.TabIndex = 10;
            this.Lbl_Alunos_Nomes.Text = "Selecione Turma:";
            // 
            // Frm_BuscarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 159);
            this.Controls.Add(this.Btn_Turmas_Enviar);
            this.Controls.Add(this.Cbo_Turmas_Nome);
            this.Controls.Add(this.Lbl_Alunos_Nomes);
            this.Name = "Frm_BuscarTurma";
            this.Text = "Buscar Turma";
            this.Load += new System.EventHandler(this.Frm_BuscarTurma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Turmas_Enviar;
        private System.Windows.Forms.ComboBox Cbo_Turmas_Nome;
        private System.Windows.Forms.Label Lbl_Alunos_Nomes;
    }
}