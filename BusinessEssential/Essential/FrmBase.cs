using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essential
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            //Incial(this);
            //btn2();
            //ClickBTN();
            FrmControle.oform = (FrmBase)this;
            this.Activated += new System.EventHandler(Frm_Activated);
        }
        public static void Incial()
        {
        }
        public Statusforms sform
        {
            get
            { return _sform; }
            set
            {
                _sform = value;
                ClickBTN();
            }
        }
        private Statusforms _sform;
        //public BtnIniciar bform { get; set; }
        //private BtnIniciar _bform;
        public string Tabela { get { return _Tabela; } set { _Tabela = value; } }
        private string _Tabela;
        public void Frm_Activated(object sender, EventArgs e)
        {
            FrmControle.oform = (FrmBase)this;
            BtnInicial();
        }
        public void BtnInicial()
        {
            if (_Tabela == "" || _Tabela == null)
            {
                var method = FrmControle.oformInicial.GetType().GetMethod("DesativarTBS");
                method.Invoke(FrmControle.oformInicial, parameters: null);

            }
            else
            {
                var method = FrmControle.oformInicial.GetType().GetMethod("AtivarTBS");
                method.Invoke(FrmControle.oformInicial, parameters: null);
            }

        }
        public void ClickBTN()
        {
            MStatus();
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(TextBoxBE))
                {
                    if (((TextBoxBE)item).Campo == "id")
                    {
                        ((TextBoxBE)item).ReadOnly = Configure.StatusID(sform);
                        ((TextBoxBE)item).Text = string.Empty;
                    }
                    if (this.sform == Statusforms.OK)
                    {
                        ((TextBox)item).TextChanged += new System.EventHandler(this.Text_TextChanged);
                    }
                    if (this.sform == Statusforms.Procurar)
                    {
                        ((TextBox)item).TextChanged -= new System.EventHandler(this.Text_TextChanged);
                    }
                    if (this.sform == Statusforms.Atualizar)
                    {
                        ((TextBox)item).TextChanged -= new System.EventHandler(this.Text_TextChanged);
                    }
                    if (this.sform == Statusforms.Adicionar)
                    {
                        ((TextBox)item).TextChanged -= new System.EventHandler(this.Text_TextChanged);
                    }
                }
                if (item.GetType() == typeof(BEDataGridView))
                {
                    //if (((BEDataGridViewTextBoxColumn)item).Campo == "id")
                    //{
                    //    ((BEDataGridViewTextBoxColumn)item).ReadOnly = Configure.StatusID(sform);
                    //    ((BEDataGridViewTextBoxColumn)item).Text = string.Empty;
                    //}
                    if (this.sform == Statusforms.OK)
                    {
                        ((BEDataGridView)item).CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.BeDataGridView_CellValueChanged);
                    }
                    if (this.sform == Statusforms.Procurar)
                    {
                        ((BEDataGridView)item).CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.BeDataGridView_CellValueChanged);
                    }
                    if (this.sform == Statusforms.Atualizar)
                    {
                        ((BEDataGridView)item).CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.BeDataGridView_CellValueChanged);
                    }
                    if (this.sform == Statusforms.Adicionar)
                    {
                        ((BEDataGridView)item).CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.BeDataGridView_CellValueChanged);
                    }
                }

            }
        }
        public void CorTexBox()
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    item.BackColor = Configure.CorTexBox(this.sform);
                }
                if (item.GetType() == typeof(TextBoxBE))
                {
                    item.BackColor = Configure.CorTexBox(this.sform);
                }
                if (this.sform == Statusforms.Procurar)
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        item.Text = string.Empty; //limpa todos os controles do tipo TextBox
                    }
                    if (item.GetType() == typeof(TextBoxBE))
                    {
                        item.Text = string.Empty; //limpa todos os controles do tipo TextBox
                    }
                    if (item.GetType() == typeof(CheckBoxBE))
                    {
                        ((CheckBox)item).Checked = false; //limpa todos os controles do tipo TextBox
                    }
                    if (item.GetType() == typeof(RadioButtonBE))
                    {
                        ((RadioButtonBE)item).Checked = false; //limpa todos os controles do tipo TextBox
                    }
                    if (item.GetType() == typeof(TabControl))
                    {
                        foreach (Control item2 in ((TabControl)item).Controls)
                        {
                            foreach (Control item3 in ((TabPage)item2).Controls)
                            {
                                if (item3.GetType() == typeof(DataGridView))
                                {
                                    ((DataGridView)item3).Rows.Clear();
                                    ((DataGridView)item3).Refresh();
                                }
                            }
                        }
                    }
                }
            }
        }
        private void Text_TextChanged(object sender, EventArgs e)
        {
            if (sform == Statusforms.OK)
            {
                sform = Statusforms.Atualizar;
                //MStatus();
            }
        }
        private void BeDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (sform == Statusforms.OK)
            {
                sform = Statusforms.Atualizar;
                //MStatus();
            }
        }
        internal void Formatar()
        {
            FontFamily family = new FontFamily("Calibri");
            foreach (Control item in this.Controls)
            {
                item.Font = new Font(family, 9.0f, FontStyle.Regular);
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void MStatus()
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(Button))
                {
                    if (item.Name == "btn1")
                    {
                        if (Statusforms.OK == this.sform)
                        {
                            item.Text = "OK";
                        }
                        if (Statusforms.Adicionar == this.sform)
                        {
                            item.Text = "Adicionar";
                        }
                        if (Statusforms.Atualizar == this.sform)
                        {
                            item.Text = "Atualizar";
                        }
                        if (Statusforms.Procurar == this.sform)
                        {
                            item.Text = "Procurar";
                        }
                    }
                    if (item.Name == "btn2")
                    {
                        if (item.Text != "Cancelar")
                        {
                            item.Text = "Cancelar";

                            if (item.Name == "btn2")
                            {
                                ((Button)item).Click += new System.EventHandler(this.btn2_Click);
                            }
                        }
                    }
                }
            }
            CorTexBox();
        }
        public void TSBPesquisar_Click()
        {
            FrmControle.oform.sform = Statusforms.Procurar;

            //ClickBTN();
        }
        public void TSBPrimeiro_Click()
        {
            try
            {
                //var pegar = new List<BEEntity>();
                //foreach (Control item in FrmControle.oform.Controls)
                //{
                //    pegar
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public List<BEEntity> CriarBeEntity(object obj, string tabela)
        {
            List<BEEntity> obj1 = new List<BEEntity>();
            foreach (var item in obj.GetType().GetProperties())
            {
                if (item.Name != "Tabela")
                {
                    BEEntity entity = new BEEntity();
                    entity.Tabela = tabela;
                    entity.Campo = item.Name;
                    entity.Valor = item.GetValue(obj).ToString();
                    obj1.Add(entity);
                }
            }
            return obj1;
        }
        public void achou(List<BEEntity> obj)
        {
            DataTable dt = new DataTable();
            foreach (var item in FrmControle.oform.Controls)
            {
                if (item.GetType() == typeof(TextBoxBE))
                {
                    if (((TextBoxBE)item).Campo.Length > 0)
                    {
                        ((TextBoxBE)item).Text = obj.Where(p => p.Campo.Equals(((TextBoxBE)item).Campo) && p.Tabela.Equals(((TextBoxBE)item).Tabela)).Select(p => p.Valor).SingleOrDefault().ToString();
                        if (((TextBoxBE)item).Campo == "Id")
                        {
                            ((TextBoxBE)item).ReadOnly = true;
                        }
                    }
                }
                if (item.GetType() == typeof(RadioButtonBE))
                {
                    if (((RadioButtonBE)item).Campo.Length > 0)
                        ((RadioButtonBE)item).Checked = Convert.ToBoolean(obj.Where(p => p.Campo.Equals(((RadioButtonBE)item).Campo) && p.Tabela.Equals(((RadioButtonBE)item).Tabela)).Select(p => p.Valor).SingleOrDefault());
                }
                if (item.GetType() == typeof(CheckBoxBE))
                {
                    if (((CheckBoxBE)item).Campo.Length > 0)
                        ((CheckBoxBE)item).Checked = Convert.ToBoolean(obj.Where(p => p.Campo.Equals(((CheckBoxBE)item).Campo) && p.Tabela.Equals(((CheckBoxBE)item).Tabela)).Select(p => p.Valor).SingleOrDefault());
                }


                sform = Statusforms.OK;
                MStatus();
            }
        }
        #region Atributos
        public PictureBox title = new PictureBox();
        public Label minimise = new Label();
        public Label maximise = new Label();
        public Label close = new Label();
        public bool drag = false;
        public Point startPoint = new Point(0, 0);
        #endregion Atributos
        public void Frm_Load(object sender, EventArgs e)
        {


        }
        public void MainForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.title.Location = this.Location;
            this.title.Width = this.Width;
            this.title.Height = 50;
            this.title.BackColor = Color.Black;
            this.Controls.Add(this.title);
            this.minimise.Text = "Minimise";
            this.minimise.Location = new Point(this.Location.X + 5, this.Location.Y + 5);
            this.minimise.ForeColor = Color.Red;
            this.minimise.BackColor = Color.Black;
            this.Controls.Add(this.minimise);
            this.minimise.BringToFront();
            this.maximise.Text = "Maximise";
            this.maximise.Location = new Point(this.Location.X + 60, this.Location.Y + 5);
            this.maximise.ForeColor = Color.Red;
            this.maximise.BackColor = Color.Black;
            this.maximise.Width = 50;
            this.Controls.Add(this.maximise);
            this.maximise.BringToFront();
            this.close.Text = "Close";
            this.close.Location = new Point(this.Location.X + 120, this.Location.Y + 5);
            this.close.ForeColor = Color.Red;
            this.close.BackColor = Color.Black;
            this.close.Width = 37;
            this.Controls.Add(this.close);
            this.close.BringToFront();
            this.minimise.MouseEnter += new EventHandler(Control_MouseEnter);
            this.maximise.MouseEnter += new EventHandler(Control_MouseEnter);
            this.close.MouseEnter += new EventHandler(Control_MouseEnter);
            this.minimise.MouseLeave += new EventHandler(Control_MouseLeave);
            this.maximise.MouseLeave += new EventHandler(Control_MouseLeave);
            this.close.MouseLeave += new EventHandler(Control_MouseLeave);
            this.title.MouseDown += new MouseEventHandler(Title_MouseDown);
            this.title.MouseUp += new MouseEventHandler(Title_MouseUp);
            this.title.MouseMove += new MouseEventHandler(Title_MouseMove);
        }
        public void Control_MouseEnter(object sender, EventArgs e)
        {
            if (sender.Equals(this.close))
                this.close.ForeColor = Color.White;
            else if (sender.Equals(this.maximise))
                this.maximise.ForeColor = Color.White;
            else // it's the minimise label
                this.minimise.ForeColor = Color.White;
        }
        private void Control_MouseLeave(object sender, EventArgs e)
        {
            if (sender.Equals(this.close))
                this.close.ForeColor = Color.Red;
            else if (sender.Equals(this.maximise))
                this.maximise.ForeColor = Color.Red;
            else
                this.minimise.ForeColor = Color.Red;
        }

        private void Control_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender.Equals(this.close))
                this.Close(); // close the form
            else if (sender.Equals(this.maximise))
            {
                if (this.maximise.Text == "Maximise")
                {
                    this.WindowState = FormWindowState.Maximized; // maximise the form
                    this.maximise.Text = "Restore"; // change the text
                    this.title.Width = this.Width; // stretch the title bar
                }
                else // we need to restore
                {
                    this.WindowState = FormWindowState.Normal;
                    this.maximise.Text = "Maximise";
                }
            }
            else
                this.WindowState = FormWindowState.Minimized;
        }
        void Title_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        void Title_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;
            this.drag = true;
        }

        void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.startPoint.X,
                                     p2.Y - this.startPoint.Y);
                this.Location = p3;
            }
        }
    }
}

