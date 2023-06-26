namespace Univap.Programacao3.Projeto.View
{
    partial class Frm_CadastroAluno
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
            this.Lbl_Alunos_Nomes = new System.Windows.Forms.Label();
            this.Cbo_Alunos_Nomes = new System.Windows.Forms.ComboBox();
            this.Btn_Alunos_Enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Alunos_Nomes
            // 
            this.Lbl_Alunos_Nomes.AutoSize = true;
            this.Lbl_Alunos_Nomes.Location = new System.Drawing.Point(23, 60);
            this.Lbl_Alunos_Nomes.Name = "Lbl_Alunos_Nomes";
            this.Lbl_Alunos_Nomes.Size = new System.Drawing.Size(87, 13);
            this.Lbl_Alunos_Nomes.TabIndex = 1;
            this.Lbl_Alunos_Nomes.Text = "Selecione Aluno:";
            // 
            // Cbo_Alunos_Nomes
            // 
            this.Cbo_Alunos_Nomes.FormattingEnabled = true;
            this.Cbo_Alunos_Nomes.Location = new System.Drawing.Point(26, 76);
            this.Cbo_Alunos_Nomes.Name = "Cbo_Alunos_Nomes";
            this.Cbo_Alunos_Nomes.Size = new System.Drawing.Size(251, 21);
            this.Cbo_Alunos_Nomes.TabIndex = 2;
            // 
            // Btn_Alunos_Enviar
            // 
            this.Btn_Alunos_Enviar.Location = new System.Drawing.Point(183, 103);
            this.Btn_Alunos_Enviar.Name = "Btn_Alunos_Enviar";
            this.Btn_Alunos_Enviar.Size = new System.Drawing.Size(94, 34);
            this.Btn_Alunos_Enviar.TabIndex = 9;
            this.Btn_Alunos_Enviar.Text = "Salvar";
            this.Btn_Alunos_Enviar.UseVisualStyleBackColor = true;
            this.Btn_Alunos_Enviar.Click += new System.EventHandler(this.Btn_Alunos_Enviar_Click);
            // 
            // Frm_CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 160);
            this.Controls.Add(this.Btn_Alunos_Enviar);
            this.Controls.Add(this.Cbo_Alunos_Nomes);
            this.Controls.Add(this.Lbl_Alunos_Nomes);
            this.Name = "Frm_CadastroAluno";
            this.Text = "Adicionar Aluno";
            this.Load += new System.EventHandler(this.Frm_CadastroAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Alunos_Nomes;
        private System.Windows.Forms.ComboBox Cbo_Alunos_Nomes;
        private System.Windows.Forms.Button Btn_Alunos_Enviar;
    }
}