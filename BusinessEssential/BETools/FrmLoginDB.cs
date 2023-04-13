using BasesBE;
using System.Text;

namespace BETools
{
    public partial class FrmLoginDB : Form
    {
        public FrmLoginDB()
        {
            InitializeComponent();
        }
        Login login;
        DBBE.CRUD CRUD = new DBBE.CRUD();
        private void btnCriar_Click(object sender, EventArgs e)
        {
            try
            {

                login = new Login();
                login.Servidor = txtServidor.Text;
                login.Porta = txtPorta.Text;
                login.Senha = txtSenha.Text;
                login.Usuario = txtLogin.Text;
                login.GerarArquivo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmConfigurar_Load(object sender, EventArgs e)
        {

        }
    }
}