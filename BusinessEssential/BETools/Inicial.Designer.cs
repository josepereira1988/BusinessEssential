namespace BETools
{
    partial class Inicial
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
            this.btnInicial = new System.Windows.Forms.Button();
            this.btnCriarBanco = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCriarTb = new System.Windows.Forms.Button();
            this.btnAtualizarDB = new System.Windows.Forms.Button();
            this.btnGerarQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInicial
            // 
            this.btnInicial.Location = new System.Drawing.Point(38, 39);
            this.btnInicial.Name = "btnInicial";
            this.btnInicial.Size = new System.Drawing.Size(90, 41);
            this.btnInicial.TabIndex = 0;
            this.btnInicial.Text = "Configuração Incial";
            this.btnInicial.UseVisualStyleBackColor = true;
            this.btnInicial.Click += new System.EventHandler(this.btnInicial_Click);
            // 
            // btnCriarBanco
            // 
            this.btnCriarBanco.Location = new System.Drawing.Point(152, 39);
            this.btnCriarBanco.Name = "btnCriarBanco";
            this.btnCriarBanco.Size = new System.Drawing.Size(90, 41);
            this.btnCriarBanco.TabIndex = 1;
            this.btnCriarBanco.Text = "Criar Banco";
            this.btnCriarBanco.UseVisualStyleBackColor = true;
            this.btnCriarBanco.Click += new System.EventHandler(this.btnCriarBanco_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(266, 39);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(90, 41);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Login DB";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCriarTb
            // 
            this.btnCriarTb.Location = new System.Drawing.Point(38, 95);
            this.btnCriarTb.Name = "btnCriarTb";
            this.btnCriarTb.Size = new System.Drawing.Size(90, 41);
            this.btnCriarTb.TabIndex = 3;
            this.btnCriarTb.Text = "Criar Tabela";
            this.btnCriarTb.UseVisualStyleBackColor = true;
            this.btnCriarTb.Click += new System.EventHandler(this.btnCriarTb_Click);
            // 
            // btnAtualizarDB
            // 
            this.btnAtualizarDB.Location = new System.Drawing.Point(152, 95);
            this.btnAtualizarDB.Name = "btnAtualizarDB";
            this.btnAtualizarDB.Size = new System.Drawing.Size(90, 41);
            this.btnAtualizarDB.TabIndex = 4;
            this.btnAtualizarDB.Text = "Atualizar banco";
            this.btnAtualizarDB.UseVisualStyleBackColor = true;
            this.btnAtualizarDB.Click += new System.EventHandler(this.btnAtualizarDB_Click);
            // 
            // btnGerarQuery
            // 
            this.btnGerarQuery.Location = new System.Drawing.Point(266, 95);
            this.btnGerarQuery.Name = "btnGerarQuery";
            this.btnGerarQuery.Size = new System.Drawing.Size(90, 41);
            this.btnGerarQuery.TabIndex = 5;
            this.btnGerarQuery.Text = "Gerar Query";
            this.btnGerarQuery.UseVisualStyleBackColor = true;
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 177);
            this.Controls.Add(this.btnGerarQuery);
            this.Controls.Add(this.btnAtualizarDB);
            this.Controls.Add(this.btnCriarTb);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCriarBanco);
            this.Controls.Add(this.btnInicial);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicial";
            this.ShowIcon = false;
            this.Text = "Administração BE";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnInicial;
        private Button btnCriarBanco;
        private Button btnAtualizar;
        private Button btnCriarTb;
        private Button btnAtualizarDB;
        private Button btnGerarQuery;
    }
}