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
    public partial class FrmControle : Form
    {
        public FrmControle()
        {
            //InitializeComponent();
        }

        public static FrmBase oform;
        public static Frm oformInicial;
        public static void Incial(Form form)
        {
            //oform = (FrmBase)form;
            //oformInicial.btform = oform.bform;
            //oform.btn2();
            //oform.Formatar();
            //oform.ClickBTN(oform.sform);
            //form.StartPosition = FormStartPosition.CenterScreen;
            //oform.Activated += new System.EventHandler(oform.Frm_Activated);
        }
    }
}
