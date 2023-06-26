namespace Univap.Programacao3.Projeto.View
{
    partial class Frm_BuscarDisciplina
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
            this.Btn_Disiplinas_Enviar = new System.Windows.Forms.Button();
            this.Cbo_Disciplina_Lista = new System.Windows.Forms.ComboBox();
            this.Lbl_Disciplina_Lista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Disiplinas_Enviar
            // 
            this.Btn_Disiplinas_Enviar.Location = new System.Drawing.Point(262, 103);
            this.Btn_Disiplinas_Enviar.Name = "Btn_Disiplinas_Enviar";
            this.Btn_Disiplinas_Enviar.Size = new System.Drawing.Size(94, 34);
            this.Btn_Disiplinas_Enviar.TabIndex = 18;
            this.Btn_Disiplinas_Enviar.Text = "Salvar";
            this.Btn_Disiplinas_Enviar.UseVisualStyleBackColor = true;
            this.Btn_Disiplinas_Enviar.Click += new System.EventHandler(this.Btn_Disiplinas_Enviar_Click);
            // 
            // Cbo_Disciplina_Lista
            // 
            this.Cbo_Disciplina_Lista.FormattingEnabled = true;
            this.Cbo_Disciplina_Lista.Location = new System.Drawing.Point(23, 76);
            this.Cbo_Disciplina_Lista.Name = "Cbo_Disciplina_Lista";
            this.Cbo_Disciplina_Lista.Size = new System.Drawing.Size(333, 21);
            this.Cbo_Disciplina_Lista.TabIndex = 17;
            // 
            // Lbl_Disciplina_Lista
            // 
            this.Lbl_Disciplina_Lista.AutoSize = true;
            this.Lbl_Disciplina_Lista.Location = new System.Drawing.Point(20, 60);
            this.Lbl_Disciplina_Lista.Name = "Lbl_Disciplina_Lista";
            this.Lbl_Disciplina_Lista.Size = new System.Drawing.Size(105, 13);
            this.Lbl_Disciplina_Lista.TabIndex = 16;
            this.Lbl_Disciplina_Lista.Text = "Selecione Disciplina:";
            // 
            // Frm_BuscarDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 159);
            this.Controls.Add(this.Btn_Disiplinas_Enviar);
            this.Controls.Add(this.Cbo_Disciplina_Lista);
            this.Controls.Add(this.Lbl_Disciplina_Lista);
            this.Name = "Frm_BuscarDisciplina";
            this.Text = "Buscar Disciplina";
            this.Load += new System.EventHandler(this.Frm_BuscarDisciplina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Disiplinas_Enviar;
        private System.Windows.Forms.ComboBox Cbo_Disciplina_Lista;
        private System.Windows.Forms.Label Lbl_Disciplina_Lista;
    }
}