using Essential;

namespace BusinessEssential.Modulos.Administracao.Usuarios
{
    partial class FrmUsuarios
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
            this.txtID = new Essential.TextBoxBE();
            this.txtSenha = new Essential.TextBoxBE();
            this.txtNome = new Essential.TextBoxBE();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.rbAtivo = new Essential.RadioButtonBE();
            this.rbInativo = new Essential.RadioButtonBE();
            this.lblID = new Essential.LabelBE();
            this.lblUsuario = new Essential.LabelBE();
            this.txtUsuario = new Essential.TextBoxBE();
            this.lblNome = new Essential.LabelBE();
            this.labelbe1 = new Essential.LabelBE();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Campo = "Id";
            this.txtID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(108, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 22);
            this.txtID.Tabela = "BEUsers";
            this.txtID.TabIndex = 0;
            this.txtID.Tag = "";
            // 
            // txtSenha
            // 
            this.txtSenha.Campo = "Senha";
            this.txtSenha.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenha.Location = new System.Drawing.Point(108, 99);
            this.txtSenha.MaxLength = 14;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(122, 22);
            this.txtSenha.Tabela = "BEUsers";
            this.txtSenha.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Campo = "Nome";
            this.txtNome.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(108, 70);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(122, 22);
            this.txtNome.Tabela = "BEUsers";
            this.txtNome.TabIndex = 2;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(27, 205);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(147, 205);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "button2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Campo = "Ativo";
            this.rbAtivo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbAtivo.Location = new System.Drawing.Point(27, 141);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(51, 18);
            this.rbAtivo.Tabela = "BEUsers";
            this.rbAtivo.TabIndex = 4;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Campo = "Inativo";
            this.rbInativo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbInativo.Location = new System.Drawing.Point(27, 166);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(62, 18);
            this.rbInativo.Tabela = "BEUsers";
            this.rbInativo.TabIndex = 5;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(21, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(84, 14);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(21, 50);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(84, 14);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Campo = "Usuario";
            this.txtUsuario.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.Location = new System.Drawing.Point(108, 42);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(122, 22);
            this.txtUsuario.Tabela = "BEUsers";
            this.txtUsuario.TabIndex = 10;
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(21, 78);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(84, 14);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome";
            // 
            // labelbe1
            // 
            this.labelbe1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelbe1.Location = new System.Drawing.Point(21, 107);
            this.labelbe1.Name = "labelbe1";
            this.labelbe1.Size = new System.Drawing.Size(84, 14);
            this.labelbe1.TabIndex = 12;
            this.labelbe1.Text = "Senha";
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 261);
            this.Controls.Add(this.labelbe1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.rbInativo);
            this.Controls.Add(this.rbAtivo);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuarios";
            this.sform = Essential.Statusforms.Procurar;
            this.ShowIcon = false;
            this.Tabela = "BEUsers";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxBE txtID;
        private TextBoxBE txtSenha;
        private TextBoxBE txtNome;
        private Button btn1;
        private Button btn2;
        private RadioButtonBE rbAtivo;
        private RadioButtonBE rbInativo;
        private LabelBE lblID;
        private LabelBE lblUsuario;
        private TextBoxBE txtUsuario;
        private LabelBE lblNome;
        private LabelBE labelbe1;
    }
}