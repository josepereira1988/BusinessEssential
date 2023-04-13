namespace BusinessEssential
{
    partial class FrmLogin
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.cbEmpresas = new System.Windows.Forms.ComboBox();
            this.labelbe1 = new Essential.LabelBE();
            this.labelbe2 = new Essential.LabelBE();
            this.labelbe3 = new Essential.LabelBE();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(118, 54);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(152, 23);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(118, 83);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(152, 23);
            this.txtSenha.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(75, 159);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(191, 159);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // cbEmpresas
            // 
            this.cbEmpresas.FormattingEnabled = true;
            this.cbEmpresas.Location = new System.Drawing.Point(118, 112);
            this.cbEmpresas.Name = "cbEmpresas";
            this.cbEmpresas.Size = new System.Drawing.Size(152, 23);
            this.cbEmpresas.TabIndex = 4;
            // 
            // labelbe1
            // 
            this.labelbe1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelbe1.Location = new System.Drawing.Point(51, 63);
            this.labelbe1.Name = "labelbe1";
            this.labelbe1.Size = new System.Drawing.Size(64, 14);
            this.labelbe1.TabIndex = 8;
            this.labelbe1.Text = "Usuario";
            // 
            // labelbe2
            // 
            this.labelbe2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelbe2.Location = new System.Drawing.Point(51, 92);
            this.labelbe2.Name = "labelbe2";
            this.labelbe2.Size = new System.Drawing.Size(64, 14);
            this.labelbe2.TabIndex = 9;
            this.labelbe2.Text = "Senha";
            // 
            // labelbe3
            // 
            this.labelbe3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelbe3.Location = new System.Drawing.Point(51, 121);
            this.labelbe3.Name = "labelbe3";
            this.labelbe3.Size = new System.Drawing.Size(64, 14);
            this.labelbe3.TabIndex = 10;
            this.labelbe3.Text = "Empresa";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 237);
            this.ControlBox = false;
            this.Controls.Add(this.labelbe3);
            this.Controls.Add(this.labelbe2);
            this.Controls.Add(this.labelbe1);
            this.Controls.Add(this.cbEmpresas);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Essencial Bussines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnLogin;
        private Button btnSair;
        private ComboBox cbEmpresas;
        private Essential.LabelBE labelbe1;
        private Essential.LabelBE labelbe2;
        private Essential.LabelBE labelbe3;
    }
}