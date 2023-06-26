namespace Univap.Programacao3.Projeto.View
{
    partial class Frm_BuscarAula
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
            this.Btn_Aula_Enviar = new System.Windows.Forms.Button();
            this.Cbo_Aula_Lista = new System.Windows.Forms.ComboBox();
            this.Lbl_Aula_Lista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Aula_Enviar
            // 
            this.Btn_Aula_Enviar.Location = new System.Drawing.Point(262, 104);
            this.Btn_Aula_Enviar.Name = "Btn_Aula_Enviar";
            this.Btn_Aula_Enviar.Size = new System.Drawing.Size(94, 34);
            this.Btn_Aula_Enviar.TabIndex = 18;
            this.Btn_Aula_Enviar.Text = "Salvar";
            this.Btn_Aula_Enviar.UseVisualStyleBackColor = true;
            this.Btn_Aula_Enviar.Click += new System.EventHandler(this.Btn_Aula_Enviar_Click);
            // 
            // Cbo_Aula_Lista
            // 
            this.Cbo_Aula_Lista.FormattingEnabled = true;
            this.Cbo_Aula_Lista.Location = new System.Drawing.Point(23, 77);
            this.Cbo_Aula_Lista.Name = "Cbo_Aula_Lista";
            this.Cbo_Aula_Lista.Size = new System.Drawing.Size(333, 21);
            this.Cbo_Aula_Lista.TabIndex = 17;
            // 
            // Lbl_Aula_Lista
            // 
            this.Lbl_Aula_Lista.AutoSize = true;
            this.Lbl_Aula_Lista.Location = new System.Drawing.Point(20, 61);
            this.Lbl_Aula_Lista.Name = "Lbl_Aula_Lista";
            this.Lbl_Aula_Lista.Size = new System.Drawing.Size(81, 13);
            this.Lbl_Aula_Lista.TabIndex = 16;
            this.Lbl_Aula_Lista.Text = "Selecione Aula:";
            // 
            // Frm_BuscarAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 159);
            this.Controls.Add(this.Btn_Aula_Enviar);
            this.Controls.Add(this.Cbo_Aula_Lista);
            this.Controls.Add(this.Lbl_Aula_Lista);
            this.Name = "Frm_BuscarAula";
            this.Text = "Buscar Aula";
            this.Load += new System.EventHandler(this.Frm_BuscarAula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Aula_Enviar;
        private System.Windows.Forms.ComboBox Cbo_Aula_Lista;
        private System.Windows.Forms.Label Lbl_Aula_Lista;
    }
}