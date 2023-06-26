namespace Univap.Programacao3.Projeto
{
    partial class Frm_Main
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
            this.Tbc_Main = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // Tbc_Main
            // 
            this.Tbc_Main.Location = new System.Drawing.Point(23, 63);
            this.Tbc_Main.Name = "Tbc_Main";
            this.Tbc_Main.SelectedIndex = 0;
            this.Tbc_Main.Size = new System.Drawing.Size(754, 364);
            this.Tbc_Main.TabIndex = 0;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tbc_Main);
            this.Name = "Frm_Main";
            this.Text = "Controle de Presença";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tbc_Main;
    }
}