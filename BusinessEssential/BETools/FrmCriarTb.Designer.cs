namespace BETools
{
    partial class FrmCriarTb
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
            this.txtNTabela = new System.Windows.Forms.TextBox();
            this.txtDescri = new System.Windows.Forms.TextBox();
            this.cbTbPai = new System.Windows.Forms.ComboBox();
            this.ckTbFilho = new System.Windows.Forms.CheckBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ckDelCas = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtNTabela
            // 
            this.txtNTabela.Location = new System.Drawing.Point(99, 12);
            this.txtNTabela.MaxLength = 10;
            this.txtNTabela.Name = "txtNTabela";
            this.txtNTabela.Size = new System.Drawing.Size(181, 23);
            this.txtNTabela.TabIndex = 1;
            // 
            // txtDescri
            // 
            this.txtDescri.Location = new System.Drawing.Point(99, 41);
            this.txtDescri.MaxLength = 30;
            this.txtDescri.Name = "txtDescri";
            this.txtDescri.Size = new System.Drawing.Size(181, 23);
            this.txtDescri.TabIndex = 2;
            // 
            // cbTbPai
            // 
            this.cbTbPai.Enabled = false;
            this.cbTbPai.FormattingEnabled = true;
            this.cbTbPai.Location = new System.Drawing.Point(99, 70);
            this.cbTbPai.Name = "cbTbPai";
            this.cbTbPai.Size = new System.Drawing.Size(181, 23);
            this.cbTbPai.TabIndex = 3;
            // 
            // ckTbFilho
            // 
            this.ckTbFilho.AutoSize = true;
            this.ckTbFilho.Location = new System.Drawing.Point(114, 100);
            this.ckTbFilho.Name = "ckTbFilho";
            this.ckTbFilho.Size = new System.Drawing.Size(88, 19);
            this.ckTbFilho.TabIndex = 4;
            this.ckTbFilho.Text = "Tabela Filho";
            this.ckTbFilho.UseVisualStyleBackColor = true;
            this.ckTbFilho.CheckedChanged += new System.EventHandler(this.ckTbFilho_CheckedChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 180);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(99, 180);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "Sair";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome da Tabela";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tabela Pai";
            // 
            // ckDelCas
            // 
            this.ckDelCas.AutoSize = true;
            this.ckDelCas.Enabled = false;
            this.ckDelCas.Location = new System.Drawing.Point(113, 125);
            this.ckDelCas.Name = "ckDelCas";
            this.ckDelCas.Size = new System.Drawing.Size(121, 19);
            this.ckDelCas.TabIndex = 11;
            this.ckDelCas.Text = "Deleta em cascata";
            this.ckDelCas.UseVisualStyleBackColor = true;
            // 
            // FrmCriarTb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 226);
            this.Controls.Add(this.ckDelCas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.ckTbFilho);
            this.Controls.Add(this.cbTbPai);
            this.Controls.Add(this.txtDescri);
            this.Controls.Add(this.txtNTabela);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCriarTb";
            this.ShowIcon = false;
            this.Text = "Criar Tabela";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn2;
        private Label label2;
        private Label label3;
        private Label label4;
        public TextBox txtNTabela;
        public TextBox txtDescri;
        public ComboBox cbTbPai;
        public CheckBox ckTbFilho;
        public Button btn1;
        private CheckBox ckDelCas;
    }
}