namespace BETools
{
    partial class FrmCriarCampo
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
            this.txtTabela = new System.Windows.Forms.TextBox();
            this.txtNomaCampo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoCampo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckPrimarykey = new System.Windows.Forms.CheckBox();
            this.ckNotnull = new System.Windows.Forms.CheckBox();
            this.ckAutoIncremento = new System.Windows.Forms.CheckBox();
            this.ckUnico = new System.Windows.Forms.CheckBox();
            this.ckEstrangeira = new System.Windows.Forms.CheckBox();
            this.cbTabelaPai = new System.Windows.Forms.ComboBox();
            this.cbCPai = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTabela
            // 
            this.txtTabela.Location = new System.Drawing.Point(12, 24);
            this.txtTabela.MaxLength = 10;
            this.txtTabela.Name = "txtTabela";
            this.txtTabela.ReadOnly = true;
            this.txtTabela.Size = new System.Drawing.Size(100, 23);
            this.txtTabela.TabIndex = 0;
            // 
            // txtNomaCampo
            // 
            this.txtNomaCampo.Location = new System.Drawing.Point(118, 24);
            this.txtNomaCampo.MaxLength = 10;
            this.txtNomaCampo.Name = "txtNomaCampo";
            this.txtNomaCampo.Size = new System.Drawing.Size(100, 23);
            this.txtNomaCampo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id da Tabela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do Campo";
            // 
            // cbTipoCampo
            // 
            this.cbTipoCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCampo.FormattingEnabled = true;
            this.cbTipoCampo.Items.AddRange(new object[] {
            "Varchar",
            "Preço",
            "Imposto",
            "Quantidade",
            "Percentaagem",
            "Unidade",
            "Inteiro",
            "BOOLEAN"});
            this.cbTipoCampo.Location = new System.Drawing.Point(224, 24);
            this.cbTipoCampo.Name = "cbTipoCampo";
            this.cbTipoCampo.Size = new System.Drawing.Size(121, 23);
            this.cbTipoCampo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo do Campo";
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(351, 24);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(100, 23);
            this.txtTamanho.TabIndex = 8;
            this.txtTamanho.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tamanho";
            // 
            // ckPrimarykey
            // 
            this.ckPrimarykey.AutoSize = true;
            this.ckPrimarykey.Location = new System.Drawing.Point(12, 54);
            this.ckPrimarykey.Name = "ckPrimarykey";
            this.ckPrimarykey.Size = new System.Drawing.Size(89, 19);
            this.ckPrimarykey.TabIndex = 10;
            this.ckPrimarykey.Text = "Primary Key";
            this.ckPrimarykey.UseVisualStyleBackColor = true;
            // 
            // ckNotnull
            // 
            this.ckNotnull.AutoSize = true;
            this.ckNotnull.Location = new System.Drawing.Point(107, 54);
            this.ckNotnull.Name = "ckNotnull";
            this.ckNotnull.Size = new System.Drawing.Size(69, 19);
            this.ckNotnull.TabIndex = 11;
            this.ckNotnull.Text = "Not null";
            this.ckNotnull.UseVisualStyleBackColor = true;
            // 
            // ckAutoIncremento
            // 
            this.ckAutoIncremento.AutoSize = true;
            this.ckAutoIncremento.Location = new System.Drawing.Point(200, 54);
            this.ckAutoIncremento.Name = "ckAutoIncremento";
            this.ckAutoIncremento.Size = new System.Drawing.Size(116, 19);
            this.ckAutoIncremento.TabIndex = 12;
            this.ckAutoIncremento.Text = "Auto Incremento";
            this.ckAutoIncremento.UseVisualStyleBackColor = true;
            // 
            // ckUnico
            // 
            this.ckUnico.AutoSize = true;
            this.ckUnico.Location = new System.Drawing.Point(322, 54);
            this.ckUnico.Name = "ckUnico";
            this.ckUnico.Size = new System.Drawing.Size(57, 19);
            this.ckUnico.TabIndex = 13;
            this.ckUnico.Text = "Unico";
            this.ckUnico.UseVisualStyleBackColor = true;
            // 
            // ckEstrangeira
            // 
            this.ckEstrangeira.AutoSize = true;
            this.ckEstrangeira.Location = new System.Drawing.Point(12, 90);
            this.ckEstrangeira.Name = "ckEstrangeira";
            this.ckEstrangeira.Size = new System.Drawing.Size(120, 19);
            this.ckEstrangeira.TabIndex = 14;
            this.ckEstrangeira.Text = "Chave Estrangeira";
            this.ckEstrangeira.UseVisualStyleBackColor = true;
            this.ckEstrangeira.CheckedChanged += new System.EventHandler(this.ckEstrangeira_CheckedChanged);
            this.ckEstrangeira.CheckStateChanged += new System.EventHandler(this.ckEstrangeira_CheckStateChanged);
            // 
            // cbTabelaPai
            // 
            this.cbTabelaPai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTabelaPai.Enabled = false;
            this.cbTabelaPai.FormattingEnabled = true;
            this.cbTabelaPai.Location = new System.Drawing.Point(12, 115);
            this.cbTabelaPai.Name = "cbTabelaPai";
            this.cbTabelaPai.Size = new System.Drawing.Size(224, 23);
            this.cbTabelaPai.TabIndex = 15;
            this.cbTabelaPai.SelectedIndexChanged += new System.EventHandler(this.cbTabelaPai_SelectedIndexChanged);
            // 
            // cbCPai
            // 
            this.cbCPai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCPai.Enabled = false;
            this.cbCPai.FormattingEnabled = true;
            this.cbCPai.Location = new System.Drawing.Point(242, 115);
            this.cbCPai.Name = "cbCPai";
            this.cbCPai.Size = new System.Drawing.Size(168, 23);
            this.cbCPai.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 157);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmCriarCampo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 213);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbCPai);
            this.Controls.Add(this.cbTabelaPai);
            this.Controls.Add(this.ckEstrangeira);
            this.Controls.Add(this.ckUnico);
            this.Controls.Add(this.ckAutoIncremento);
            this.Controls.Add(this.ckNotnull);
            this.Controls.Add(this.ckPrimarykey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTipoCampo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomaCampo);
            this.Controls.Add(this.txtTabela);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCriarCampo";
            this.ShowIcon = false;
            this.Text = "Criar Campo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        public Button btnAdd;
        public TextBox txtTabela;
        public TextBox txtNomaCampo;
        public ComboBox cbTipoCampo;
        public TextBox txtTamanho;
        public CheckBox ckPrimarykey;
        public CheckBox ckNotnull;
        public CheckBox ckAutoIncremento;
        public CheckBox ckUnico;
        public CheckBox ckEstrangeira;
        public ComboBox cbTabelaPai;
        public ComboBox cbCPai;
    }
}