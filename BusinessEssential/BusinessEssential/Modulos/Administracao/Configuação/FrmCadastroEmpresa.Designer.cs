namespace BusinessEssential.Modulos.Administracao.Configuação
{
    partial class FrmCadastroEmpresa
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
            this.DataLista = new Essential.BEDataGridView();
            this.BEDCID = new Essential.BEDataGridViewTextBoxColumn();
            this.BEDCRazaoSocial = new Essential.BEDataGridViewTextBoxColumn();
            this.BEDCNFantasia = new Essential.BEDataGridViewTextBoxColumn();
            this.BEDCNomeFilial = new Essential.BEDataGridViewTextBoxColumn();
            this.BEDCCNPJ = new Essential.BEDataGridViewTextBoxColumn();
            this.BEDCLogarouro = new Essential.BEDataGridViewTextBoxColumn();
            this.BEDCNumero = new Essential.BEDataGridViewTextBoxColumn();
            this.BEDCComplemento = new Essential.BEDataGridViewTextBoxColumn();
            this.BEDCBairro = new Essential.BEDataGridViewTextBoxColumn();
            this.BEDCCEP = new Essential.BEDataGridViewTextBoxColumn();
            this.BEDCidPais = new Essential.BEDataGridViewComboBoxColumn();
            this.BEDCidEstado = new Essential.BEDataGridViewComboBoxColumn();
            this.BEDCidMunicipi = new Essential.BEDataGridViewComboBoxColumn();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataLista)).BeginInit();
            this.SuspendLayout();
            // 
            // DataLista
            // 
            this.DataLista.AllowUserToDeleteRows = false;
            this.DataLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataLista.BackgroundColor = System.Drawing.Color.White;
            this.DataLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BEDCID,
            this.BEDCRazaoSocial,
            this.BEDCNFantasia,
            this.BEDCNomeFilial,
            this.BEDCCNPJ,
            this.BEDCLogarouro,
            this.BEDCNumero,
            this.BEDCComplemento,
            this.BEDCBairro,
            this.BEDCCEP,
            this.BEDCidPais,
            this.BEDCidEstado,
            this.BEDCidMunicipi});
            this.DataLista.Location = new System.Drawing.Point(12, 26);
            this.DataLista.MultiSelect = false;
            this.DataLista.Name = "DataLista";
            this.DataLista.RowHeadersWidth = 25;
            this.DataLista.RowTemplate.Height = 25;
            this.DataLista.Size = new System.Drawing.Size(721, 383);
            this.DataLista.TabIndex = 0;
            this.DataLista.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataLista_CellEndEdit);
            this.DataLista.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataLista_CellLeave);
            this.DataLista.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataLista_CellValueChanged);
            // 
            // BEDCID
            // 
            this.BEDCID.Campo = null;
            this.BEDCID.HeaderText = "ID";
            this.BEDCID.Name = "BEDCID";
            this.BEDCID.ReadOnly = true;
            this.BEDCID.Tabela = null;
            this.BEDCID.Width = 50;
            // 
            // BEDCRazaoSocial
            // 
            this.BEDCRazaoSocial.Campo = null;
            this.BEDCRazaoSocial.HeaderText = "Razão Social";
            this.BEDCRazaoSocial.Name = "BEDCRazaoSocial";
            this.BEDCRazaoSocial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BEDCRazaoSocial.Tabela = null;
            this.BEDCRazaoSocial.Width = 200;
            // 
            // BEDCNFantasia
            // 
            this.BEDCNFantasia.Campo = null;
            this.BEDCNFantasia.HeaderText = "Nome Fantasia";
            this.BEDCNFantasia.Name = "BEDCNFantasia";
            this.BEDCNFantasia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BEDCNFantasia.Tabela = null;
            this.BEDCNFantasia.Width = 200;
            // 
            // BEDCNomeFilial
            // 
            this.BEDCNomeFilial.Campo = null;
            this.BEDCNomeFilial.HeaderText = "Nome da filial";
            this.BEDCNomeFilial.Name = "BEDCNomeFilial";
            this.BEDCNomeFilial.Tabela = null;
            this.BEDCNomeFilial.Width = 200;
            // 
            // BEDCCNPJ
            // 
            this.BEDCCNPJ.Campo = null;
            this.BEDCCNPJ.HeaderText = "CNPJ";
            this.BEDCCNPJ.Name = "BEDCCNPJ";
            this.BEDCCNPJ.Tabela = null;
            this.BEDCCNPJ.Width = 150;
            // 
            // BEDCLogarouro
            // 
            this.BEDCLogarouro.Campo = null;
            this.BEDCLogarouro.HeaderText = "Logadouro";
            this.BEDCLogarouro.Name = "BEDCLogarouro";
            this.BEDCLogarouro.Tabela = null;
            this.BEDCLogarouro.Width = 200;
            // 
            // BEDCNumero
            // 
            this.BEDCNumero.Campo = null;
            this.BEDCNumero.HeaderText = "Numero";
            this.BEDCNumero.Name = "BEDCNumero";
            this.BEDCNumero.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BEDCNumero.Tabela = null;
            // 
            // BEDCComplemento
            // 
            this.BEDCComplemento.Campo = null;
            this.BEDCComplemento.HeaderText = "Complemento";
            this.BEDCComplemento.Name = "BEDCComplemento";
            this.BEDCComplemento.Tabela = null;
            this.BEDCComplemento.Width = 200;
            // 
            // BEDCBairro
            // 
            this.BEDCBairro.Campo = null;
            this.BEDCBairro.HeaderText = "Bairro";
            this.BEDCBairro.Name = "BEDCBairro";
            this.BEDCBairro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BEDCBairro.Tabela = null;
            // 
            // BEDCCEP
            // 
            this.BEDCCEP.Campo = null;
            this.BEDCCEP.HeaderText = "CEP";
            this.BEDCCEP.Name = "BEDCCEP";
            this.BEDCCEP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BEDCCEP.Tabela = null;
            // 
            // BEDCidPais
            // 
            this.BEDCidPais.Campo = "idPais";
            this.BEDCidPais.display = "Nome";
            this.BEDCidPais.HeaderText = "Pais";
            this.BEDCidPais.Name = "BEDCidPais";
            this.BEDCidPais.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BEDCidPais.Tabela = "becadastro";
            this.BEDCidPais.Width = 150;
            // 
            // BEDCidEstado
            // 
            this.BEDCidEstado.Campo = "idEstado";
            this.BEDCidEstado.display = "Nome";
            this.BEDCidEstado.HeaderText = "Estado";
            this.BEDCidEstado.Name = "BEDCidEstado";
            this.BEDCidEstado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BEDCidEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BEDCidEstado.Tabela = "becadastro";
            this.BEDCidEstado.Width = 150;
            // 
            // BEDCidMunicipi
            // 
            this.BEDCidMunicipi.Campo = "idMunicipi";
            this.BEDCidMunicipi.display = null;
            this.BEDCidMunicipi.HeaderText = "Municipio";
            this.BEDCidMunicipi.Name = "BEDCidMunicipi";
            this.BEDCidMunicipi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BEDCidMunicipi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BEDCidMunicipi.Tabela = "becadastro";
            this.BEDCidMunicipi.Width = 150;
            // 
            // btn1
            // 
            this.btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn1.Location = new System.Drawing.Point(12, 415);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "OK";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn2.Location = new System.Drawing.Point(93, 415);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "Cancelar";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.DataLista);
            this.Name = "FrmCadastroEmpresa";
            this.ShowIcon = false;
            this.Text = "Cadastro da Empresa";
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Essential.BEDataGridView DataLista;
        private Button btn1;
        private Button btn2;
        private Essential.BEDataGridViewTextBoxColumn BEDCID;
        private Essential.BEDataGridViewTextBoxColumn BEDCRazaoSocial;
        private Essential.BEDataGridViewTextBoxColumn BEDCNFantasia;
        private Essential.BEDataGridViewTextBoxColumn BEDCNomeFilial;
        private Essential.BEDataGridViewTextBoxColumn BEDCCNPJ;
        private Essential.BEDataGridViewTextBoxColumn BEDCLogarouro;
        private Essential.BEDataGridViewTextBoxColumn BEDCNumero;
        private Essential.BEDataGridViewTextBoxColumn BEDCComplemento;
        private Essential.BEDataGridViewTextBoxColumn BEDCBairro;
        private Essential.BEDataGridViewTextBoxColumn BEDCCEP;
        private Essential.BEDataGridViewComboBoxColumn BEDCidPais;
        private Essential.BEDataGridViewComboBoxColumn BEDCidEstado;
        private Essential.BEDataGridViewComboBoxColumn BEDCidMunicipi;
    }
}