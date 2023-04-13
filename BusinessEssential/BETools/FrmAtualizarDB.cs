using DBBE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BETools
{
    public partial class FrmAtualizarDB : Form
    {
        public FrmAtualizarDB()
        {
            InitializeComponent();
            crud = new CRUD();
            crud.DB = EnunDB.config;
            cbTabela.DataSource = crud.SelectDT("SELECT * FROM beconfig.cadastrosdb");
            cbTabela.ValueMember = "id";
            cbTabela.DisplayMember = "Nome";
            cbTabela.SelectedIndex = 0;
        }
        CRUD crud;
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //AtualizarDB db = new AtualizarDB();
            //db.Executar(Convert.ToInt32(cbTabela.SelectedValue));
        }
    }
}
