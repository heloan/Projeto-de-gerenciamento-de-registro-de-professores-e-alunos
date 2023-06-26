namespace Univap.Programacao3.Projeto.View
{
    partial class Usc_CadastroPessoas
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
            this.Lbl_Pessoa_Nome = new System.Windows.Forms.Label();
            this.Txt_Pessoa_Nome = new System.Windows.Forms.TextBox();
            this.Txt_Pessoa_Email = new System.Windows.Forms.TextBox();
            this.Lbl_Pessoa_Email = new System.Windows.Forms.Label();
            this.Txt_Pessoa_RA = new System.Windows.Forms.TextBox();
            this.Lbl_Pessoa_RA = new System.Windows.Forms.Label();
            this.Lbl_Pessoa_Type = new System.Windows.Forms.Label();
            this.Cbo_Pessoa_Type = new System.Windows.Forms.ComboBox();
            this.Btn_Pessoa_Enviar = new System.Windows.Forms.Button();
            this.Txt_Login_Password = new System.Windows.Forms.TextBox();
            this.Lbl_Login_Password = new System.Windows.Forms.Label();
            this.Btn_Pessoa_Buscar = new System.Windows.Forms.Button();
            this.Btn_Pessoa_Novo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Pessoa_Nome
            // 
            this.Lbl_Pessoa_Nome.AutoSize = true;
            this.Lbl_Pessoa_Nome.Location = new System.Drawing.Point(14, 11);
            this.Lbl_Pessoa_Nome.Name = "Lbl_Pessoa_Nome";
            this.Lbl_Pessoa_Nome.Size = new System.Drawing.Size(38, 13);
            this.Lbl_Pessoa_Nome.TabIndex = 0;
            this.Lbl_Pessoa_Nome.Text = "Nome:";
            // 
            // Txt_Pessoa_Nome
            // 
            this.Txt_Pessoa_Nome.Location = new System.Drawing.Point(17, 28);
            this.Txt_Pessoa_Nome.Name = "Txt_Pessoa_Nome";
            this.Txt_Pessoa_Nome.Size = new System.Drawing.Size(719, 20);
            this.Txt_Pessoa_Nome.TabIndex = 1;
            this.Txt_Pessoa_Nome.Tag = "required";
            // 
            // Txt_Pessoa_Email
            // 
            this.Txt_Pessoa_Email.Location = new System.Drawing.Point(17, 68);
            this.Txt_Pessoa_Email.Name = "Txt_Pessoa_Email";
            this.Txt_Pessoa_Email.Size = new System.Drawing.Size(719, 20);
            this.Txt_Pessoa_Email.TabIndex = 3;
            this.Txt_Pessoa_Email.Tag = "required";
            // 
            // Lbl_Pessoa_Email
            // 
            this.Lbl_Pessoa_Email.AutoSize = true;
            this.Lbl_Pessoa_Email.Location = new System.Drawing.Point(14, 51);
            this.Lbl_Pessoa_Email.Name = "Lbl_Pessoa_Email";
            this.Lbl_Pessoa_Email.Size = new System.Drawing.Size(38, 13);
            this.Lbl_Pessoa_Email.TabIndex = 2;
            this.Lbl_Pessoa_Email.Text = "E-mail:";
            // 
            // Txt_Pessoa_RA
            // 
            this.Txt_Pessoa_RA.Location = new System.Drawing.Point(17, 148);
            this.Txt_Pessoa_RA.Name = "Txt_Pessoa_RA";
            this.Txt_Pessoa_RA.Size = new System.Drawing.Size(719, 20);
            this.Txt_Pessoa_RA.TabIndex = 5;
            this.Txt_Pessoa_RA.Tag = "required";
            // 
            // Lbl_Pessoa_RA
            // 
            this.Lbl_Pessoa_RA.AutoSize = true;
            this.Lbl_Pessoa_RA.Location = new System.Drawing.Point(14, 131);
            this.Lbl_Pessoa_RA.Name = "Lbl_Pessoa_RA";
            this.Lbl_Pessoa_RA.Size = new System.Drawing.Size(25, 13);
            this.Lbl_Pessoa_RA.TabIndex = 4;
            this.Lbl_Pessoa_RA.Text = "RA:";
            // 
            // Lbl_Pessoa_Type
            // 
            this.Lbl_Pessoa_Type.AutoSize = true;
            this.Lbl_Pessoa_Type.Location = new System.Drawing.Point(14, 171);
            this.Lbl_Pessoa_Type.Name = "Lbl_Pessoa_Type";
            this.Lbl_Pessoa_Type.Size = new System.Drawing.Size(31, 13);
            this.Lbl_Pessoa_Type.TabIndex = 6;
            this.Lbl_Pessoa_Type.Text = "Tipo:";
            // 
            // Cbo_Pessoa_Type
            // 
            this.Cbo_Pessoa_Type.FormattingEnabled = true;
            this.Cbo_Pessoa_Type.Items.AddRange(new object[] {
            "Professor",
            "Aluno"});
            this.Cbo_Pessoa_Type.Location = new System.Drawing.Point(17, 188);
            this.Cbo_Pessoa_Type.Name = "Cbo_Pessoa_Type";
            this.Cbo_Pessoa_Type.Size = new System.Drawing.Size(719, 21);
            this.Cbo_Pessoa_Type.TabIndex = 7;
            this.Cbo_Pessoa_Type.Tag = "required;index";
            // 
            // Btn_Pessoa_Enviar
            // 
            this.Btn_Pessoa_Enviar.Location = new System.Drawing.Point(642, 291);
            this.Btn_Pessoa_Enviar.Name = "Btn_Pessoa_Enviar";
            this.Btn_Pessoa_Enviar.Size = new System.Drawing.Size(94, 34);
            this.Btn_Pessoa_Enviar.TabIndex = 8;
            this.Btn_Pessoa_Enviar.Text = "Enviar";
            this.Btn_Pessoa_Enviar.UseVisualStyleBackColor = true;
            this.Btn_Pessoa_Enviar.Click += new System.EventHandler(this.Btn_Pessoa_Enviar_Click);
            // 
            // Txt_Login_Password
            // 
            this.Txt_Login_Password.Location = new System.Drawing.Point(17, 108);
            this.Txt_Login_Password.Name = "Txt_Login_Password";
            this.Txt_Login_Password.Size = new System.Drawing.Size(719, 20);
            this.Txt_Login_Password.TabIndex = 10;
            this.Txt_Login_Password.Tag = "required";
            // 
            // Lbl_Login_Password
            // 
            this.Lbl_Login_Password.AutoSize = true;
            this.Lbl_Login_Password.Location = new System.Drawing.Point(14, 91);
            this.Lbl_Login_Password.Name = "Lbl_Login_Password";
            this.Lbl_Login_Password.Size = new System.Drawing.Size(41, 13);
            this.Lbl_Login_Password.TabIndex = 9;
            this.Lbl_Login_Password.Text = "Senha:";
            // 
            // Btn_Pessoa_Buscar
            // 
            this.Btn_Pessoa_Buscar.Location = new System.Drawing.Point(17, 291);
            this.Btn_Pessoa_Buscar.Name = "Btn_Pessoa_Buscar";
            this.Btn_Pessoa_Buscar.Size = new System.Drawing.Size(94, 34);
            this.Btn_Pessoa_Buscar.TabIndex = 11;
            this.Btn_Pessoa_Buscar.Text = "Buscar";
            this.Btn_Pessoa_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Pessoa_Buscar.Click += new System.EventHandler(this.Btn_Pessoa_Buscar_Click);
            // 
            // Btn_Pessoa_Novo
            // 
            this.Btn_Pessoa_Novo.Location = new System.Drawing.Point(117, 291);
            this.Btn_Pessoa_Novo.Name = "Btn_Pessoa_Novo";
            this.Btn_Pessoa_Novo.Size = new System.Drawing.Size(94, 34);
            this.Btn_Pessoa_Novo.TabIndex = 12;
            this.Btn_Pessoa_Novo.Text = "Novo";
            this.Btn_Pessoa_Novo.UseVisualStyleBackColor = true;
            this.Btn_Pessoa_Novo.Click += new System.EventHandler(this.Btn_Pessoa_Novo_Click);
            // 
            // Usc_CadastroPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Pessoa_Novo);
            this.Controls.Add(this.Btn_Pessoa_Buscar);
            this.Controls.Add(this.Txt_Login_Password);
            this.Controls.Add(this.Lbl_Login_Password);
            this.Controls.Add(this.Btn_Pessoa_Enviar);
            this.Controls.Add(this.Cbo_Pessoa_Type);
            this.Controls.Add(this.Lbl_Pessoa_Type);
            this.Controls.Add(this.Txt_Pessoa_RA);
            this.Controls.Add(this.Lbl_Pessoa_RA);
            this.Controls.Add(this.Txt_Pessoa_Email);
            this.Controls.Add(this.Lbl_Pessoa_Email);
            this.Controls.Add(this.Txt_Pessoa_Nome);
            this.Controls.Add(this.Lbl_Pessoa_Nome);
            this.Margin = new System.Windows.Forms.Padding(15);
            this.Name = "Usc_CadastroPessoas";
            this.Size = new System.Drawing.Size(754, 338);
            this.Load += new System.EventHandler(this.Usr_CadastroPessoas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Pessoa_Nome;
        private System.Windows.Forms.TextBox Txt_Pessoa_Nome;
        private System.Windows.Forms.TextBox Txt_Pessoa_Email;
        private System.Windows.Forms.Label Lbl_Pessoa_Email;
        private System.Windows.Forms.TextBox Txt_Pessoa_RA;
        private System.Windows.Forms.Label Lbl_Pessoa_RA;
        private System.Windows.Forms.Label Lbl_Pessoa_Type;
        private System.Windows.Forms.ComboBox Cbo_Pessoa_Type;
        private System.Windows.Forms.Button Btn_Pessoa_Enviar;
        private System.Windows.Forms.TextBox Txt_Login_Password;
        private System.Windows.Forms.Label Lbl_Login_Password;
        private System.Windows.Forms.Button Btn_Pessoa_Buscar;
        private System.Windows.Forms.Button Btn_Pessoa_Novo;
    }
}
