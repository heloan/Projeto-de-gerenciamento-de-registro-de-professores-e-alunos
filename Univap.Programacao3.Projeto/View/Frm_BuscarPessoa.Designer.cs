namespace Univap.Programacao3.Projeto.View
{
    partial class Frm_BuscarPessoa
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
            this.Btn_Pessoas_Enviar = new System.Windows.Forms.Button();
            this.Cbo_Pessoas_Lista = new System.Windows.Forms.ComboBox();
            this.Lbl_Pessoas_Lista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Pessoas_Enviar
            // 
            this.Btn_Pessoas_Enviar.Location = new System.Drawing.Point(265, 101);
            this.Btn_Pessoas_Enviar.Name = "Btn_Pessoas_Enviar";
            this.Btn_Pessoas_Enviar.Size = new System.Drawing.Size(94, 34);
            this.Btn_Pessoas_Enviar.TabIndex = 15;
            this.Btn_Pessoas_Enviar.Text = "Salvar";
            this.Btn_Pessoas_Enviar.UseVisualStyleBackColor = true;
            this.Btn_Pessoas_Enviar.Click += new System.EventHandler(this.Btn_Pessoas_Enviar_Click);
            // 
            // Cbo_Pessoas_Lista
            // 
            this.Cbo_Pessoas_Lista.FormattingEnabled = true;
            this.Cbo_Pessoas_Lista.Location = new System.Drawing.Point(26, 74);
            this.Cbo_Pessoas_Lista.Name = "Cbo_Pessoas_Lista";
            this.Cbo_Pessoas_Lista.Size = new System.Drawing.Size(333, 21);
            this.Cbo_Pessoas_Lista.TabIndex = 14;
            this.Cbo_Pessoas_Lista.SelectedIndexChanged += new System.EventHandler(this.Cbo_Pessoas_Lista_SelectedIndexChanged);
            // 
            // Lbl_Pessoas_Lista
            // 
            this.Lbl_Pessoas_Lista.AutoSize = true;
            this.Lbl_Pessoas_Lista.Location = new System.Drawing.Point(23, 58);
            this.Lbl_Pessoas_Lista.Name = "Lbl_Pessoas_Lista";
            this.Lbl_Pessoas_Lista.Size = new System.Drawing.Size(95, 13);
            this.Lbl_Pessoas_Lista.TabIndex = 13;
            this.Lbl_Pessoas_Lista.Text = "Selecione Pessoa:";
            this.Lbl_Pessoas_Lista.Click += new System.EventHandler(this.Lbl_Pessoas_Lista_Click);
            // 
            // Frm_BuscarPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 159);
            this.Controls.Add(this.Btn_Pessoas_Enviar);
            this.Controls.Add(this.Cbo_Pessoas_Lista);
            this.Controls.Add(this.Lbl_Pessoas_Lista);
            this.Name = "Frm_BuscarPessoa";
            this.Text = "Buscar Pessoa";
            this.Load += new System.EventHandler(this.Frm_BuscarPessoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Pessoas_Enviar;
        private System.Windows.Forms.ComboBox Cbo_Pessoas_Lista;
        private System.Windows.Forms.Label Lbl_Pessoas_Lista;
    }
}