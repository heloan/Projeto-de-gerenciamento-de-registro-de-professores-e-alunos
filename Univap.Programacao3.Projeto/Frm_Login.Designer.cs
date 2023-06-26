namespace Univap.Programacao3.Projeto
{
    partial class Frm_Login
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
            this.Lbl_Login_User = new System.Windows.Forms.Label();
            this.Txt_Login_User = new System.Windows.Forms.TextBox();
            this.Txt_Login_Password = new System.Windows.Forms.TextBox();
            this.Lbl_Login_Password = new System.Windows.Forms.Label();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Login_User
            // 
            this.Lbl_Login_User.AutoSize = true;
            this.Lbl_Login_User.Location = new System.Drawing.Point(24, 64);
            this.Lbl_Login_User.Name = "Lbl_Login_User";
            this.Lbl_Login_User.Size = new System.Drawing.Size(38, 13);
            this.Lbl_Login_User.TabIndex = 0;
            this.Lbl_Login_User.Text = "E-mail:";
            // 
            // Txt_Login_User
            // 
            this.Txt_Login_User.Location = new System.Drawing.Point(27, 81);
            this.Txt_Login_User.Name = "Txt_Login_User";
            this.Txt_Login_User.Size = new System.Drawing.Size(176, 20);
            this.Txt_Login_User.TabIndex = 1;
            this.Txt_Login_User.Tag = "required";
            // 
            // Txt_Login_Password
            // 
            this.Txt_Login_Password.Location = new System.Drawing.Point(27, 120);
            this.Txt_Login_Password.Name = "Txt_Login_Password";
            this.Txt_Login_Password.PasswordChar = '*';
            this.Txt_Login_Password.Size = new System.Drawing.Size(176, 20);
            this.Txt_Login_Password.TabIndex = 3;
            this.Txt_Login_Password.Tag = "required";
            // 
            // Lbl_Login_Password
            // 
            this.Lbl_Login_Password.AutoSize = true;
            this.Lbl_Login_Password.Location = new System.Drawing.Point(24, 104);
            this.Lbl_Login_Password.Name = "Lbl_Login_Password";
            this.Lbl_Login_Password.Size = new System.Drawing.Size(41, 13);
            this.Lbl_Login_Password.TabIndex = 2;
            this.Lbl_Login_Password.Text = "Senha:";
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(128, 146);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(75, 23);
            this.Btn_Login.TabIndex = 4;
            this.Btn_Login.Text = "Logar";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Frm_Login
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(229, 204);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Txt_Login_Password);
            this.Controls.Add(this.Lbl_Login_Password);
            this.Controls.Add(this.Txt_Login_User);
            this.Controls.Add(this.Lbl_Login_User);
            this.Name = "Frm_Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Login_User;
        private System.Windows.Forms.TextBox Txt_Login_User;
        private System.Windows.Forms.TextBox Txt_Login_Password;
        private System.Windows.Forms.Label Lbl_Login_Password;
        private System.Windows.Forms.Button Btn_Login;
    }
}

