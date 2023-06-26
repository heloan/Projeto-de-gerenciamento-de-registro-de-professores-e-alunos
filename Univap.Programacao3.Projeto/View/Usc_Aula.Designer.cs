namespace Univap.Programacao3.Projeto.View
{
    partial class Usc_Aula
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
            this.Cbo_AulaFormulario_Disciplina = new System.Windows.Forms.ComboBox();
            this.Lbl_AulaFormulario_Disciplina = new System.Windows.Forms.Label();
            this.Dtp_AulaFormulario_Data = new System.Windows.Forms.DateTimePicker();
            this.Lbl_AulaFormulario_Data = new System.Windows.Forms.Label();
            this.Btn_Aula_Enviar = new System.Windows.Forms.Button();
            this.Clb_ListaPresensa_Alunos = new System.Windows.Forms.CheckedListBox();
            this.Lbl_ListaPresensa_Alunos = new System.Windows.Forms.Label();
            this.Btn_Aula_Buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cbo_AulaFormulario_Disciplina
            // 
            this.Cbo_AulaFormulario_Disciplina.FormattingEnabled = true;
            this.Cbo_AulaFormulario_Disciplina.Location = new System.Drawing.Point(17, 27);
            this.Cbo_AulaFormulario_Disciplina.Name = "Cbo_AulaFormulario_Disciplina";
            this.Cbo_AulaFormulario_Disciplina.Size = new System.Drawing.Size(496, 21);
            this.Cbo_AulaFormulario_Disciplina.TabIndex = 9;
            this.Cbo_AulaFormulario_Disciplina.Tag = "required";
            this.Cbo_AulaFormulario_Disciplina.SelectedIndexChanged += new System.EventHandler(this.Cbo_AulaFormulario_Disciplina_SelectedIndexChanged);
            // 
            // Lbl_AulaFormulario_Disciplina
            // 
            this.Lbl_AulaFormulario_Disciplina.AutoSize = true;
            this.Lbl_AulaFormulario_Disciplina.Location = new System.Drawing.Point(14, 11);
            this.Lbl_AulaFormulario_Disciplina.Name = "Lbl_AulaFormulario_Disciplina";
            this.Lbl_AulaFormulario_Disciplina.Size = new System.Drawing.Size(55, 13);
            this.Lbl_AulaFormulario_Disciplina.TabIndex = 8;
            this.Lbl_AulaFormulario_Disciplina.Tag = "required;";
            this.Lbl_AulaFormulario_Disciplina.Text = "Disciplina:";
            // 
            // Dtp_AulaFormulario_Data
            // 
            this.Dtp_AulaFormulario_Data.Location = new System.Drawing.Point(519, 27);
            this.Dtp_AulaFormulario_Data.Name = "Dtp_AulaFormulario_Data";
            this.Dtp_AulaFormulario_Data.Size = new System.Drawing.Size(217, 20);
            this.Dtp_AulaFormulario_Data.TabIndex = 10;
            // 
            // Lbl_AulaFormulario_Data
            // 
            this.Lbl_AulaFormulario_Data.AutoSize = true;
            this.Lbl_AulaFormulario_Data.Location = new System.Drawing.Point(516, 11);
            this.Lbl_AulaFormulario_Data.Name = "Lbl_AulaFormulario_Data";
            this.Lbl_AulaFormulario_Data.Size = new System.Drawing.Size(33, 13);
            this.Lbl_AulaFormulario_Data.TabIndex = 11;
            this.Lbl_AulaFormulario_Data.Tag = "required;";
            this.Lbl_AulaFormulario_Data.Text = "Data:";
            // 
            // Btn_Aula_Enviar
            // 
            this.Btn_Aula_Enviar.Location = new System.Drawing.Point(642, 291);
            this.Btn_Aula_Enviar.Name = "Btn_Aula_Enviar";
            this.Btn_Aula_Enviar.Size = new System.Drawing.Size(94, 34);
            this.Btn_Aula_Enviar.TabIndex = 12;
            this.Btn_Aula_Enviar.Text = "Enviar";
            this.Btn_Aula_Enviar.UseVisualStyleBackColor = true;
            this.Btn_Aula_Enviar.Click += new System.EventHandler(this.Btn_Disciplina_Enviar_Click);
            // 
            // Clb_ListaPresensa_Alunos
            // 
            this.Clb_ListaPresensa_Alunos.FormattingEnabled = true;
            this.Clb_ListaPresensa_Alunos.Location = new System.Drawing.Point(17, 67);
            this.Clb_ListaPresensa_Alunos.Name = "Clb_ListaPresensa_Alunos";
            this.Clb_ListaPresensa_Alunos.Size = new System.Drawing.Size(719, 214);
            this.Clb_ListaPresensa_Alunos.TabIndex = 13;
            // 
            // Lbl_ListaPresensa_Alunos
            // 
            this.Lbl_ListaPresensa_Alunos.AutoSize = true;
            this.Lbl_ListaPresensa_Alunos.Location = new System.Drawing.Point(14, 51);
            this.Lbl_ListaPresensa_Alunos.Name = "Lbl_ListaPresensa_Alunos";
            this.Lbl_ListaPresensa_Alunos.Size = new System.Drawing.Size(79, 13);
            this.Lbl_ListaPresensa_Alunos.TabIndex = 14;
            this.Lbl_ListaPresensa_Alunos.Tag = "required;";
            this.Lbl_ListaPresensa_Alunos.Text = "Lista Presensa:";
            // 
            // Btn_Aula_Buscar
            // 
            this.Btn_Aula_Buscar.Location = new System.Drawing.Point(17, 291);
            this.Btn_Aula_Buscar.Name = "Btn_Aula_Buscar";
            this.Btn_Aula_Buscar.Size = new System.Drawing.Size(94, 34);
            this.Btn_Aula_Buscar.TabIndex = 17;
            this.Btn_Aula_Buscar.Text = "Buscar";
            this.Btn_Aula_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Aula_Buscar.Click += new System.EventHandler(this.Btn_Aula_Buscar_Click);
            // 
            // Usc_Aula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Aula_Buscar);
            this.Controls.Add(this.Lbl_ListaPresensa_Alunos);
            this.Controls.Add(this.Clb_ListaPresensa_Alunos);
            this.Controls.Add(this.Btn_Aula_Enviar);
            this.Controls.Add(this.Lbl_AulaFormulario_Data);
            this.Controls.Add(this.Dtp_AulaFormulario_Data);
            this.Controls.Add(this.Cbo_AulaFormulario_Disciplina);
            this.Controls.Add(this.Lbl_AulaFormulario_Disciplina);
            this.Name = "Usc_Aula";
            this.Size = new System.Drawing.Size(754, 338);
            this.Load += new System.EventHandler(this.Usc_Aula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbo_AulaFormulario_Disciplina;
        private System.Windows.Forms.Label Lbl_AulaFormulario_Disciplina;
        private System.Windows.Forms.DateTimePicker Dtp_AulaFormulario_Data;
        private System.Windows.Forms.Label Lbl_AulaFormulario_Data;
        private System.Windows.Forms.Button Btn_Aula_Enviar;
        private System.Windows.Forms.CheckedListBox Clb_ListaPresensa_Alunos;
        private System.Windows.Forms.Label Lbl_ListaPresensa_Alunos;
        private System.Windows.Forms.Button Btn_Aula_Buscar;
    }
}
